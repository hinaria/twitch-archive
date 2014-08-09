import request from "request";
import rsvp from "./rsvp";
import { Promise } from "./rsvp";

// attempt a queued at most `MAX_QUEUE_DEPTH` times.
const MAX_QUEUE_DEPTH = 5;

let resolved_promise = () => new Promise(resolve => resolve());
let semaphores = [resolved_promise()]; // ghetto lock that limits the number of concurrent downloads
let counter = 0;

let self = {
    // url:      url to download
    // callback: callback to call when starting the callback. use this to
    //               configure the request object or attach event handlers to
    //               its completion. it will be called when a download request
    //               is attempted. this may occur multiple times due to
    //               previous failures
    //
    //               THIS CALLBACK MAY BE CALLED SEVERAL TIMES.
    //
    //               prototype: function(request)
    //
    // bypass_queue: internal variable. do not use.
    // bypass_depth: internal variable. do not use.
    //
    queue(url, callback, bypass_queue = false, bypass_depth = 0) {
        callback = callback || function() { };

        let deferred = rsvp.defer();
        let promise = deferred.promise;

        let index = bypass_queue ? -1 : (++counter % semaphores.length);
        let next = bypass_queue ? resolved_promise() : semaphores[index];

        if (bypass_queue == false)
            semaphores[index] = promise;

        next.then(function() {
            let request_object = request(url).on("error", function() {
                if (bypass_depth > MAX_QUEUE_DEPTH)
                    deferred.resolve();
                else
                    self.queue(url, callback, true, bypass_depth + 1).then(_ => deferred.resolve());
            }).on("end", function() {
                deferred.resolve();
            });

            callback(request_object);
        });

        return promise;
    },

    limit(concurrent_downloads) {
        if (concurrent_downloads < 1)
            throw "must have at least one concurrent connection";

        while (semaphores.length > concurrent_downloads)
            semaphores.pop();

        while (semaphores.length < concurrent_downloads)
            semaphores.push(resolved_promise());
    }
};

export default self;
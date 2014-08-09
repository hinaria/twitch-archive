import request from "request";
import rsvp from "./rsvp";
import { Promise } from "./rsvp";

let resolved_promise = () => new Promise(resolve => resolve());

// ghetto lock that limits the number of concurrent downloads
let semaphores = [resolved_promise()];
let counter = 0;

export default {
    queue(...args) {
        let index = ++counter % semaphores.length;
        let next = semaphores[index];
        let deferred = rsvp.defer();
        semaphores[index] = deferred.promise;

        return new Promise(function(resolve, reject) {
            next.then(function() {
                let req = request(...args).on("end", _ => deferred.resolve());
                resolve(req);
            });
        });
    },

    limit(concurrent_downloads) {
        if (concurrent_downloads < 1)
            throw "must have at least one concurrent connection";

        while (semaphores.length > concurrent_downloads)
            semaphores.pop();

        while (semaphores.length < concurrent_downloads)
            semaphores.push(resolved_promise());
    }
}
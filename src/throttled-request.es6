import request from "request";
import rsvp from "./rsvp";
import { Promise } from "./rsvp";

// ghetto lock that only allows one concurrent download at a time
let sempahore = new Promise(resolve => resolve());

export default {
    queue(...args) {
        let next = sempahore;
        let deferred = rsvp.defer();
        sempahore = deferred.promise;

        return new Promise(function(resolve, reject) {
            next.then(function() {
                let req = request(...args).on("end", _ => deferred.resolve());
                resolve(req);
            });
        });
    }
}
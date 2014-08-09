import fs from "fs";
import request from "request";
import throttled_request from "./throttled-request";
import { create_directories_for_file } from "./fs";
import { Promise } from "./rsvp";

export default {
    request(url) {
        return new Promise(function(resolve, reject) {
            request({ uri: url }, function(error, response, body) {
                if (error)
                    reject(error);
                else
                    resolve(body);
            });
        });
    },

    get(url) {
        return this.request(url).then(JSON.parse);
    },

    download(url, destination, callback) {
        return throttled_request.queue(url, function(req) {
            create_directories_for_file(destination);
            let file = fs.createWriteStream(destination);

            req.pipe(file)
                .on("error", x => file.close())
                .on("end", x => file.close());

            callback(req);
        });
    }
}
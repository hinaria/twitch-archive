import fs from "fs";
import http from "http";
import request from "request";
import throttled_request from "./throttled-request";
import { create_directories_for_file, exists, size } from "./fs";
import { Promise } from "./rsvp";

http.maxSockets = 999999999;

export default {
    request(url) {
        return new Promise(function(resolve, reject) {
            request.get(url, function(error, response, body) {
                if (error)
                    reject(error);
                else
                    resolve(body);
            });
        });
    },

    head(url) {
        return new Promise(function(resolve, reject) {
            request.head(url, function(error, response) {
                if (error)
                    reject(error);
                else
                    resolve(response);
            });
        });
    },

    get(url) {
        return this.request(url).then(JSON.parse);
    },

    download(url, destination, callback) {
        let do_download = function() {
            return throttled_request.queue(url, function(req) {
                create_directories_for_file(destination);
                let file = fs.createWriteStream(destination);

                req.pipe(file)
                    .on("error", _ => file.close())
                    .on("end", _ => file.close());

                callback(req);
            });
        };

        if (exists(destination)) {
            return this.head(url).then(function(response) {
                if (response.headers["content-length"] != size(destination))
                    return do_download();
            });
        } else {
            return do_download();
        }
    }
};
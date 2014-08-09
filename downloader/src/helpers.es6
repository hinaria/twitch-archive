import http from "./http";
import { Promise } from "./rsvp";
let array = Array;

export var get_videos = function(channel_name) {
    return new Promise(function(resolve, reject) {
        let videos = [];

        let fetch = function(url) {
            http.get(url).then(function(response) {
                if (response.videos && response.videos.length > 0) {
                    array.prototype.push.apply(videos, response.videos);
                    fetch(response._links.next);
                } else {
                    resolve(videos);
                }
            });
        };

        fetch(`https://api.twitch.tv/kraken/channels/${channel_name}/videos?limit=100&offset=0&broadcasts=true&on_site=1`);
    });
};

export var make_array = function(obj) {
    if (Array.isArray(obj))
        return obj;
    return [obj];
};
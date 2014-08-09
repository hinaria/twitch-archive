import path from "path";
import http from "./http";
import { get_videos } from "./helpers";
import { when_all } from "./rsvp";

// helpers
// ---

let pad_string = function(string) {
    var str = `${string}`;
    let pad = "00";
    return pad.substring(0, pad.length - str.length) + str;
};

let file_name_for_broadcast = function(broadcast) {
    // 2014-00-00T00:00:00Z => 2014-01-01 00-00-00
    let date = broadcast.recorded_at.replace("T", " ").replace("Z", "").replace(/:/g, "-");
    let name = broadcast.title.replace(/["*/:<>?.|□\\]/g, "_");
    return `${date} - ${name}`;
};

// exports
// ---

var api = {
    counters: {
        started: 0,
        total: 0,
        completed: 0,

        get queued() {
            return this.total - this.started;
        }
    },

    download_users(channel_names, destination) {
        if (!channel_names || channel_names.length == 0)
            return;

        return when_all(
            channel_names.map(name => api.download_user(name, destination)));
    },

    download_user(channel_name, destination) {
        console.log(`${channel_name}: searching for videos`);

        return get_videos(channel_name).then(function(videos) {
            console.log(`${channel_name}: ${videos.length} videos found`);

            return when_all(
                videos.map(x => api.download_broadcast(
                    x._id,
                    path.join(destination, channel_name, file_name_for_broadcast(x)),
                    `${x.channel.name} - ${x.title}`)));
        });
    },

    download_broadcasts(broadcast_ids, destination) {
        if (!broadcast_ids || broadcast_ids.length == 0)
            return;
        
        return when_all(
            broadcast_ids.map(id => api.download_broadcast(id, path.join(destination, id))));
    },

    download_broadcast(broadcast_id, destination, friendly_name = null) {
        return http.get(`https://api.twitch.tv/api/videos/${broadcast_id}?on_site=1`).then(function(response) {
            let chunks = response.chunks.live;

            let resources = chunks.map(function(chunk, index) {
                let padded_index = pad_string(index);
                return {
                    friendly_name: friendly_name || `${broadcast_id}#${index}`,
                    url: chunk.url,
                    index: index,
                    destination: path.join(destination, `${broadcast_id}-${padded_index}.flv`)
                };
            });

            return when_all(resources.map(function(resource) {
                let counters = api.counters;
                let promise = http.download(resource.url, resource.destination);

                counters.total++;

                return promise.then(function(request) {
                    counters.started++;
                    
                    let message = `downloading ${counters.started} of ${counters.total}: ${resource.friendly_name}`;
                    console.log(message.substring(0, 80));

                    request.on("end", _ => counters.completed++);
                });
            }));
        });
    }
};

export default api;


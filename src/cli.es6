import api from "./api";
import throttled_request from "./throttled-request";
import { make_array } from "./helpers";
import { when_all } from "./rsvp";

export default function main(params) {
    if (!params.destination)
        throw "no destination was specified";
    
    params.users = make_array(params.users);
    params.videos = make_array(params.videos).map(x => `a${x}`);

    throttled_request.limit(params.concurrent_downloads_limit);

    when_all([
        api.download_broadcasts(params.videos, params.destination),
        api.download_users(params.users, params.destination)
    ]).then(_ => console.log("everything finished!"));
};
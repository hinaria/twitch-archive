import api from "./api";
import { make_array } from "./helpers";
import { when_all } from "./rsvp";

export default function main(params) {
    if (!params.destination)
        throw "no destination was specified";

    params.users = make_array(params.users);
    params.videos = make_array(params.videos);

    when_all([
        api.download_users(params.users, params.destination),
        api.download_broadcasts(params.videos, params.destination)
    ]).then(_ => console.log("everything finished!"));
};
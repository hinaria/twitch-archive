import RSVP from "rsvp";

export default RSVP;
export var Promise = RSVP.Promise;
export var when_all = RSVP.all;

if (process.env["DEBUG"]) {
    RSVP.on("error", reason => console.assert(false, reason));
}
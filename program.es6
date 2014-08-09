import main from "./src/cli";
import minimist from "minimist";

let args = minimist(process.argv.slice(2), {
    "alias": {
        "u": "users",
        "v": "videos",
        "b": "videos",
        "d": "destination"
    },
    "default": {
        "users": [],
        "videos": [],
        "destination": ""
    }
});

main(args);
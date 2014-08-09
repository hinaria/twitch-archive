import main from "./src/cli";
import minimist from "minimist";

let args = minimist(process.argv.slice(2), {
    "alias": {
        "u": "users",
        "v": "videos",
        "b": "videos",
        "d": "destination",
        "i": "interactive",
        "l": "concurrent_downloads_limit"
    },
    "default": {
        "users": [],
        "videos": [],
        "destination": "",
        "interactive": false,
        "concurrent_downloads_limit": 5
    }
});

main(args);
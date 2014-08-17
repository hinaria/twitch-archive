import fs from "fs";
import mkdirp from "mkdirp";
import path from "path";

export var create_directories = function(directory) {
    mkdirp.sync(directory);
};

export var create_directories_for_file = function(file_name) {
    let directory = path.dirname(file_name);
    return create_directories(directory);
};

export var exists = function(file_name) {
    return fs.existsSync(file_name);
};

export var size = function(file_name) {
    let stats = fs.statSync(file_name);
    return stats.size;
};
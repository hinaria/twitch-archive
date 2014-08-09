import ProgressBar from "progress";

// attach to the `request` npm module.
export var attach_request = function(request) {
    let bar = null;
    request.on("data", function(chunk) {
        let length = parseInt(request.response.headers["content-length"], 10);
        if (length <= 0)
            return;

        bar = bar || new ProgressBar("downloading... [:bar] :percent :etas", {
            complete: '=',
            incomplete: ' ',
            width: 25,
            total: length
        });

        bar.tick(chunk.length)
    });

    request.on("end", _ => bar.tick(bar.total - bar.curr));
};
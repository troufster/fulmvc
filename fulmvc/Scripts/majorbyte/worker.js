var timeOut = 0;
var running = false;
function timedCount() {
    console.log("timedCount");
    var xhr;
    try {
        xhr = new XMLHttpRequest();
        xhr.open('GET', "/majorbyte/home/cpu", false);
        xhr.setRequestHeader('Content-Type', 'text/plain');
        xhr.onreadystatechange = function () {
            if (xhr.readyState == 4 && xhr.status == 200) {
                self.postMessage(xhr.responseText);
            }
        };
        xhr.send();
    } catch (e) {
        self.postMessage('Error occured in XMLHttpRequest: ' + xhr.statusText + '  ReadyState: ' + xhr.readyState + ' Status:' + xhr.status + ' E: ' + e + ' Msg:' + e.message);
    }
    finally {
        if (running) {
            setTimeout("timedCount()", timeOut);
        }
    }
};


self.onmessage = function (e) {
    switch (e.data.cmd) {
        case "start":
            running = true;
            timedCount();
            break;
        case "change":
            timeOut = e.data.value;
            break;
        case "stop":
            running = false;;
            break;
    }
}



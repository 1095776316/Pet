!function (win) {
    let Prompt = function () {

    }
    Prompt.prototype.success = function (message, callBack) {
        _alter(1, message, callBack);
    }

    Prompt.prototype.error = function (message, callBack) {
        _alter(2, message, callBack);
    }

    Prompt.prototype.confirm = function (message, callBack) {
        _alter(3, message, callBack);
    }

    Prompt.prototype.lock = function (message, callBack) {
        _alter(4, message, callBack);
    }
    Prompt.prototype.cry = function (message, callBack) {
        _alter(5, message, callBack);
    }

    Prompt.prototype.smile = function (message, callBack) {
        _alter(6, message, callBack);
    }

    Prompt.prototype.warn = function (message, callBack) {
        _alter(7, message, callBack);
    }

    let _alter = function (icon, message, callBack) {
        layer.alert(message, { icon: icon }, function (index) {
            if (callBack) {
                callBack();
            }
            layer.close(index);
        });
    }

    win.prompt = new Prompt();
}(window)
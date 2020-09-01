!function (win) {
    let Reponse = function () {

    }

    Reponse.prototype.reponse_validate = function (res) {
        if (res != undefined && res.errors != undefined && res.errors.length > 0) {
            let msgs = `${res.message}<br/>` ;
            res.errors.map(_d => {
                msgs += `${_d}<br/>`;
            });
            prompt.warn(msgs);
            return false;
        }
        return true;
    }
    win.reponse = new Reponse();
}(window)
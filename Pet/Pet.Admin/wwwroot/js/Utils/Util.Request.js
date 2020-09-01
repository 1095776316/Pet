!function (win) {
    let Request = function () {

    }

    Request.prototype.ajax = function (opt) {
        let index = 0;
        let options = {
            url: opt.url,
            type: opt.type,
            data: JSON.stringify(opt.data),
            contentType: 'application/json;charset=UTF-8',
            xhrFields: {
                withCredentials: true
            },
            success(res) {
                if (res.code === 2) {
                    win.location.href = "/";
                }
                if (res.code === 1) {
                    opt.success(res);
                }
                else {
                    hg.msg(`${res.code}:${res.message}`);
                }
                layer.close(index);
            },
            beforeSend(req) {
                index = layer.load(1, {
                    shade: [0.1, '#fff'] //0.1透明度的白色背景
                });
            }, error(res) {
                hg.msg("网络请求失败！");
                //hg.msg(`${res.responseText}`);
                layer.close(index);
            }
        }
        $.ajax(options);
    }

    win.request = new Request();
}(window)
$(document).ready(function () {
    $("form").submit(function () {
        if ($(this).valid()) {
            showAjaxLoader();
        }
        else {
            hideAjaxLoader();
        }
    });
});

$(document).ajaxStart(function () {
    showAjaxLoader();
});

$(document).ajaxError(function () {
    hideAjaxLoader();
});
$(document).ajaxStop(function () {
    hideAjaxLoader();
});
$(document).on("click", "button", function () {
    showAjaxLoader();
    if ($(this).hasClass("multiselect")) {
        hideAjaxLoader();
    }
    if ($(this).hasClass("close")) {
        hideAjaxLoader();
    }
    if ($(this).hasClass("modalClose")) {
        hideAjaxLoader();
    }
});
$(document).on("click", "a", function () {
    showAjaxLoader();
    if ($(this).attr("href").indexOf("#") >= 0) {
        hideAjaxLoader();
    }
    var attr = $(this).attr('class');
    if (typeof attr !== typeof undefined && attr !== false && attr != '') {
        var class_name = $(this).attr('class');
        if (class_name.indexOf("cke") >= 0) {
            hideAjaxLoader();
        }
    }
});


//show ajax please wait window
function showAjaxLoader() {
    if ($("#ajaxLoader") !== undefined && $("#ajaxLoader") !== null)
        $("#ajaxLoader").modal({ keyboard: false, backdrop: 'static' });
}

//hide ajax please wait window
function hideAjaxLoader() {
    if ($("#ajaxLoader") !== undefined && $("#ajaxLoader") !== null)
        $("#ajaxLoader").modal("hide");
}
$(document).on("click", "#closeCustomAlert", function () {
    $(document).find("#ajaxLoader").modal("hide");
});
customAlert = function (bodyText) {
    bodyText = bodyText || '';
    var modalHTML = '<div class="modal fade" role="dialog"><div class="modal-dialog"><div class="modal-content">' +
        '<div class="modal-header"><button type="button" class="close" data-dismiss="modal">&times;</button>' +
        '<h4 class="modal-title">Alert</h4>' +
        '</div><div class="modal-body">' + bodyText + '</div><div class="modal-footer">' +
        '<button type="button" class="btn btn-default" id="closeCustomAlert" data-dismiss="modal">Close</button></div></div></div></div>';
    return $(modalHTML).modal().show().centerModal();
    //show = function () {
    //    debugger;
    //    $(modalHTML).modal().show().centerModal();
    //}
    //return { show: show }
}
$.fn.centerModal = function () {
    this.focus();
    this.css("position", "fixed");
    this.find(".modal-dialog").css("margin-top", jQuery(window).scrollTop() + "px");
    return this;
}

//For hiding the please wait dialogue after file download
//ref: http://gruffcode.com/2010/10/28/detecting-the-file-download-dialog-in-the-browser/ 
var fileDowloadTimer;
function fileDownloadAjaxLoader() {
    var fileDownloadCheck = new Date().getTime();

    //Create a model property named "FileDownloadCheck" and 
    //create a hidden field for that property on view
    $("#FileDownloadCheck").val(fileDownloadCheck);
    //showAjaxLoader();

    fileDowloadTimer = setInterval(function () {
        var downloadCookie = $.cookie("downloadCookie");
        if (downloadCookie === fileDownloadCheck) {
            finishFileDownloadAjaxDownload();
        }
    }, 1000);
}
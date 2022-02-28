//Nav bar onscroll fade in and out
$(document).ready(function () {
    $(window).scroll(function () {
        if ($(this).scrollTop() < 100) {
            $(".custom-header-fixed").css({ "background": "rgb(0, 0, 0, 0)" })
        }
        else {
            $(".custom-header-fixed").css({ "background": "rgb(0, 0, 0, 0.8)" })
        }
    })
})
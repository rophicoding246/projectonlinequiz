function startTime() {
    var today = new Date();
    var h = today.getHours();
    var m = today.getMinutes();
    var s = today.getSeconds();
    var listday = ["Chủ nhật", "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy"];
    m = checkTime(m);
    s = checkTime(s);
    document.getElementById('timetoday').innerHTML = h + ":" + m + ":" + s;
    document.getElementById('datetoday').innerHTML = listday[today.getDay()] + ", " + today.getDate() + "-" + (today.getMonth() + 1) + "-" + today.getFullYear();
    var t = setTimeout(startTime, 500);
}

function checkTime(i) {
    if (i < 10) { i = "0" + i };
    return i;
}

(function($) {
    $(window).scroll(function() {
        if ($(".navbar").offset().top > 70) {
            $(".top-area").addClass("top-padding");
            $(".sidebar").addClass("top-padding");
            $("#wrapper #content-wrapper").addClass("top-padding");
        } else {
            $(".top-area").removeClass("top-padding");
            $(".sidebar").removeClass("top-padding");
            $("#wrapper #content-wrapper").removeClass("top-padding");
        }
    });


    // Toggle the side navigation
    $("#sidebarToggle").click(function(e) {
        e.preventDefault();
        $("body").toggleClass("sidebar-toggled");
        $(".sidebar").toggleClass("toggled");
        $("#wrapper #content-wrapper").toggleClass("left-margin");
    });

})(jQuery);

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

$(window).scroll(function() {
    if ($(".navbar").offset().top > 70) {
        $(".top-area").addClass("top-padding");

    } else {
        $(".top-area").removeClass("top-padding");
    }
});

(function($) {
    "use strict"; // Start of use strict

    // Toggle the side navigation
    $("#sidebarToggle").click(function(e) {
        e.preventDefault();
        $("body").toggleClass("sidebar-toggled");
        $(".sidebar").toggleClass("toggled");
    });

    // Prevent the content wrapper from scrolling when the fixed side navigation hovered over
    $('body.fixed-nav .sidebar').on('mousewheel DOMMouseScroll wheel', function(e) {
        if ($window.width() > 768) {
            var e0 = e.originalEvent,
                delta = e0.wheelDelta || -e0.detail;
            this.scrollTop += (delta < 0 ? 1 : -1) * 30;
            e.preventDefault();
        }
    });

    // Scroll to top button appear
    $(document).scroll(function() {
        var scrollDistance = $(this).scrollTop();
        if (scrollDistance > 100) {
            $('.scroll-to-top').fadeIn();
        } else {
            $('.scroll-to-top').fadeOut();
        }
    });

    // Smooth scrolling using jQuery easing
    $(document).on('click', 'a.scroll-to-top', function(event) {
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: ($($anchor.attr('href')).offset().top)
        }, 1000, 'easeInOutExpo');
        event.preventDefault();
    });

})(jQuery); // End of use strict
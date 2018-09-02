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

/* $(window).scroll(function() {
    if ($(".navbar").offset().top > 50) {
        $(".navbar-fixed-top").addClass("top-nav-collapse");
        $(".top-area").addClass("top-padding");
        $(".navbar-brand").addClass("reduce");

        $(".navbar-custom ul.nav ul.dropdown-menu").css("margin-top", "11px");

    } else {
        $(".navbar-fixed-top").removeClass("top-nav-collapse");
        $(".top-area").removeClass("top-padding");
        $(".navbar-brand").removeClass("reduce");

        $(".navbar-custom ul.nav ul.dropdown-menu").css("margin-top", "16px");

    }
}); */

/*global jQuery:false */
(function($) {
    var wow = new WOW({
        boxClass: 'wow', // animated element css class (default is wow)
        animateClass: 'animated', // animation css class (default is animated)
        offset: 0, // distance to the element when triggering the animation (default is 0)
        mobile: false // trigger animations on mobile devices (true is default)
    });
    wow.init();

    //jQuery to collapse the navbar on scroll
    $(window).scroll(function() {
        if ($(".navbar-light").offset().top > 50) {
            $(".top-area").addClass("top-padding");
            document.getElementById('test').innerHTML = "OK";
        } else {
            document.getElementById('test').innerHTML = "Fail";
            $(".top-area").removeClass("top-padding");
        }
    });

    //scroll to top
    $(window).scroll(function() {
        if ($(this).scrollTop() > 100) {
            $('.scrollup').fadeIn();
        } else {
            $('.scrollup').fadeOut();
        }
    });
    $('.scrollup').click(function() {
        $("html, body").animate({ scrollTop: 0 }, 1000);
        return false;
    });



    //jQuery for page scrolling feature - requires jQuery Easing plugin
    $(function() {
        $('.navbar-nav li a').bind('click', function(event) {
            var $anchor = $(this);
            var nav = $($anchor.attr('href'));
            if (nav.length) {
                $('html, body').stop().animate({
                    scrollTop: $($anchor.attr('href')).offset().top
                }, 1500, 'easeInOutExpo');

                event.preventDefault();
            }
        });
        $('.page-scroll a').bind('click', function(event) {
            var $anchor = $(this);
            $('html, body').stop().animate({
                scrollTop: $($anchor.attr('href')).offset().top
            }, 1500, 'easeInOutExpo');
            event.preventDefault();
        });
    });
})(jQuery);

$(window).load(function() {
    $(".loader").delay(100).fadeOut();
    $("#page-loader").delay(100).fadeOut("fast");
});

(function ($) {
    "use strict";
  
    $(window).scroll(function () {
        var distanceTop = $('#last').offset().top - $(window).height();

        if ($(window).scrollTop() > distanceTop)
            $('#slidebox').animate({ 'right': '0px' }, 300);
        else
            $('#slidebox').stop(true).animate({ 'right': '-430px' }, 100);
    });

    $('#slidebox .close').bind('click', function () {
        $(this).parent().remove();
    });
 
})(jQuery);


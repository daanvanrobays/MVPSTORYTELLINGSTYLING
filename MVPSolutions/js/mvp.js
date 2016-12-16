// Closes the sidebar menu
$("#menu-close").click(function (e) {
    e.preventDefault();
    $("#sidebar-wrapper").toggleClass("active");
});

// Opens the sidebar menu
$("#menu-toggle").click(function (e) {
    e.preventDefault();
    $("#sidebar-wrapper").toggleClass("active");
});

// Scrolls to the selected menu item on the page
$(function () {
    $('a[href*=#]:not([href=#])').click(function () {
        if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') || location.hostname == this.hostname) {

            var target = $(this.hash);
            target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
            if (target.length) {
                $('html,body').animate({
                    scrollTop: target.offset().top
                }, 1000);
                return false;
            }
        }
    });
});

//Lightbox options
lightbox.option({
    'alwaysShowNavOnTouchDevices': true,
    'wrapAround': true,
    'albumLabel': ''
})

$(function () {
    if ($("#container").length) {
        var $container = $('#container').masonry({
            // use outer width of grid-sizer for columnWidth
            columnWidth: 1,
            // do not use .grid-sizer in layout
            itemSelector: '.grid-item',
            percentPosition: true
        });
        // reveal initial images
        $container.masonryImagesReveal($('.grid').find('.grid-item'));
    }
    if ($("#concept-container").length) {
        var $conceptcontainer = $('#concept-container').masonry({
            // use outer width of grid-sizer for columnWidth
            columnWidth: 1,
            // do not use .grid-sizer in layout
            itemSelector: '.grid-item',
            percentPosition: true
        });
    }

    //window.setInterval(function () {
    //    $('.header').css('backgroundImage', 'url(../images/Marrakech-7.jpg)');
    //    window.setTimeout(function () {
    //        $('.header').css('backgroundImage', 'url(../images/secondheader.jpg)');
    //    }, 5 * 1000);
    //}, 10 * 1000);
});

$.fn.masonryImagesReveal = function ($items) {
    var msnry = this.data('masonry');
    var itemSelector = msnry.options.itemSelector;
    // hide by default
    $items.hide();
    // append to container
    this.append($items);
    $items.imagesLoaded().progress(function (imgLoad, image) {
        // get item
        // image is imagesLoaded class, not <img>, <img> is image.img
        var $item = $(image.img).parents(itemSelector);
        // un-hide item
        $item.show();
        // masonry does its thing
        msnry.appended($item);
    });

    return this;
};
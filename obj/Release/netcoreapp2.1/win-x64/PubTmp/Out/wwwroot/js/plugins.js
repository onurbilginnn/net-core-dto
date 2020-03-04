// Avoid `console` errors in browsers that lack a console.
(function() {
    var method;
    var noop = function () {};
    var methods = [
        'assert', 'clear', 'count', 'debug', 'dir', 'dirxml', 'error',
        'exception', 'group', 'groupCollapsed', 'groupEnd', 'info', 'log',
        'markTimeline', 'profile', 'profileEnd', 'table', 'time', 'timeEnd',
        'timeline', 'timelineEnd', 'timeStamp', 'trace', 'warn'
    ];
    var length = methods.length;
    var console = (window.console = window.console || {});

    while (length--) {
        method = methods[length];

        // Only stub undefined methods.
        if (!console[method]) {
            console[method] = noop;
        }
    }
}());

// Place any jQuery/helper plugins in here.

/*!
 * scrollup v2.4.1
 * Url: http://markgoodyear.com/labs/scrollup/
 * Copyright (c) Mark Goodyear — @markgdyr — http://markgoodyear.com
 * License: MIT
 */
!function (l, o, e) { "use strict"; l.fn.scrollUp = function (o) { l.data(e.body, "scrollUp") || (l.data(e.body, "scrollUp", !0), l.fn.scrollUp.init(o)) }, l.fn.scrollUp.init = function (r) { var s, t, c, i, n, a, d, p = l.fn.scrollUp.settings = l.extend({}, l.fn.scrollUp.defaults, r), f = !1; switch (d = p.scrollTrigger ? l(p.scrollTrigger) : l("<a/>", { id: p.scrollName, href: "#top" }), p.scrollTitle && d.attr("title", p.scrollTitle), d.appendTo("body"), p.scrollImg || p.scrollTrigger || d.html(p.scrollText), d.css({ display: "none", position: "fixed", zIndex: p.zIndex }), p.activeOverlay && l("<div/>", { id: p.scrollName + "-active" }).css({ position: "absolute", top: p.scrollDistance + "px", width: "100%", borderTop: "1px dotted" + p.activeOverlay, zIndex: p.zIndex }).appendTo("body"), p.animation) { case "fade": s = "fadeIn", t = "fadeOut", c = p.animationSpeed; break; case "slide": s = "slideDown", t = "slideUp", c = p.animationSpeed; break; default: s = "show", t = "hide", c = 0 }i = "top" === p.scrollFrom ? p.scrollDistance : l(e).height() - l(o).height() - p.scrollDistance, n = l(o).scroll(function () { l(o).scrollTop() > i ? f || (d[s](c), f = !0) : f && (d[t](c), f = !1) }), p.scrollTarget ? "number" == typeof p.scrollTarget ? a = p.scrollTarget : "string" == typeof p.scrollTarget && (a = Math.floor(l(p.scrollTarget).offset().top)) : a = 0, d.click(function (o) { o.preventDefault(), l("html, body").animate({ scrollTop: a }, p.scrollSpeed, p.easingType) }) }, l.fn.scrollUp.defaults = { scrollName: "scrollUp", scrollDistance: 300, scrollFrom: "top", scrollSpeed: 300, easingType: "linear", animation: "fade", animationSpeed: 200, scrollTrigger: !1, scrollTarget: !1, scrollText: "Scroll to top", scrollTitle: !1, scrollImg: !1, activeOverlay: !1, zIndex: 2147483647 }, l.fn.scrollUp.destroy = function (r) { l.removeData(e.body, "scrollUp"), l("#" + l.fn.scrollUp.settings.scrollName).remove(), l("#" + l.fn.scrollUp.settings.scrollName + "-active").remove(), l.fn.jquery.split(".")[1] >= 7 ? l(o).off("scroll", r) : l(o).unbind("scroll", r) }, l.scrollUp = l.fn.scrollUp }(jQuery, window, document);

/*
 LAZY LOAD
 */
(function (a, b) { if (typeof exports === "object") { module.exports = b(a) } else { if (typeof define === "function" && define.amd) { define([], b) } else { a.LazyLoad = b(a) } } })(typeof global !== "undefined" ? global : this.window || this.global, function (a) { if (typeof define === "function" && define.amd) { a = window } const c = { src: "data-src", srcset: "data-srcset", selector: ".lazyload", root: null, rootMargin: "0px", threshold: 0 }; const e = function () { let extended = {}; let deep = false; let i = 0; let length = arguments.length; if (Object.prototype.toString.call(arguments[0]) === "[object Boolean]") { deep = arguments[0]; i++ } let merge = function (f) { for (let prop in f) { if (Object.prototype.hasOwnProperty.call(f, prop)) { if (deep && Object.prototype.toString.call(f[prop]) === "[object Object]") { extended[prop] = e(true, extended[prop], f[prop]) } else { extended[prop] = f[prop] } } } }; for (; i < length; i++) { let obj = arguments[i]; merge(obj) } return extended }; function d(f, g) { this.settings = e(c, g || {}); this.images = f || document.querySelectorAll(this.settings.selector); this.observer = null; this.init() } d.prototype = { init: function () { if (!a.IntersectionObserver) { this.loadImages(); return } let self = this; let observerConfig = { root: this.settings.root, rootMargin: this.settings.rootMargin, threshold: [this.settings.threshold] }; this.observer = new IntersectionObserver(function (f) { Array.prototype.forEach.call(f, function (g) { if (g.isIntersecting) { self.observer.unobserve(g.target); let src = g.target.getAttribute(self.settings.src); let srcset = g.target.getAttribute(self.settings.srcset); if ("img" === g.target.tagName.toLowerCase()) { if (src) { g.target.src = src } if (srcset) { g.target.srcset = srcset } } else { g.target.style.backgroundImage = "url(" + src + ")" } } }) }, observerConfig); Array.prototype.forEach.call(this.images, function (f) { self.observer.observe(f) }) }, loadAndDestroy: function () { if (!this.settings) { return } this.loadImages(); this.destroy() }, loadImages: function () { if (!this.settings) { return } let self = this; Array.prototype.forEach.call(this.images, function (f) { let src = f.getAttribute(self.settings.src); let srcset = f.getAttribute(self.settings.srcset); if ("img" === f.tagName.toLowerCase()) { if (src) { f.src = src } if (srcset) { f.srcset = srcset } } else { f.style.backgroundImage = "url('" + src + "')" } }) }, destroy: function () { if (!this.settings) { return } this.observer.disconnect(); this.settings = null } }; a.lazyload = function (f, g) { return new d(f, g) }; if (a.jQuery) { const b = a.jQuery; b.fn.lazyload = function (f) { f = f || {}; f.attribute = f.attribute || "data-src"; new d(b.makeArray(this), f); return this } } return d });









/*
Template Name: Adminto - Responsive Bootstrap 5 Admin Dashboard
Author: CoderThemes
Website: https://coderthemes.com/
Contact: support@coderthemes.com
File: Main Js File
*/


!function ($) {
    "use strict";

    var Components = function () {
    };

    //initializing tooltip
    Components.prototype.initTooltipPlugin = function () {
        $.fn.tooltip && $('[data-bs-toggle="tooltip"]').tooltip()
    },

        //initializing popover
        Components.prototype.initPopoverPlugin = function () {
            $.fn.popover && $('[data-bs-toggle="popover"]').popover()
        },

        //initializing toast
        Components.prototype.initToastPlugin = function () {
            $.fn.toast && $('[data-bs-toggle="toast"]').toast()
        },

        //initializing form validation
        Components.prototype.initFormValidation = function () {
            $(".needs-validation").on('submit', function (event) {
                $(this).addClass('was-validated');
                if ($(this)[0].checkValidity() === false) {
                    event.preventDefault();
                    event.stopPropagation();
                    return false;
                }
                return true;
            });
        },

        // Counterup
        Components.prototype.initCounterUp = function () {
            var delay = $(this).attr('data-delay') ? $(this).attr('data-delay') : 100; //default is 100
            var time = $(this).attr('data-time') ? $(this).attr('data-time') : 1200; //default is 1200
            $('[data-plugin="counterup"]').each(function (idx, obj) {
                $(this).counterUp({
                    delay: delay,
                    time: time
                });
            });
        },

        //peity charts
        Components.prototype.initPeityCharts = function () {
            $('[data-plugin="peity-pie"]').each(function (idx, obj) {
                var colors = $(this).attr('data-colors') ? $(this).attr('data-colors').split(",") : [];
                var width = $(this).attr('data-width') ? $(this).attr('data-width') : 20; //default is 20
                var height = $(this).attr('data-height') ? $(this).attr('data-height') : 20; //default is 20
                $(this).peity("pie", {
                    fill: colors,
                    width: width,
                    height: height
                });
            });
            //donut
            $('[data-plugin="peity-donut"]').each(function (idx, obj) {
                var colors = $(this).attr('data-colors') ? $(this).attr('data-colors').split(",") : [];
                var width = $(this).attr('data-width') ? $(this).attr('data-width') : 20; //default is 20
                var height = $(this).attr('data-height') ? $(this).attr('data-height') : 20; //default is 20
                $(this).peity("donut", {
                    fill: colors,
                    width: width,
                    height: height
                });
            });

            $('[data-plugin="peity-donut-alt"]').each(function (idx, obj) {
                $(this).peity("donut");
            });

            // line
            $('[data-plugin="peity-line"]').each(function (idx, obj) {
                $(this).peity("line", $(this).data());
            });

            // bar
            $('[data-plugin="peity-bar"]').each(function (idx, obj) {
                var colors = $(this).attr('data-colors') ? $(this).attr('data-colors').split(",") : [];
                var width = $(this).attr('data-width') ? $(this).attr('data-width') : 20; //default is 20
                var height = $(this).attr('data-height') ? $(this).attr('data-height') : 20; //default is 20
                $(this).peity("bar", {
                    fill: colors,
                    width: width,
                    height: height
                });
            });
        },

        Components.prototype.initKnob = function () {
            $('[data-plugin="knob"]').each(function (idx, obj) {
                $(this).knob();
            });
        },

        Components.prototype.initTippyTooltips = function () {
            if ($('[data-plugin="tippy"]').length > 0) {
                tippy('[data-plugin="tippy"]');
            }
        },

        Components.prototype.initShowPassword = function () {
            $("[data-password]").on('click', function () {
                if ($(this).attr('data-password') == "false") {
                    $(this).siblings("input").attr("type", "text");
                    $(this).attr('data-password', 'true');
                    $(this).addClass("show-password");
                } else {
                    $(this).siblings("input").attr("type", "password");
                    $(this).attr('data-password', 'false');
                    $(this).removeClass("show-password");
                }
            });
        },

        Components.prototype.initMultiDropdown = function () {
            $('.dropdown-menu a.dropdown-toggle').on('click', function (e) {
                if (!$(this).next().hasClass('show')) {
                    $(this).parents('.dropdown-menu').first().find('.show').removeClass("show");
                }
                var $subMenu = $(this).next(".dropdown-menu");
                $subMenu.toggleClass('show');

                return false;
            });
        },

        //initilizing
        Components.prototype.init = function () {
            this.initTooltipPlugin(),
                this.initPopoverPlugin(),
                this.initToastPlugin(),
                this.initFormValidation(),
                this.initCounterUp(),
                this.initPeityCharts(),
                this.initKnob();
            this.initTippyTooltips();
            this.initShowPassword();
            this.initMultiDropdown();
        },

        $.Components = new Components, $.Components.Constructor = Components

}(window.jQuery),

    function ($) {
        "use strict";

        /**
         Portlet Widget
         */
        var Portlet = function () {
            this.$body = $("body"),
                this.$portletIdentifier = ".card",
                this.$portletCloser = '.card a[data-toggle="remove"]',
                this.$portletRefresher = '.card a[data-toggle="reload"]'
        };

        //on init
        Portlet.prototype.init = function () {
            // Panel closest
            var $this = this;
            $(document).on("click", this.$portletCloser, function (ev) {
                ev.preventDefault();
                var $portlet = $(this).closest($this.$portletIdentifier);
                var $portlet_parent = $portlet.parent();
                $portlet.remove();
                if ($portlet_parent.children().length == 0) {
                    $portlet_parent.remove();
                }
            });

            // Panel Reload
            $(document).on("click", this.$portletRefresher, function (ev) {
                ev.preventDefault();
                var $portlet = $(this).closest($this.$portletIdentifier);
                // This is just a simulation, nothing is going to be reloaded
                $portlet.append('<div class="card-disabled"><div class="card-portlets-loader"></div></div>');
                var $pd = $portlet.find('.card-disabled');
                setTimeout(function () {
                    $pd.fadeOut('fast', function () {
                        $pd.remove();
                    });
                }, 500 + 300 * (Math.random() * 5));
            });
        },
            //
            $.Portlet = new Portlet, $.Portlet.Constructor = Portlet

    }(window.jQuery),

    function ($) {
        'use strict';

        var App = function () {
            this.$body = $('body'),
                this.$window = $(window)
        };

        /**
         * Initlizes the controls
         */
        App.prototype.initControls = function () {
            // remove loading
            setTimeout(function () {
                document.body.classList.remove('loading');
            }, 350);

            // Preloader
            $(window).on('load', function () {
                $('#status').fadeOut();
                $('#preloader').delay(350).fadeOut('slow');
            });

            $('[data-toggle="fullscreen"]').on("click", function (e) {
                e.preventDefault();
                $('body').toggleClass('fullscreen-enable');
                if (!document.fullscreenElement && /* alternative standard method */ !document.mozFullScreenElement && !document.webkitFullscreenElement) {  // current working methods
                    if (document.documentElement.requestFullscreen) {
                        document.documentElement.requestFullscreen();
                    } else if (document.documentElement.mozRequestFullScreen) {
                        document.documentElement.mozRequestFullScreen();
                    } else if (document.documentElement.webkitRequestFullscreen) {
                        document.documentElement.webkitRequestFullscreen(Element.ALLOW_KEYBOARD_INPUT);
                    }
                } else {
                    if (document.cancelFullScreen) {
                        document.cancelFullScreen();
                    } else if (document.mozCancelFullScreen) {
                        document.mozCancelFullScreen();
                    } else if (document.webkitCancelFullScreen) {
                        document.webkitCancelFullScreen();
                    }
                }
            });
            document.addEventListener('fullscreenchange', exitHandler);
            document.addEventListener("webkitfullscreenchange", exitHandler);
            document.addEventListener("mozfullscreenchange", exitHandler);

            function exitHandler() {
                if (!document.webkitIsFullScreen && !document.mozFullScreen && !document.msFullscreenElement) {
                    $('body').removeClass('fullscreen-enable');
                }
            }
        },

            //initilizing
            App.prototype.init = function () {
                $.Portlet.init();
                $.Components.init();

                this.initControls();


                // showing the sidebar on load if user is visiting the page first time only
                // var bodyConfig = this.$body.data('layout');
                // if (window.sessionStorage && bodyConfig && bodyConfig.hasOwnProperty('showRightSidebarOnPageLoad') && bodyConfig['showRightSidebarOnPageLoad']) {
                //     var alreadyVisited = sessionStorage.getItem("_ADMINTO_VISITED_");
                //     if (!alreadyVisited) {
                //         $.RightBar.toggleRightSideBar();
                //         sessionStorage.setItem("_ADMINTO_VISITED_", true);
                //     }
                // }

                //Popovers
                var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'))
                var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
                    return new bootstrap.Popover(popoverTriggerEl)
                })

                //Tooltips
                var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
                var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
                    return new bootstrap.Tooltip(tooltipTriggerEl)
                })

                //Toasts
                var toastElList = [].slice.call(document.querySelectorAll('.toast'))
                var toastList = toastElList.map(function (toastEl) {
                    return new bootstrap.Toast(toastEl)
                })

                // Toasts Placement
                var toastPlacement = document.getElementById("toastPlacement");
                if (toastPlacement) {
                    document.getElementById("selectToastPlacement").addEventListener("change", function () {
                        if (!toastPlacement.dataset.originalClass) {
                            toastPlacement.dataset.originalClass = toastPlacement.className;
                        }
                        toastPlacement.className = toastPlacement.dataset.originalClass + " " + this.value;
                    });
                }

                // liveAlert
                var alertPlaceholder = document.getElementById('liveAlertPlaceholder')
                var alertTrigger = document.getElementById('liveAlertBtn')

                function alert(message, type) {
                    var wrapper = document.createElement('div')
                    wrapper.innerHTML = '<div class="alert alert-' + type + ' alert-dismissible" role="alert">' + message + '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button></div>'

                    alertPlaceholder.append(wrapper)
                }

                if (alertTrigger) {
                    alertTrigger.addEventListener('click', function () {
                        alert('Nice, you triggered this alert message!', 'primary')
                    })
                }


                if(document.getElementById('app-style').href.includes('rtl.min.css')){
                    document.getElementsByTagName('html')[0].dir="rtl";
                }
            },

            $.App = new App, $.App.Constructor = App


    }(window.jQuery),
//initializing main application module
    function ($) {
        "use strict";
        $.App.init();
    }(window.jQuery);

// Waves Effect
Waves.init();

// Feather Icons
feather.replace()

//create namespace if not exists
var ReleaseIt = ReleaseIt || function () { };
ReleaseIt.Controllers = ReleaseIt.Controllers || function () { };


//create PageLayoutController as module (for more info see: http://addyosmani.com/resources/essentialjsdesignpatterns/book/#modulepatternjavascript)
ReleaseIt.Controllers.PageLayoutController = (function () {

    var privateVar = 0;

    return {
        
        setLayout: function (element, layoutId) {
            $("#" + element).empty();
            var layout = $("#" + layoutId).first().html();
            $("#" + element).append(layout);
        }
    };

})();




//create namespace if not exists
var ReleaseIt = ReleaseIt || function () { };
ReleaseIt.Controllers = ReleaseIt.Controllers || function () { };


//create LoggerController as module (for more info see: http://addyosmani.com/resources/essentialjsdesignpatterns/book/#modulepatternjavascript)
ReleaseIt.Controllers.LoggerController = (function () {

    var privateVar = 0;

    return {

        writeLog: function (message) {
            $('logPanel').append(Date.now + ": " + message);
        }
    };

})();



//create namespace if not exists
var ReleaseIt = ReleaseIt || function () { };
ReleaseIt.ViewModels = ReleaseIt.ViewModels || function () { };

ReleaseIt.ViewModels.AddReleaseFormViewModel = (function () {

    return {

        addClick: function () {
            var title = this.title();
            var url = this.url();

            alert(title + '\n' + url);

        },

        title: ko.observable("type something"),
        url: ko.observable("http:// your url goes here")
    };

})();
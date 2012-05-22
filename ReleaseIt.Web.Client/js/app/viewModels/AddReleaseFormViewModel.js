
//create namespace if not exists
var ReleaseIt = ReleaseIt || function () { };
ReleaseIt.ViewModels = ReleaseIt.ViewModels || function () { };

ReleaseIt.ViewModels.AddReleaseFormViewModel = (function () {

    return {

        addClick: function () {
            var title = this.title();
            var url = this.url();

            $.ajax({
                url: "Api/ReleaseItem",
                data: {
                    Title: this.title(),
                    Uri: this.url(),
                    DomainType: this.domain(),
                    ReleaseType: this.category(),
                    Body: this.content()
                },
                type: 'PUT',
                dataType: 'json'
            });

        },

        title: ko.observable("title of release"),
        url: ko.observable("http://yoururlgoeshere.com"),
        content: ko.observable('content'),
        domain: ko.observable('0'),
        category: ko.observable('0')
    };

})();
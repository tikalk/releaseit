

//create namespace if not exists
var ReleaseIt = ReleaseIt || function () { };
ReleaseIt.ViewModels = ReleaseIt.ViewModels || function () { };


//create mainPageViewModel as module (for more info see: http://addyosmani.com/resources/essentialjsdesignpatterns/book/#modulepatternjavascript)
ReleaseIt.ViewModels.MainPageViewModel = (function () {

    var privateVar = 0;

    return {

        init: function () {
            ReleaseIt.Controllers.PageLayoutController.setLayout("top", "topLayout");
            ReleaseIt.Controllers.PageLayoutController.setLayout("mainLeft", "releasesLayout");
            ReleaseIt.Controllers.PageLayoutController.setLayout("mainRight", "domainListTemplate");
            ReleaseIt.Controllers.PageLayoutController.setLayout("head", "mainPageLayout");

            ko.applyBindings(this /*our data context*/, $("#topTemplate_TemplateContainer").get(0));
            ko.applyBindings(ReleaseIt.ViewModels.AddReleaseFormViewModel, $("#addReleaseFormTemplate_TemplateContainer").get(0));
            ko.applyBindings(ReleaseIt.ViewModels.ReleaseItemListViewModel, $("#releasesListTemplate_TemplateContainer").get(0));
            //ko.applyBindings(this /*our data context*/, $("#raeleasesListTemplate_TemplateContainer").get(0));
        }
    };

})();


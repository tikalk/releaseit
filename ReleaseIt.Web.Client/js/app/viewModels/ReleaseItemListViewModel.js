
//create namespace if not exists
var ReleaseIt = ReleaseIt || function () { };
ReleaseIt.ViewModels = ReleaseIt.ViewModels || function () { };

ReleaseIt.ViewModels.ReleaseItemListViewModel = (function () {

    var releaseItem = function (item) {
        return {
            title: ko.observable(item.Title),
            uri: ko.observable(item.Uri),
            content: ko.observable(item.Body),
            insertDate: ko.observable(item.CreateTime),
            author: ko.observable(item.author),
            domain: ko.observable(item.DomainType),
            category: ko.observable(item.ReleaseType),
            remove: function () {
                releaseItemsViewModel.releaseItems.remove(this);
            }
        }
    };

    return {

        releaseItems: ko.observableArray([]),

        refresh: function () {
            var This = this;
            // do ajax
            $.getJSON('Api/ReleaseItem', function (data, textStatus, jqXHR) {
                var array = [];
                $.each(data, function (index, item) {
                    array.push(releaseItem(item));
                });
                This.releaseItems(array);
            });
        }

    };
})();

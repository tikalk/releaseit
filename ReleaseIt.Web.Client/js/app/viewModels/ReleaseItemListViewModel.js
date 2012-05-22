
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

        releaseItems: ko.observableArray([
            new releaseItem({
                Title: 'item-1',
                Body: 'some content',
                CreateTime: '20/05/12',
                Uri: 'http://google.com'
            }),
            new releaseItem({
                Title: 'item-2',
                Body: 'some more content',
                CreateTime: '20/05/12',
                Uri: 'http://google.com'
            })
        ])

    };
})();

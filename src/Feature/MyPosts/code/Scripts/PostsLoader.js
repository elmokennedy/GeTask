function loadMore(source) {
    fetch(generateUrl(source))
        .then(response => response.json())
        .then(function (data) {
            var rows = returnRows(data);
            $('#postsTable').append(rows);
        });
}

function generateUrl(source) {
    var postsLimit = $('#loadMoreItemsCount').val();
    var itemsOnPage = $('.postItem').length;

    return source + "?_start=" + itemsOnPage + "&_limit=" + postsLimit;
}
 
function returnRows(data) {
    var trHTML = '';
    $.each(data, function (i, item) {
        trHTML += '<tr class="postItem">' +
            '<td style="text-align: center;">' + item.userId + '</td>' +
            '<td style="text-align: center;">' + item.title + '</td>' +
            '<td style="text-align: center;">' + item.body + '</td></tr>';
    });
    return trHTML;
}

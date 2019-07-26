<script src="http://code.jquery.com/jquery-1.11.3.min.js"></script>
<script>
    function loadMore() {
        var postsLimit = $('#loadMoreItemsCount').val();
        var itemsOnPage = $('.postItem').length;

        //$.ajax({
        //    url: "https://jsonplaceholder.typicode.com/posts?_start=" + itemsOnPage + "&_limit=" + postsLimit,
        //    dataType: 'jsonp',
        //    success: function (response) {
        //        var trHTML = '';
        //        $.each(response, function (i, item) {
        //            trHTML += '<tr class="postItem"><td style="text-align: center;">' + item.userId + '</td><td style="text-align: center;">' + item.title + '</td><td style="text-align: center;">' + item.body + '</td></tr>';
        //        });
        //        $('#postsTable').append(trHTML);
        //    }
        //});

        fetch("@Model.PostsInfoItem.Fields["SourceLink"].Value" + "?_start=" + itemsOnPage + "&_limit=" + postsLimit).then(function (response) {
            var trHTML = '';
            $.each(response, function (i, item) {
                trHTML += '<tr class="postItem"><td style="text-align: center;">' + item.userId + '</td><td style="text-align: center;">' + item.title + '</td><td style="text-align: center;">' + item.body + '</td></tr>';
            });
            $('#postsTable').append(trHTML);
            return response.json();
        });
    }
</script>
var uri = 'bookapi/books';

function getBooks() {
    var searchTitle = document.getElementById('search').value;
    var table = document.getElementById('bookTable');
    resetTable(table);
    
    $.ajax({
        url: uri + '/' + searchTitle,
        type: 'GET',
        dataType: 'json',
        success: function(data) {
            console.log(data);
            var index = 1;
            $.each(data, function (key, item) {

                var row = table.insertRow(index);

                var titleCell = row.insertCell(0);
                titleCell.innerHTML = item.title;

                var authorCell = row.insertCell(1);
                authorCell.innerHTML = item.author;

                var genreCell = row.insertCell(2);
                genreCell.innerHTML = item.genre;

                var priceCell = row.insertCell(3);
                priceCell.innerHTML = '$'+item.price;

                var descriptionCell = row.insertCell(4);
                descriptionCell.innerHTML = item.description;

                var dateCell = row.insertCell(5);
                dateCell.innerHTML = item.publishDate;
            });
            var tableDiv = document.getElementById("tableDiv");
            tableDiv.style.display = 'block';
        },
        error: function(error) {
            console.log(error);
        }
      });
}

function resetTable(table) {
    var rowCount = table.rows.length; 
    while(--rowCount) table.deleteRow(rowCount);
}



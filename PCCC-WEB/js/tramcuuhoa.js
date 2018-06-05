/// <reference path="../typings/globals/jquery/index.d.ts" />

$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "http://localhost:8177/api/tramcuuhoa",
        dataType: "json",
        success: function (data) {
            $('#th').append('<tr><th>ID</th><th>Name</th><th>Phone</th><th>Address</th><th>Lat</th><th>Lng</th></tr>');
            data.forEach(element => {
        
                $('#tb').append('<tr><td>'+element.id+'</td><td>'+element.name+'</td><td>'+element.phone+'</td><td>'+element.address+'</td><td>'+element.lat+'</td><td>'+element.lng+'</td><td><a id="btnDelete" href="#">Xóa</a></td></tr>');


            });
        }
    });
});



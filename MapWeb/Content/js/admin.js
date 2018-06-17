function initMap() {
    //init lat lng

    var geoCode = {
        lat: 21.036237,
        lng: 105.790583
    };
    //
    var directionsService = new google.maps.DirectionsService();

    //init map
    var element = document.getElementById('map'); // chỉ ra element cần tạo
    var map = new google.maps.Map(element, {
        zoom: 12,
        center: geoCode,

    });

    // marker
    var marker = new google.maps.Marker({
        map: map,
        position: geoCode
    });
    /// add test list fire station

    ////  sussget textbox
    var input = document.getElementById("textLocation")
    var autocomplete = new google.maps.places.Autocomplete(input);
    // textbox changed
    autocomplete.addListener('place_changed', function () {
        var place = autocomplete.getPlace();

        if (!place.geometry) {
            // User entered the name of a Place that was not suggested and
            // pressed the Enter key, or the Place Details request failed.
            window.alert("No details available for input: '" + place.name + "'");
            return;
        }

        // If the place has a geometry, then present it on a map.
        if (place.geometry.viewport) {
            map.fitBounds(place.geometry.viewport);
        } else {
            map.setCenter(place.geometry.location);
            map.setZoom(17); // Why 17? Because it looks good.
        }
        marker.setPosition(place.geometry.location);
        marker.setVisible(true);

        //  console.log(marker.getPosition().lat());
        console.log(marker.getPosition().lng());

    })

    // end susgest textbox  

    // add marker on click
    google.maps.event.addListener(map, 'click', function (event) {
        placeMarker(event.latLng);
    });

    function placeMarker(location) {

        marker.setPosition(location);
        marker.setVisible(true);

    }

    $.ajax({
        type: 'GET',
        url: "http://localhost:8177/api/baochay",
        dataType: 'json',
        success: function (data) {
            data.forEach(element => {
                var marker = new google.maps.Marker({
                    map: map,
                    position: {
                        lat: element.lat,
                        lng: element.lng
                    },
                    animation: google.maps.Animation.DROP,
                    icon: {
                        url: "../../Content/icon/fire.png",
                        scaledSize: {
                            width: 30,
                            height: 40
                        }
                    }
                });
                var contentInfoWindow = "<h6>" + element.address + element.county + element.city + "</h6>"
                contentInfoWindow += "</br>";

                contentInfoWindow += " <button id='" + element.id + "' class ='btn btn-success my-2 my-sm-0' onclick='handle(this)' type='submit'>Xử lý</button>";

                contentInfoWindow += " <button data-id='" + element.id + "' class ='btn btn-primary my-2 my-sm-0' onclick='ShowTruNuoc(this)'>Tìm Trụ Nước</button>";

                contentInfoWindow += " <button data-id='" + element.id + "' class ='btn btn-danger my-2 my-sm-0' onclick='DeleteBaoChay(this)'>Xóa</button>";

                var infowindow = new google.maps.InfoWindow({
                    content: contentInfoWindow
                });
                marker.addListener('click', function () {
                    infowindow.open(map, marker);
                });
            });

        },
        error: function (xhr, status, err) {
            console.log(err + "");

        }
    });


    // path
    // var polylineOptionsActual = new google.maps.Polyline({
    //     strokeColor: '#FF0000',
    //     strokeOpacity: 1.0,
    //     strokeWeight: 5
    //     });
    // var directionsDisplay = new google.maps.DirectionsRenderer({polylineOptions: polylineOptionsActual});
    // var request = {
    //     origin: {lat:21.081121, lng:105.818031},
    //     destination: {lat:21.036237,lng:105.790583},
    //     travelMode: 'DRIVING'
    // };
    // directionsService.route(request, function (response, status) {
    //     if (status == 'OK') {
    //         directionsDisplay.setDirections(response);
    //     }
    // });
    // directionsDisplay.setMap(map)
}

function handle(damchay) {

    console.log(damchay.id);
    var latDamChay = 0;
    var lngDamChay = 0;
    var addressDamChay;


    var geoCode = {
        lat: 21.036237,
        lng: 105.790583
    };
    var marker = new google.maps.Marker({
        map: map,
        position: geoCode
    });

    //init map
    var element = document.getElementById('map'); // chỉ ra element cần tạo
    var map = new google.maps.Map(element, {
        zoom: 12,
        center: geoCode,

    });

    // lấy lat lng của đám cháy

    $.ajax({
        type: 'GET',
        url: "http://localhost:8177/api/BaoChay",
        dataType: 'json',
        success: function (data) {
            data.forEach(element => {

                if (element.id == damchay.id) {

                    latDamChay = element.lat;
                    lngDamChay = element.lng;
                    addressDamChay = element.address;


                    // set marker damchay
                    var marker = new google.maps.Marker({
                        map: map,
                        position: {
                            lat: element.lat,
                            lng: element.lng
                        },
                        animation: google.maps.Animation.DROP,
                        icon: {
                            url: "../../Content/icon/fire.png",
                            scaledSize: {
                                width: 30,
                                height: 40
                            }
                        }
                    });
                    var contentInfoWindow = "<h6>" + element.address + element.county + element.city + "</h6>" +
                    " <button id='" + element.id + "' class ='btn btn-success my-2 my-sm-0' onclick='handle(this)' type='submit'>Xử lý</button>";

                    var infowindow = new google.maps.InfoWindow({
                        content: contentInfoWindow
                    });
                    marker.addListener('click', function () {
                        infowindow.open(map, marker);
                    });

                }

            });

        },
        error: function (xhr, status, err) {
            console.log(err + "");

        }
    });

    var listXeCuuHoa;

    //get listXeCuuHoa

    $.ajax({
        type: 'GET',
        url: "http://localhost:8177/api/xecuuhoa",
        dataType: 'json',
        success: function (data) {
            setTimeout(ShowFireStation(), 1000);
            listXeCuuHoa = data;

        },
        error: function (xhr, status, err) {
            console.log(err + "");

        }
    }); // end ajax show fire station




    // show fire station
    var ShowFireStation = function () {
        $.ajax({
            type: 'GET',
            url: "http://localhost:8177/api/tramcuuhoa",
            dataType: 'json',
            success: function (data) {

                data.forEach(element => {
                    var marker = new google.maps.Marker({
                        map: map,
                        position: {
                            lat: element.lat,
                            lng: element.lng
                        },
                        animation: google.maps.Animation.DROP,
                        icon: {
                            url: "../../Content/icon/firestation.png",
                            scaledSize: {
                                width: 30,
                                height: 40
                            }
                        }
                    });

                    var contentInfoWindow = "<h6>" + element.name + " " + element.address + "</h6>";

                    var infowindow = new google.maps.InfoWindow({
                        content: contentInfoWindow
                    });
                    marker.addListener('click', function () {
                        infowindow.open(map, marker);
                    });
                    // show data on table

                    var distance = TinhQuangDuong(latDamChay, lngDamChay, element.lat, element.lng);
                    //var size = RecommendXeCuuHoa(addressDamChay);
                    // var listXeCuuHoa= getXeCuuHoa(element.id, 'all');
                    var objCar = {};
                    var cars = [];
                    listXeCuuHoa.forEach(xecuuhoa => {
                        if (xecuuhoa.idTramCuuHoa == element.id) {
                            objCar = xecuuhoa;
                            cars.push(objCar);
                        }
                    });

                    FillTable(element.name, element.address, element.phone, distance, cars, addressDamChay);



                }) // end for each

            },
            error: function (xhr, status, err) {
                console.log(err + "");

            }
        }); // end ajax show fire station

    }

}

function ShowTruNuoc(trunuoc) {
    var idTruNuoc = trunuoc.getAttribute("data-id");
    var latDamChay = 0;
    var lngDamChay = 0;
    var addressDamChay;


    var geoCode = {
        lat: 21.036237,
        lng: 105.790583
    };
    var marker = new google.maps.Marker({
        map: map,
        position: geoCode
    });

    //init map
    var element = document.getElementById('map'); // chỉ ra element cần tạo
    var map = new google.maps.Map(element, {
        zoom: 12,
        center: geoCode,

    });

    // lấy lat lng của đám cháy

    $.ajax({
        type: 'GET',
        url: "http://localhost:8177/api/BaoChay",
        dataType: 'json',
        success: function (data) {
            data.forEach(element => {

                if (element.id == idTruNuoc) {

                    latDamChay = element.lat;
                    lngDamChay = element.lng;
                    addressDamChay = element.address;


                    // set marker damchay
                    var marker = new google.maps.Marker({
                        map: map,
                        position: {
                            lat: element.lat,
                            lng: element.lng
                        },
                        animation: google.maps.Animation.DROP,
                        icon: {
                            url: "../../Content/icon/fire.png",
                            scaledSize: {
                                width: 30,
                                height: 40
                            }
                        }
                    });
                    var contentInfoWindow = "<h6>" + element.address + element.county + element.city + "</h6>" +
                    " <button id='" + element.id + "' class ='btn btn-primary my-2 my-sm-0' onclick='ShowTruNuoc(this)' type='submit'>Tìm Trụ Nước</button>";

                    var infowindow = new google.maps.InfoWindow({
                        content: contentInfoWindow
                    });
                    marker.addListener('click', function () {
                        infowindow.open(map, marker);
                    });

                }

            });

        },
        error: function (xhr, status, err) {
            console.log(err + "");

        }
    });


    // show fire station

    $.ajax({
        type: 'GET',
        url: "http://localhost:8177/api/trunuoc",
        dataType: 'json',
        success: function (data) {

            data.forEach(element => {
                var marker = new google.maps.Marker({
                    map: map,
                    position: {
                        lat: element.lat,
                        lng: element.lng
                    },
                    animation: google.maps.Animation.DROP,
                    icon: {
                        url: "../../Content/icon/trunuoc.png",
                        scaledSize: {
                            width: 30,
                            height: 40
                        }
                    }
                });

                var contentInfoWindow = "<h6>" + element.city + " " + element.address + "</h6>";

                var infowindow = new google.maps.InfoWindow({
                    content: contentInfoWindow
                });
                marker.addListener('click', function () {
                    infowindow.open(map, marker);
                });
                // show data on table

                FillTableTruNuoc(latDamChay, lngDamChay, element.lat, element.lng, element.city, element.county, element.address);



            }) // end for each

        },
        error: function (xhr, status, err) {
            console.log(err + "");

        }
    }); // end ajax show fire station

}


function RecommendXeCuuHoa(addressDamChay) {
    var address = addressDamChay.toLowerCase();

    if (address.includes("nghách") ||
        address.includes("ngõ") ||
        address.includes("hẻm")) {
        return 's' // size s
    } else if (address.includes("chung cư") ||
        address.includes("sân vận động")) {

        return 'l' // size l
    } else {
        return 'all'
    }
}

function TinhQuangDuong(lat1, lng1, lat2, lng2) {

    return google.maps.geometry.spherical.computeDistanceBetween(new google.maps.LatLng(lat1, lng1), new google.maps.LatLng(lat2, lng2));

}

function FillTableTruNuoc(latDamChay, lngDamChay, lat, lng, city, county, address) {
    var distance = google.maps.geometry.spherical.computeDistanceBetween(new google.maps.LatLng(latDamChay, lngDamChay), new google.maps.LatLng(lat, lng));
    $('#myTable2').removeAttr("style");
    $('#datarow2').append("<tr><td>" + city + "</td><td>" + county + "</td> <td>" + address + " </td><td>" + distance / 1000 + " </td></tr>");
}

// call xecuuhoa
function getXeCuuHoa(idTramCuuHoa, size) {
    var list = [];
    $.ajax({
        type: 'GET',
        url: "http://localhost:8177/api/xecuuhoa",
        dataType: 'json',
        success: function (data) {

            if (size != 'all') {
                data.forEach(element => {
                    if (element.idTramCuuHoa == idTramCuuHoa &&
                        element.size == size) {
                        list.push(element);

                    }
                }) // end for each

            } else {
                data.forEach(element => {
                    if (element.idTramCuuHoa == idTramCuuHoa) {
                        list.push(element);

                    }
                }) // end for each

            }


            // call function

        },
        error: function (xhr, status, err) {
            console.log(err + "");

        }
    }); // end ajax show fire station


    return list;

}



function FillTable(name, address, phone, distance, cars, addressDamChay) {

    var str = "";
    var size = RecommendXeCuuHoa(addressDamChay);

    cars.forEach(element => {
        var info = "Size:  " + element.size + " | Capacity:  " + element.capacity + " | MaxHeight:  " + element.maxHeight;
        if (element.status == 'free' && element.size == size) {
            str += "<span data-toggle='modal' data-target='#modalFreelCar'> <a id=" + element.id + " data-toggle='tooltip'data-placement='top' title='" + info + "' class='badge badge-success' onclick=pickCar(this)>" + element.name + "</a></span>";
        } else if (element.status == 'busy') {
            str += "<span data-toggle='modal' data-target='#modalBusyCar'> <a id=" + element.id + " data-toggle='tooltip' data-placement='top' title='" + info + "' class='badge badge-danger' onclick=pickCar(this)>" + element.name + "</a></span>";
        } else if (element.status == 'free') {
            str += "<span data-toggle='modal' data-target='#modalFreelCar'> <a id=" + element.id + " data-toggle='tooltip'data-placement='top' title='" + info + "' class='badge badge-primary' onclick=pickCar(this)> " + element.name + "</a></span>";
        }

    });

    $('#myTable').removeAttr("style");

    $('#datarow').append("<tr><td>" + name + " " + address + "</td> <td>" + phone + " </td><td>" + distance / 1000 + " </td><td>" + str + " </td></tr>");
}

function pickCar(item) {
    console.log(item.id);
    $.ajax({
        type: "GET",
        url: "http://localhost:8177/api/xecuuhoa",
        dataType: "json",
        success: function (data) {
            data.forEach(element => {
                if (element.id == item.id) {
                    $('#pickFreeCarId').val(element.id);
                    $('#pickFreeCarName').val(element.name);
                    $('#pickFreeCarSize').val(element.size);
                    $('#pickFreeCarmaxHeight').val(element.maxHeight);
                    $('#pickFreeCarCapacity').val(element.capacity);

                    $('#pickBusyCarId').val(element.id);
                    $('#pickBusyCarName').val(element.name);
                    $('#pickBusyCarSize').val(element.size);
                    $('#pickBusyCarmaxHeight').val(element.maxHeight);
                    $('#pickBusyCarCapacity').val(element.capacity);
                }
            });

        }
    });


}

function CallFreeCar() {
    var id =  $('#pickFreeCarId').val();
    console.log(id);
    $.ajax({
        type: "PUT",
        url: 'http://localhost:8177/api/xecuuhoa/CallCar?id='+id+'&status=busy',
        dataType: "text",
        success: function (response) {
            console.log("success edit");
           
        }
    });
    var node = $("#"+id+"");

    node.attr("class", "badge badge-danger");
    node.parent().attr("data-target", "#modalBusyCar");

}

function CallBusyCar() {
    var id = $('#pickBusyCarId').val();
    console.log(id);
    $.ajax({
        type: "PUT",
        url: 'http://localhost:8177/api/xecuuhoa/CallCar?id=' + id + '&status=free',
        dataType: "text",
        success: function (response) {
            console.log("success edit");
           
        }
    });

    var node = $("#" + id + "");

    node.attr("class", "badge badge-primary");
    node.parent().attr("data-target", "#modalFreeCar");
}

function sortTable(n) {
    var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
    table = document.getElementById("myTable");
    switching = true;
    // Set the sorting direction to ascending:
    dir = "asc";
    /* Make a loop that will continue until
    no switching has been done: */
    while (switching) {
        // Start by saying: no switching is done:
        switching = false;
        rows = table.getElementsByTagName("TR");
        /* Loop through all table rows (except the
        first, which contains table headers): */
        for (i = 1; i < (rows.length - 1) ; i++) {
            // Start by saying there should be no switching:
            shouldSwitch = false;
            /* Get the two elements you want to compare,
            one from current row and one from the next: */
            x = rows[i].getElementsByTagName("TD")[n];
            y = rows[i + 1].getElementsByTagName("TD")[n];
            /* Check if the two rows should switch place,
            based on the direction, asc or desc: */
            if (dir == "asc") {

                if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                    // If so, mark as a switch and break the loop:
                    shouldSwitch = true;
                    break;
                }
            } else if (dir == "desc") {

                if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                    // If so, mark as a switch and break the loop:
                    shouldSwitch = true;
                    break;
                }
            }
        }
        if (shouldSwitch) {
            /* If a switch has been marked, make the switch
            and mark that a switch has been done: */
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = true;
            // Each time a switch is done, increase this count by 1:
            switchcount++;
        } else {
            /* If no switching has been done AND the direction is "asc",
            set the direction to "desc" and run the while loop again. */
            if (switchcount == 0 && dir == "asc") {
                dir = "desc";
                switching = true;
            }
        }
    }
}
function sortTable2(n) {
    var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
    table = document.getElementById("myTable2");
    switching = true;
    // Set the sorting direction to ascending:
    dir = "asc";
    /* Make a loop that will continue until
    no switching has been done: */
    while (switching) {
        // Start by saying: no switching is done:
        switching = false;
        rows = table.getElementsByTagName("TR");
        /* Loop through all table rows (except the
        first, which contains table headers): */
        for (i = 1; i < (rows.length - 1) ; i++) {
            // Start by saying there should be no switching:
            shouldSwitch = false;
            /* Get the two elements you want to compare,
            one from current row and one from the next: */
            x = rows[i].getElementsByTagName("TD")[n];
            y = rows[i + 1].getElementsByTagName("TD")[n];
            /* Check if the two rows should switch place,
            based on the direction, asc or desc: */
            if (dir == "asc") {

                if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                    // If so, mark as a switch and break the loop:
                    shouldSwitch = true;
                    break;
                }
            } else if (dir == "desc") {

                if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                    // If so, mark as a switch and break the loop:
                    shouldSwitch = true;
                    break;
                }
            }
        }
        if (shouldSwitch) {
            /* If a switch has been marked, make the switch
            and mark that a switch has been done: */
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = true;
            // Each time a switch is done, increase this count by 1:
            switchcount++;
        } else {
            /* If no switching has been done AND the direction is "asc",
            set the direction to "desc" and run the while loop again. */
            if (switchcount == 0 && dir == "asc") {
                dir = "desc";
                switching = true;
            }
        }
    }
}

function sortNumberTable() {
    var table, rows, switching, i, x, y, shouldSwitch;
    table = document.getElementById("myTable");
    switching = true;
    /*Make a loop that will continue until
    no switching has been done:*/
    while (switching) {
        //start by saying: no switching is done:
        switching = false;
        rows = table.getElementsByTagName("TR");
        /*Loop through all table rows (except the
        first, which contains table headers):*/
        for (i = 1; i < (rows.length - 1) ; i++) {
            //start by saying there should be no switching:
            shouldSwitch = false;
            /*Get the two elements you want to compare,
            one from current row and one from the next:*/
            x = rows[i].getElementsByTagName("TD")[2];
            y = rows[i + 1].getElementsByTagName("TD")[2];
            //check if the two rows should switch place:
            if (parseFloat(x.innerHTML) > parseFloat(y.innerHTML)) {
                //if so, mark as a switch and break the loop:
                shouldSwitch = true;
                break;
            }
        }
        if (shouldSwitch) {
            /*If a switch has been marked, make the switch
            and mark that a switch has been done:*/
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = true;
        }
    }
}
function sortNumberTable2() {
    var table, rows, switching, i, x, y, shouldSwitch;
    table = document.getElementById("myTable2");
    switching = true;
    /*Make a loop that will continue until
    no switching has been done:*/
    while (switching) {
        //start by saying: no switching is done:
        switching = false;
        rows = table.getElementsByTagName("TR");
        /*Loop through all table rows (except the
        first, which contains table headers):*/
        for (i = 1; i < (rows.length - 1) ; i++) {
            //start by saying there should be no switching:
            shouldSwitch = false;
            /*Get the two elements you want to compare,
            one from current row and one from the next:*/
            x = rows[i].getElementsByTagName("TD")[2];
            y = rows[i + 1].getElementsByTagName("TD")[2];
            //check if the two rows should switch place:
            if (parseFloat(x.innerHTML) > parseFloat(y.innerHTML)) {
                //if so, mark as a switch and break the loop:
                shouldSwitch = true;
                break;
            }
        }
        if (shouldSwitch) {
            /*If a switch has been marked, make the switch
            and mark that a switch has been done:*/
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = true;
        }
    }
}


function DeleteBaoChay(node) {

    var id = node.getAttribute("data-id");
    $.ajax({
        type: "DELETE",
        url: "http://localhost:8177/api/baochay/" + id,
        dataType: "text",
        success: function (response) {
            console.log("xóa thành công");
            initMap();
        }
    });
}
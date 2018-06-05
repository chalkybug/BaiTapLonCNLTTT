
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

        console.log(marker.getPosition().lat());
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
                        url: "./icon/fire.png",
                        scaledSize: {
                            width: 30,
                            height: 40
                        }
                    }
                });
                var contentInfoWindow = "<h6>" + element.address + element.county + element.city + "</h6>" + " <button id='" + element.id + "' class ='btn btn-success my-2 my-sm-0' onclick='handle(this)' type='submit'>Xử lý</button>";

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




    // test calucation distance
    // $('#distance').click(function () {
    //     var latitude1 = 21.0345190208582;
    //     var longitude1 = 105.78254699707;
    //     var latitude2 = 21.0466353629359;
    //     var longitude2 = 105.804948806763;

    //     var distance = google.maps.geometry.spherical.computeDistanceBetween(new google.maps.LatLng(latitude1, longitude1), new google.maps.LatLng(latitude2, longitude2));
    //     alert(distance);
    // });




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

                    // set marker damchay
                    var marker = new google.maps.Marker({
                        map: map,
                        position: {
                            lat: element.lat,
                            lng: element.lng
                        },
                        animation: google.maps.Animation.DROP,
                        icon: {
                            url: "./icon/fire.png",
                            scaledSize: {
                                width: 30,
                                height: 40
                            }
                        }
                    });
                    var contentInfoWindow = "<h6>" + element.address + element.county + element.city + "</h6>" + " <button id='" + element.id + "' class ='btn btn-success my-2 my-sm-0' onclick='handle(this)' type='submit'>Xử lý</button>";

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
                        url: "./icon/firestation.png",
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

                TinhQuangDuong(latDamChay, lngDamChay, element.lat, element.lng, element.name, element.address, element.phone);

            })
            // call function

        },
        error: function (xhr, status, err) {
            console.log(err + "");

        }
    }); // end ajax show fire station

}


function TinhQuangDuong(lat1, lng1, lat2, lng2, name, address, phone) {
    //show table
    $('#myTable').removeAttr("style");
    var distance = google.maps.geometry.spherical.computeDistanceBetween(new google.maps.LatLng(lat1, lng1), new google.maps.LatLng(lat2, lng2));
    $('#datarow').append("<tr><td>" + name + " " + address + "</td> <td>" + phone + " </td><td>" + distance / 1000 + " </td></tr>");
    
}


function sortTable(n) {
  var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
  table = document.getElementById("myTable");
  switching = true;
  //Set the sorting direction to ascending:
  dir = "asc"; 
  /*Make a loop that will continue until
  no switching has been done:*/
  while (switching) {
    //start by saying: no switching is done:
    switching = false;
    rows = table.getElementsByTagName("TR");
    /*Loop through all table rows (except the
    first, which contains table headers):*/
    for (i = 1; i < (rows.length - 1); i++) {
      //start by saying there should be no switching:
      shouldSwitch = false;
      /*Get the two elements you want to compare,
      one from current row and one from the next:*/
      x = rows[i].getElementsByTagName("TD")[n];
      y = rows[i + 1].getElementsByTagName("TD")[n];
      /*check if the two rows should switch place,
      based on the direction, asc or desc:*/
      if (dir == "asc") {
        if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
          //if so, mark as a switch and break the loop:
          shouldSwitch= true;
          break;
        }
      } else if (dir == "desc") {
        if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
          //if so, mark as a switch and break the loop:
          shouldSwitch = true;
          break;
        }
      }
    }
    if (shouldSwitch) {
      /*If a switch has been marked, make the switch
      and mark that a switch has been done:*/
      rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
      switching = true;
      //Each time a switch is done, increase this count by 1:
      switchcount ++;      
    } else {
      /*If no switching has been done AND the direction is "asc",
      set the direction to "desc" and run the while loop again.*/
      if (switchcount == 0 && dir == "asc") {
        dir = "desc";
        switching = true;
      }
    }
  }
}


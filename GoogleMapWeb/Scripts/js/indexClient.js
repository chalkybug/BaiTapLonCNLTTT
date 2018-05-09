function initMap() {
    var geoCode = {
        lat: 21.036237,
        lng: 105.790583
    };

    var latFinal = 0;
    var lngtFinal = 0;

    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 12,
        center: geoCode,
    });
    // init marker
    var marker = new google.maps.Marker({
        position: geocoder,
        map: map
    });
    marker.setVisible(false)
    /// end init marker
    var geocoder = new google.maps.Geocoder;
    var infowindow = new google.maps.InfoWindow;
    /// thêm vào sự kiện dbclick

    google.maps.event.addListener(map, 'dblclick', function (event) {
        geocodeLatLng(geocoder, map, infowindow, marker);
    });


    // function tìm địa chỉ theo lat lng
    function geocodeLatLng(geocoder, map, infowindow, marker) {
        // var input = document.getElementById('latlng').value;
        //  var latlngStr = input.split(',', 2);
        var latlng = {
            lat: latFinal,
            lng: lngFinal
        };
        geocoder.geocode({
            'location': latlng
        }, function (results, status) {
            if (status === 'OK') {
                if (results[0]) {
                    map.setZoom(15);
                    // var marker = new google.maps.Marker({
                    //     position: latlng,
                    //     map: map
                    // });
                    marker.setPosition(location);
                    infowindow.setContent(results[0].formatted_address);
                    console.log(results[0].formatted_address);
                    // fill text box
                    var fullAddress = results[0].formatted_address;
                    var arrAddress = fullAddress.split(',');
                    //
                    let res = "";
                    console.log(res);

                    for (let index = 0; index < arrAddress.length - 3; index++) {
                        const element = arrAddress[index];
                        res += element + ', '
                    }
                    //
                    $('#txtAddress').val(res);
                    $('#txtCounty').val(arrAddress[arrAddress.length - 3]);
                    $('#txtCity').val(arrAddress[arrAddress.length - 2]);

                    infowindow.open(map, marker);
                } else {
                    window.alert('No results found');
                }
            } else {
                window.alert('Geocoder failed due to: ' + status);
            }
        });
    }



    // add event click

    google.maps.event.addListener(map, 'click', function (event) {
        placeMarker(event.latLng);
        geocodeLatLng(geocoder, map, infowindow, marker);
    });

    function placeMarker(location) {
        marker.setPosition(location);
        marker.setVisible(true);
        latFinal = marker.getPosition().lat();
        lngFinal = marker.getPosition().lng();
        //  $('#latlng').val(lat + ',' + lng);

    }


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
            map.setZoom(25); // Why 17? Because it looks good.
        }
        marker.setPosition(place.geometry.location);
        marker.setVisible(true);

        console.log(marker.getPosition().lat());
        console.log(marker.getPosition().lng());

    })

    // end susgest textbox 

    // submit




    $("#submit").click(function () {

        $.ajax({
            type: 'POST',
            url: "http://localhost:8177/api/baochay",
            dataType: 'text',
            data: {
                //city, county, address, lat, lng
                city: $('#txtCity').val(),
                county: $('#txtCounty').val(),
                address: $('#txtAddress').val(),
                lat: latFinal,
                lng: lngFinal,

            },
            success: function (data) {
                alert("Gửi báo cháy thành công")

            },
            error: function (xhr, status, err) {
                console.log(err + "");

                alert("Gửi báo cháy lỗi")
            }
        });

    });

    //end submit

}

//Google Map Api 

function initMap() {
        var uluru = {lat: 41.897400, lng: -87.625376};
        var map = new google.maps.Map(document.getElementById('map'), {
          zoom: 14,
          center: uluru
        });
        var marker = new google.maps.Marker({
          position: uluru,
          map: map
        });
      }

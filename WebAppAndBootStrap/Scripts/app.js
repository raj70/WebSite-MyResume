$(document).ready(function () {

    const navitems = $(".nav-link");

    for (let index = 0; index < navitems.length; index++) {

        navitems[index].addEventListener("click", function (event) {

            console.log($($(".nav-link.active")[0]));

            $($(".nav-item.active")[0]).removeClass("active");
            
        });
    }

});
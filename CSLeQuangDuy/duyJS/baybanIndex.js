var seaFood = seaFood || {};
seaFood.show = function (array2) {
    $('#seaFoodShow').empty();
    for (i = 0; i <= array2.length - 1; i++) {
        $('#seaFoodShow').append(
            ' <div class=" col-md-4 col-lg-3 mb-4 mb-lg-3 portfolio-item">' +
            '<a class="portfolio-link" data-toggle="modal" href="javascript:;" onclick="seaFood.home(' + array2[i].id + ')">' +
            '<div class="portfolio-hover">' +
            '<div class="portfolio-hover-content">' +
            '<i class="fas fa-plus fa-3x"></i>' +
            ' </div>' +
            '</div>' +
            '<img class="img-fluid rounded-top " src=' + array2[i].foodImage + ' alt="">' +
            ' </a>' +
            '<div class="portfolio-caption">' +
            '<h4>' + array2[i].namefood + '</h4>' +
            '<p class="text-muted">' + array2[i].price + " VNĐ/kg " + '</p>' +
            '</div>' +
            '</div>'
        );

    }

};
seaFood.breed1 = function () {
    seaFood.breed2();
}

seaFood.breed2 = function () {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/seaFood",
        method: "GET",
        dataType: "json",
        success: function (data) {
            if ($('#breed').val() === "full") {
                array1 = data;
            }
            else {
                var array1 = [];
                $.each(data, function (i, v) {
                    if (v.breed === $('#breed').val()) {
                        var array = data[i]
                        array1.push(array)
                    }
                })

            }
            if ($('#breed2').val() === "full") {
                array2 = array1
            }
            else {
                var array2 = [];
                if ($('#breed2').val() === "499") {
                    for (i = 0; i <= array1.length - 1; i++) {
                        if (array1[i].price < 500000) {
                            var array = array1[i];
                            array2.push(array)
                        }
                    }
                }
                if ($('#breed2').val() === "999") {
                    for (i = 0; i <= array1.length - 1; i++) {
                        if (array1[i].price >= 500000 && array1[i].price < 1000000) {
                            var array = array1[i];
                            array2.push(array)
                        }
                    }

                }
                if ($('#breed2').val() === "1999") {
                    for (i = 0; i <= array1.length - 1; i++) {
                        if (array1[i].price >= 1000000 && array1[i].price < 2000000) {
                            var array = array1[i];
                            array2.push(array)
                        }
                    }

                }
                if ($('#breed2').val() === "2000") {
                    for (i = 0; i <= array1.length - 1; i++) {
                        if (array1[i].price >= 2000000) {
                            var array = array1[i];
                            array2.push(array)
                        }
                    }

                }

            }
            seaFood.show(array2);

        }
    })
}
seaFood.home = function (id) {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/seaFood/" + id,
        method: "GET",
        dataType: 'json',
        success: function (data) {
            $('#seaFoodName').text(data.namefood);
            $('#seaFoodPrice').text(data.price +" "+ "VNĐ/kg");
            $('#seaFoodImage').prop('src', data.foodImage);
            $('#Description').text(data.description);
            $('#seaFoodPlusModal').modal('show');

        }
    });
}
var menu = menu || {};
menu.show = function () {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/menu",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#showMenu').empty();
            $.each(data, function (i, v) {
                $('#showMenu').append(
                    '<div class="col-sm-4">' +
                    '<div class="team-member ">' +
                    '<img class="mx-auto rounded-circle" src=' + v.foodImage + ' alt="">' +
                    '<h4>' + v.namefood + '</h4>' +
                    '<p class="text-muted">' + v.price + "đ/Phần" + '</p>' +
                    '</div>' +
                    ' </div>'
                );
            })

        }
    });
};
menu.seachblock = function () {
    $('#chuoi').removeClass('d-none');
}
//classify = phân loại
menu.classify = function () {
    let str = $('#chuoi').val();
    let str3 = str.toLowerCase();
    let str1 = str3.split(" ");
    times = 0; // số lần xuất hiện của số number
    for (i = 0; i < str1.length; i++) {
        if (str1[i] == "") {
            times += 1;
        }
    }
    timesRun = 0;
    while (timesRun <= times) {
        for (i = 0; i < str1.length; i++) {
            if (str1[i] === "") {
                for (i; i < str1.length - 1; i++) {
                    str1[i] = str1[i + 1];
                }
                str1.pop();
            }
        }
        timesRun += 1;
    }



    $.ajax({
        url: " https://cs-leduy.herokuapp.com/menu",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#showMenu').empty();
            $.each(data, function (i, v) {
                let str4 = v.namefood.toLowerCase()
                let str2 = str4.split(" ");
                let b = 0;
                for (i = 0; i <= str1.length - 1; i++) {
                    for (j = 0; j <= str2.length - 1; j++) {
                        if (str1[i] == str2[j]) {
                            b += 1;
                        }
                    }
                }
                if (b >= str1.length) {
                    $('#showMenu').append(
                        '<div class="col-sm-4">' +
                        '<div class="team-member ">' +
                        '<img class="mx-auto rounded-circle" src=' + v.foodImage + ' alt="">' +
                        '<h4>' + v.namefood + '</h4>' +
                        '<p class="text-muted">' + v.price + "đ/Phần" + '</p>' +
                        '</div>' +
                        ' </div>'
                    );
                }
            })

        }
    });
}
menu.init = function () {
    menu.show();
}
seaFood.init = function () {
    seaFood.breed1();
}

$(document).ready(function () {
    seaFood.init();
    menu.init();
});
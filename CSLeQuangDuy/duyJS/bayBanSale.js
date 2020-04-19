var baybanSale = baybanSale || {};
baybanSale.showTable = function () {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/seaFood",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#sealFoodTable').empty();
            id = 1;
            $.each(data, function (i, v) {
                $('#sealFoodTable').append(
                    "<tr class='unit-1 text-center' >" +
                    "<td>" + (id++) + "</td>" +
                    "<td>" + v.namefood + "</td>" +
                    "<td><img src=" + v.foodImage + " width='60px' height='60px' /></td>" +
                    "<td>" + v.price + "</td>" +
                    "<td>" + v.amount + "</td>" +
                    "<td>" +
                    "<a href='javascript:;' onclick='baybanSale.oder(" + v.id + ");'><i class='icon-shopping-cart'></i></a>" +
                    "</td>" +
                    "</tr>",
                );
            })
        }
    });

};
baybanSale.oder = function (id) {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/seaFood/" + id,
        method: "GET",
        dataType: 'json',
        success: function (data) {
            $('#oderNameFood').text(data.namefood);
            $('#oderPrice').text(data.price);
            $('#oderNameFood').val(data.namefood);
            $('#oderPrice').val(data.price);
            $('#orderTable').modal('show');
        }
    });
}
baybanSale.check = function () {
    if ($('#formBook').valid()) {
        var addCustomer = {};
        addCustomer.oderCustomerName = $('#oderCustomerName').val();
        addCustomer.oderPhoneNumber = $('#oderPhoneNumber').val();
        addCustomer.oderDate = $('#oderDate').val();
        addCustomer.oderNameFood = $('#oderNameFood').val();
        addCustomer.oderPrice = $('#oderPrice').val();
        addCustomer.oderAmount = $('#oderAmount').val();
        addCustomer.oderNote = $('#oderNote').val();
        $.ajax({
            url: "https://cs-leduy.herokuapp.com/customer",
            method: "POST",
            dataType: "json",
            contentType: "application/json",
            data: JSON.stringify(addCustomer),
            success: function (data) {
                $('#orderTable').modal('hide');
                baybanSale.resetForm();
                bootbox.alert("Please wait for confirmation of the restaurant. (Quý khách vui lòng chờ xác nhận của Nhà Hàng.)");
            }
        })
    }

}
baybanSale.resetForm = function () {
    $('#oderCustomerName').val(' ');
    $('#oderPhoneNumber').val(' ');
    $('#oderDate').val(' ');
    $('#oderAmount').val('0');
    $('#oderNote').val('');
    $('#oderNameFood').val('');
    $('#oderPrice').val('');
}



var menuSale = menuSale || {};
menuSale.showMenu = function () {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/menu",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#menuTable').empty();
            id = 1;
            $.each(data, function (i, v) {
                $('#menuTable').append(
                    "<tr class='unit-1 text-center' >" +
                    "<td>" + (id++) + "</td>" +
                    "<td>" + v.namefood + "</td>" +
                    "<td><img src=" + v.foodImage + " width='60px' height='60px' /></td>" +
                    "<td>" + v.price + "</td>" +
                    "<td>" +
                    "<a href='javascript:;' onclick='cart.oderMenu(" + v.id + ");'><i class='icon-shopping-cart'></i></a> " +
                    "</td>" +
                    "</tr>",
                );
            })
        }
    });

};
var cart = cart || {};
cart.oderMenu = function (id) {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/menu/" + id,
        method: "GET",
        dataType: 'json',
        success: function (data) {
            $('#oderMenuNameFood').text(data.namefood);
            $('#oderMenuPrice').text(data.price);
            $('#oderMenuNameFood').val(data.namefood);
            $('#oderMenuPrice').val(data.price);
            $('#orderMenuTable').modal('show');
            image = data.foodImage;
        }
    });

}
cart.resetInformation = function () {
    $('#oderMenuAmount').val('0');
    $('#oderMenuNote').val(' ');
};
cart.confirmMenu = function () {
    if ($('#formBook2').valid()) {
        var food = {};
        food.nameFood = $('#oderMenuNameFood').val();
        food.priceFood = $('#oderMenuPrice').val();
        food.amoutFood = $('#oderMenuAmount').val();
        food.note = $('#oderMenuNote').val();
        food.image = image;
        $.ajax({
            url: " https://cs-leduy.herokuapp.com/information/",
            method: "POST",
            dataType: "json",
            contentType: "application/json",
            data: JSON.stringify(food),
            success: function (data) {
                $('#orderMenuTable').modal('hide');
                cart.resetInformation();
                cart.showTable();
                cart.cartNumber();
                bootbox.alert("Please enter your cart to fill out the information. <br> (Quý khách vui lòng vào giỏ hàng để điền thông tin.)");
            }

        })
    }
}
//In ố lượng ở giỏ hàng
cart.cartNumber = function () {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/information/",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#cartNumber').empty();
            let number = 0;
            $.each(data, function (i, v) {
                number += v.amoutFood * 1;

            })
            $('#cartNumber').append(
                number
            );

        }
    });
};

cart.showTable = function () {
    $.ajax({
        url: " https://cs-leduy.herokuapp.com/information",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#cartTable').empty();
            id = 1;
            tongbill = 0;
            $.each(data, function (i, v) {
                tongbill += v.amoutFood * v.priceFood;
                $('#cartTable').append(
                    "<tr class='unit-1 text-center' >" +
                    "<td>" + (id++) + "</td>" +
                    "<td>" + v.nameFood + "</td>" +
                    "<td>" + v.note + "</td>" +
                    "<td>" + v.priceFood + "đ" + "</td>" +
                    "<td>" + v.amoutFood + "</td>" +
                    "<td>" + v.amoutFood * v.priceFood + "đ" + "</td>" +
                    "<td>" +
                    "<a href='javascript:;' onclick='cart.delete(" + v.id + ");'><i class='icon-trash-o'></i></a>" +


                    "</td>" +
                    "</tr>",
                );
            })
            $('#cartTable').append(
                "<tr class='unit-1 text-center' >" +
                "<td>" + (id++) + "</td>" +
                "<td><b> " + "Tổng" + "</b></td>" +
                "<td>" + "</td>" +
                "<td>" + "</td>" +
                "<td>" + "</td>" +
                "<td><b>" + tongbill + "</b></td>" +
                "<td>" +
                "</td>" +
                "</tr>",
            );
        }
    });

};
cart.delete = function (id) {
    bootbox.confirm({
        title: "Deleted the folder?",
        message: "Do you want to remove this product?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> No'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Yes'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: "https://cs-leduy.herokuapp.com/information/" + id,
                    method: "DELETE",
                    dataType: 'json',
                    success: function (data) {
                        cart.showTable();
                        cart.cartNumber();
                        bootbox.alert(" You have deleted the food. <br> Bạn đã xóa món");

                    }
                })

            }
        }
    });
}
cart.Confirm = function () {
    if ($('#formCustumer').valid()) {
        var khachHang = {};
        khachHang.information = {};
        khachHang.food = {};
        khachHang.information.cartname = $('#cartName').val();
        khachHang.information.cartPhone = $('#cartPhone').val();
        khachHang.information.cartDate = $('#cartDate').val();
        khachHang.information.name = "people"
        $.ajax({
            url: "https://cs-leduy.herokuapp.com/bill/",
            method: "POST",
            dataType: "json",
            contentType: "application/json",
            data: JSON.stringify(khachHang.information),
        })
        khachHang.food = {};
        $.ajax({
            url: "https://cs-leduy.herokuapp.com/information",
            method: "GET",
            dataType: 'json',
            success: function (data) {
                $.each(data, function (i, v) {
                    khachHang.food.nameFood = v.nameFood;
                    khachHang.food.priceFood = v.priceFood;
                    khachHang.food.amoutFood = v.amoutFood;
                    khachHang.food.note = v.note;
                    khachHang.food.image = v.image;
                    khachHang.food.name = "food";
                    $.ajax({
                        url: "https://cs-leduy.herokuapp.com/bill/",
                        method: "POST",
                        dataType: "json",
                        contentType: "application/json",
                        data: JSON.stringify(khachHang.food),
                    })
                });
                $('#informationTable').modal('hide');
                cart.resetForm();
                $('#cartTable').empty();
                $('#cartNumber').empty();
                bootbox.alert("Data has been added. (Dữ liệu đã được thêm vào)");
            }
        });
    }
}
cart.resetForm = function () {
    $('#cartName').val(' ')
    $('#cartPhone').val(' ')
    $('#cartDate').val(' ')
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/information",
        method: "GET",
        dataType: "json",
        success: function (data) {
            let a = data[data.length - 1].id;
            for (id = 1; id <= a; id++) {
                $.ajax({
                    url: "https://cs-leduy.herokuapp.com/information/" + id,
                    method: "DELETE",
                    dataType: 'json'
                })
            }
        }
    })
}

cart.check = function () {
    $('#informationTable').modal('show');
}

cart.init = function () {
    cart.showTable();
    cart.cartNumber();
}
baybanSale.init = function () {
    baybanSale.showTable();
}
menuSale.init = function () {
    menuSale.showMenu();
}
$(document).ready(function () {
    baybanSale.init();
    menuSale.init();
    cart.init();

});
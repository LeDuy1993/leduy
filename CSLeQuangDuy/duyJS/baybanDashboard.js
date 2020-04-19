var baybanDashboard = baybanDashboard || {};
baybanDashboard.showTable = function () {
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
                    "<td>" + v.price + " VNĐ/kg " + "</td>" +
                    "<td>" + v.amount + "</td>" +
                    "<td>" +
                    "<a href='javascript:;' onclick='baybanDashboard.edit(" + v.id + ");'><i class='icon-gear'></i></a> " +
                    " &nbsp&nbsp&nbsp" +
                    "<a href='javascript:;' onclick='baybanDashboard.delete(" + v.id + ");'><i class='icon-trash-o'></i></a>" +
                    "</td>" +
                    "</tr>",
                );
            })
        }
    });

};

baybanDashboard.delete = function (id) {
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
                    url: "https://cs-leduy.herokuapp.com/seaFood/" + id,
                    method: "DELETE",
                    dataType: 'json',
                    success: function (data) {
                        baybanDashboard.showTable();
                        bootbox.alert(" You have deleted the folder. (Bạn đã xóa thư mục)");
                    }
                })
            }
        }
    });
}

baybanDashboard.save = function () {
    if ($('#formAddSealFood').valid()) { 
        if ($('#sealFoodId').val() == 0) { //tạo mới
            var addSealFood = {};
            addSealFood.namefood = $('#sealFoodName').val();
            addSealFood.breed = $('#sealFoodBreed').val();
            addSealFood.foodImage = $('#sealFoodImage').val();
            addSealFood.amount = $('#sealFoodAmount').val();
            addSealFood.price = $('#sealFoodPrice').val();
            addSealFood.description = $('#Description').val();
            $.ajax({
                url: "https://cs-leduy.herokuapp.com/seaFood",
                method: "POST",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(addSealFood),
                success: function (data) {
                    $('#addSealFood').modal('hide');
                    baybanDashboard.showTable();
                    bootbox.alert("Data has been added. (Dữ liệu đã được thêm vào)");
                }
            })
        }
        else {
            var updateSealFood = {};
            updateSealFood.namefood = $('#sealFoodName').val();
            updateSealFood.breed = $('#sealFoodBreed').val();
            updateSealFood.foodImage = $('#sealFoodImage').val();
            updateSealFood.amount = $('#sealFoodAmount').val();
            updateSealFood.price = $('#sealFoodPrice').val();
            updateSealFood.description = $('#Description').val();
            updateSealFood.id = $('#sealFoodId').val();
            $.ajax({
                url: "https://cs-leduy.herokuapp.com/seaFood/" + updateSealFood.id,
                method: "PUT",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(updateSealFood),
                success: function (data) {
                    $('#addSealFood').modal('hide');
                    baybanDashboard.showTable();
                    bootbox.alert("Data has been updated. (Dữ liệu đã được cập nhật)");

                }
            })
        }
    };
}
baybanDashboard.edit = function (id) {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/seaFood/" + id,
        method: "GET",
        dataType: 'json',
        success: function (data) {
            $('#sealFoodName').val(data.namefood)
            $('#sealFoodBreed').val(data.breed);
            $('#sealFoodImage').val(data.foodImage);
            $('#sealFoodAmount').val(data.amount);
            $('#sealFoodPrice').val(data.price);
            $('#Description').val(data.description)
            $('#sealFoodId').val(data.id);

            $('#addSealFood').find('.modal-title').text('Update Product');
            $('#btnProduct').text("Update")
            $('#addSealFood').modal('show');
        }
    });
}

baybanDashboard.resetForm = function () {
    $('#sealFoodName').val('');
    $('#sealFoodBreed').val('');
    $('#sealFoodImage').val('');
    $('#sealFoodAmount').val('');
    $('#sealFoodPrice').val('');
    $('#Description').val('')
    $('#sealFoodId').val(0);
    $('#addSealFood').find('.modal-title').text('Create New Seal Food');
    $('#btnProduct').text("Create");

}
baybanDashboard.openModal = function () {
    baybanDashboard.resetForm();
    $('#addSealFood').modal('show');
};



// Menu
var menuDashboard = menuDashboard || {};
menuDashboard.showMenu = function () {
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
                    "<td>" + v.price + " VNĐ " + "</td>" +
                    "<td>" +
                    "<a href='javascript:;' onclick='menuDashboard.edit(" + v.id + ");'><i class='icon-gear'></i></a> " +
                    " &nbsp&nbsp&nbsp" +
                    "<a href='javascript:;' onclick='menuDashboard.delete(" + v.id + ");'><i class='icon-trash-o'></i></a>" +
                    "</td>" +
                    "</tr>",
                );
            })
        }
    });

};
menuDashboard.resetMenu = function () {
    $('#menuName').val('');
    $('#menuImage').val('');
    $('#menuPrice').val('');
    $('#menuId').val(0);
    $('#addMenu').find('.modal-title').text('Create New Menu');
    $('#menuProduct').text("Create");
}
menuDashboard.delete = function (id) {
    bootbox.confirm({
        title: "Deleted the Menu?",
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
                    url: "https://cs-leduy.herokuapp.com/menu/" + id,
                    method: "DELETE",
                    dataType: 'json',
                    success: function (data) {
                        menuDashboard.showMenu();
                        bootbox.alert(" You have deleted the food. (Bạn đã xóa thức ăn.)");
                    }
                })
            }
        }
    });
}

menuDashboard.edit = function (id) {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/menu/" + id,
        method: "GET",
        dataType: 'json',
        success: function (dataMenu) {

            $('#menuName').val(dataMenu.namefood);
            $('#menuImage').val(dataMenu.foodImage);
            $('#menuPrice').val(dataMenu.price);
            $('#menuId').val(dataMenu.id);

            $('#addMenu').find('.modal-title').text('Update Menu');
            $('#menuProduct').text("Update")
            $('#addMenu').modal('show');
        }
    });
}
menuDashboard.save = function () {
    if ($('#formAddMenu').valid()) {
        if ($('#menuId').val() == 0) { //tạo mới
            var addMenu = {};
            addMenu.namefood = $('#menuName').val();
            addMenu.foodImage = $('#menuImage').val();
            addMenu.price = $('#menuPrice').val();
            $.ajax({
                url: "https://cs-leduy.herokuapp.com/menu",
                method: "POST",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(addMenu),
                success: function (data) {
                    $('#addMenu').modal('hide');
                    menuDashboard.showMenu();
                    bootbox.alert("Data has been added. (Dữ liệu đã được thêm vào)");
                }
            })
        }
        else {
            var updateMenu = {};
            updateMenu.namefood = $('#menuName').val();
            updateMenu.foodImage = $('#menuImage').val();
            updateMenu.price = $('#menuPrice').val();
            updateMenu.id = $('#menuId').val();
            $.ajax({
                url: "https://cs-leduy.herokuapp.com/menu/" + updateMenu.id,
                method: "PUT",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(updateMenu),
                success: function (data) {
                    $('#addMenu').modal('hide');
                    menuDashboard.showMenu();
                    bootbox.alert("Menu has been updated. (Thức ăn đã được cập nhật)");

                }
            })
        }
    };
}
// Quản Lý Khách Hàng
baybanDashboard.showCustomerTable = function () {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/customer",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#customerTable').empty();
            id = 1;
            $.each(data, function (i, v) {
                $('#customerTable').append(
                    "<tr class='unit-1 text-center' >" +
                    "<td>" + (id++) + "</td>" +
                    "<td>" + v.oderCustomerName + "</td>" +
                    "<td>" + v.oderPhoneNumber + "</td>" +
                    "<td>" + v.oderDate + "</td>" +
                    "<td>" + v.oderNameFood + "</td>" +
                    "<td>" + v.oderPrice + "</td>" +
                    "<td>" + v.oderAmount + "</td>" +
                    "<td>" + v.oderNote + "</td>" +
                    "<td>" +

                    "<a href='javascript:;' onclick='baybanDashboard.deleteCustomer(" + v.id + ");'><i class='icon-trash-o'></i></a>" +
                    "</td>" +
                    "</tr>",
                );
            })
        }
    });

};
// Cart
baybanDashboard.deleteCustomer = function (id) {
    bootbox.confirm({
        title: "Deleted the Menu?",
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
                baybanDashboard.getDataCustomer(id);
                $.ajax({
                    url: "https://cs-leduy.herokuapp.com/customer/" + id,
                    method: "DELETE",
                    dataType: 'json',
                    success: function (data) {
                        baybanDashboard.revenueTable();
                        baybanDashboard.showCustomerTable();
                        bootbox.alert(" You have deleted the food. (Bạn đã xóa thức ăn.)");
                    }
                })

            }
        }
    });
}
baybanDashboard.showCartTable = function () {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/bill",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#cartTable').empty();
            $('#cartcustomerTable').empty();
            id = 1;
            $.each(data, function (i, v) {
                if (v.name == "people") {
                    $('#cartcustomerTable').append(
                        "<tr class='unit-1 text-center' >" +
                        "<td>" + (id++) + "</td>" +
                        "<td>" + v.cartname + "</td>" +
                        "<td>" + v.cartPhone + "</td>" +
                        "<td>" + v.cartDate + "</td>" +
                        "<td>" +
                        "<a href='javascript:;' onclick='baybanDashboard.deleteCart(" + v.id + ");'><i class='icon-trash-o'></i></a>" +
                        "</td>" +
                        "</tr>",
                    );
                }
                if (v.name == "food") {
                    $('#cartTable').append(
                        "<tr class='unit-1 text-center' >" +
                        "<td>" + v.nameFood + "</td>" +
                        "<td>" + v.priceFood + "</td>" +
                        "<td>" + v.amoutFood + "</td>" +
                        "<td>" + v.amoutFood * v.priceFood + "</td>" +
                        "<td>" + v.note + "</td>" +
                        "</tr>",
                    );
                }
            })
        }
    });
};
baybanDashboard.deleteCart = function () {
    bootbox.confirm({
        title: "Bàn đã hoàn thành !",
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
                baybanDashboard.getDataBill();
                $.ajax({
                    url: "https://cs-leduy.herokuapp.com/bill",
                    method: "GET",
                    dataType: "json",
                    success: function (data) {  
                        let a = data[data.length - 1].id;
                        for (id = 1; id <= a; id++) {
                            $.ajax({
                                url: "https://cs-leduy.herokuapp.com/bill/" + id,
                                method: "DELETE",
                                dataType: 'json',
                                success: function (data) {
                                    baybanDashboard.revenueTable();
                                }
                            })
                        }
                        $('#cartTable').empty();
                        $('#cartcustomerTable').empty();
                        bootbox.alert(" Bàn đã hoàn thành!");
                    }
                })
            }
        }
    });
}
baybanDashboard.getDataCustomer = function (id) {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/customer/" + id,
        method: "GET",
        dataType: "json",
        success: function (data) {
            var revenue = {};
            revenue.name = data.oderCustomerName;
            revenue.phone = data.oderPhoneNumber;
            revenue.food = data.oderNameFood;
            revenue.price = data.oderPrice;
            revenue.amount = data.oderAmount;
            $.ajax({
                url: "https://cs-leduy.herokuapp.com/revenue/",
                method: "POST",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(revenue)
            })
        }
    })
}
baybanDashboard.getDataBill = function () {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/bill/",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $.each(data, function (i, v) {
                if (v.name == "people") {
                    a = v.cartname;
                    b = v.cartPhone;
                }
            })
            $.each(data, function (i, v) {
                if (v.name == "food") {
                    let revenue = {};
                    revenue.food = v.nameFood;
                    revenue.price = v.priceFood;
                    revenue.amount = v.amoutFood;
                    revenue.phone = b;
                    revenue.name = a;
                    $.ajax({
                        url: "https://cs-leduy.herokuapp.com/revenue/",
                        method: "POST",
                        dataType: "json",
                        contentType: "application/json",
                        data: JSON.stringify(revenue)
                    })
                }
            })
        }
    })
}
baybanDashboard.revenueTable = function () {
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/revenue/",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#revenueTable').empty();
            id = 1;
            revenue = 0;
            $.each(data, function (i, v) {
                revenue += v.price * v.amount;
                $('#revenueTable').append(
                    "<tr class='unit-1 text-center' >" +
                    "<td>" + (id++) + "</td>" +
                    "<td>" + v.name + "</td>" +
                    "<td>" + v.phone + "</td>" +
                    "<td>" + v.food + "</td>" +
                    "<td>" + v.price + "</td>" +
                    "<td>" + v.amount + "</td>" +
                    "<td>" + v.price * v.amount + "</td>" +
                    "</tr>"
                );
            })
            $('#revenueTable').append(
                "<tr class='unit-1 text-center' >" +
                "<td>" + (id++) + "</td>" +
                "<td><b> " + "Tổng" + "</b></td>" +
                "<td>" + "</td>" +
                "<td>" + "</td>" +
                "<td>" + "</td>" +
                "<td>" + "</td>" +
                "<td><b>" + revenue + "</b></td>" +

                "</tr>"
            );
        }
    });

}
baybanDashboard.revenue = function () {
    bootbox.confirm({
        title: "Bạn có muốn xóa doanh thu !",
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
                    url: "https://cs-leduy.herokuapp.com/revenue/",
                    method: "GET",
                    dataType: "json",
                    success: function (data) {
                        let a = data[data.length - 1].id;
                        for (id = 1; id <= a; id++) {
                            $.ajax({
                                url: "https://cs-leduy.herokuapp.com/revenue/" + id,
                                method: "DELETE",
                                dataType: 'json',
                                success: function (data) {
                                    baybanDashboard.revenueTable();
                                }
                            })
                        }
                        bootbox.alert(" Đã xóa thành công!");
                    }
                })

            }
        }
    });

}
menuDashboard.openModal = function () {
    menuDashboard.resetMenu();
    $('#addMenu').modal('show');
};
baybanDashboard.init = function () {
    baybanDashboard.showTable();
    baybanDashboard.showCustomerTable();
    baybanDashboard.showCartTable();
    baybanDashboard.revenueTable();
}
menuDashboard.init = function () {
    menuDashboard.showMenu();
}
$(document).ready(function () {
    baybanDashboard.init();
    menuDashboard.init();

});
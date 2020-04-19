var dashboard = dashboard || {};
dashboard.drawTable = function () {
    $.ajax({
        url: "http://localhost:3000/Students",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#tbStudent').empty();
            id = 1;
            $.each(data, function (i, v) {
                $('#tbStudent').append(
                    "<tr>" +
                    "<td>" + (id++) + "</td>" +
                    "<td>" + v.fullName + "</td>" +
                    "<td><img src=" + v.avatar + " width='50px' height='60px' /></td>" +
                    "<td>" + v.amount + "</td>" +
                    "<td>" +
                    "<a href='javascript:;' onclick='dashboard.detail(" + v.id + ");'><i class='fa fa-edit'></i></a> " +
                    "<a href='javascript:;' onclick='dashboard.remove(" + v.id + ");'><i class='fa fa-trash'></i></a>" +
                    "</td>" +
                    "</tr>",
                );

            })

        }
    });

};
dashboard.remove = function (id) {
    bootbox.confirm({
        title: "Remove Product?",
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
                    url: "http://localhost:3000/Students/" + id,
                    method: "DELETE",
                    dataType: 'json',
                    success: function (data) {
                        dashboard.drawTable();
                        bootbox.alert("You have deleted the folder (Bạn đã xóa thư mục)");
                    }
                })
            }
        }
    });
}
dashboard.save = function () {
    if ($('#formAddDog').valid()) {
        if ($('#productId').val() == 0) { //tạo mới
            var addObj = {};
            addObj.fullName = $('#dogName').val();
            addObj.avatar = $('#dogImage').val();
            addObj.amount = $('#dogAmount').val();

            console.log(addObj);
            $.ajax({
                url: "http://localhost:3000/Students",
                method: "POST",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(addObj),
                success: function (data) {
                    $('#addStudent').modal('hide');
                    dashboard.drawTable();
                    bootbox.alert("Dữ liệu đã được thêm vào");
                }
            })
        }
        else{
            var updateObj={};
            updateObj.fullName = $('#dogName').val();
            updateObj.avatar = $('#dogImage').val();
            updateObj.amount = $('#dogAmount').val();
            updateObj.id = $('#productId').val();
            $.ajax({
                url: "http://localhost:3000/Students/" + updateObj.id,
                method: "PUT",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(updateObj),
                success: function(data){
                    $('#addStudent').modal('hide');
                    dashboard.drawTable();
                    bootbox.alert("Dữ liệu đã được cập nhật");

                }
            })


        }
    };
}
dashboard.detail = function (id) {
    $.ajax({
        url: "http://localhost:3000/Students/" + id,
        method: "GET",
        dataType: 'json',
        success: function (data) {
            $('#dogName').val(data.fullName);
            $('#dogImage').val(data.avatar);
            $('#dogAmount').val(data.amount);
            $('#productId').val(data.id);

            $('#addStudent').find('.modal-title').text('Update Product');
            $('#btnProduct').text("Update")
            $('#addStudent').modal('show');
        }
    });
}
dashboard.resetForm = function () {
    $('#dogName').val(' ');
    $('#dogImage').val(' ');
    $('#dogAmount').val(' ');
    $('#productId').val('0');

}
dashboard.openModal = function () {
    dashboard.resetForm();
    $('#addStudent').modal('show');
};

dashboard.init = function () {
    dashboard.drawTable();
}


$(document).ready(function () {
    dashboard.init();
});
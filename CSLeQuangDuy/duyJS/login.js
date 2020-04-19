var adminLogin = adminLogin || {};
adminLogin.check = function () {
    let email = $('#email').val();
    let pass = $('#pass').val();
    let isLogged = false;
    $.ajax({
        url: "https://cs-leduy.herokuapp.com/adminLogin",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $.each(data, function (i, v) {
                if (v.userEmail == email && v.password == pass) {
                    isLogged = true;
                    window.location.href = "baybanDashboard.html";
                }
            })
            if (!isLogged) {
                $('#loginFail').removeClass('d-none');
            }
        }
    })  
}
adminLogin.forgot = function () {
    bootbox.alert(" Chúc mừng bạn quay vào ô mất lượt");
}
adminLogin.signup = function () {
    bootbox.alert("Chúc mừng bạn quay vào ô mất lượt ");
}

$(document).ready(function () {

});

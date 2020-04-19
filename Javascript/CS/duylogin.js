var duylogin = duylogin || {};
duylogin.check = function () {
    let email = $('#email').val();
    let password = $('#pass').val(); 
    let isLogged = false;
    $.ajax({
        url: "http://localhost:3000/DuyUsers",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $.each(data, function (i, v) {
                if (v.userName == email && v.password == password) {
                    isLogged = true;
                    window.location.href = "dashbord.html";
                }
            })
            if (!isLogged) {
                $('#loginFail').removeClass('d-none');
            }
        }
    })
}

$(document).ready(function () {
    
});

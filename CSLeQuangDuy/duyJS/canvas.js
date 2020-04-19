window.onload = function () {
    var canvas = document.getElementById("myCanvas");
    var context = canvas.getContext("2d");
    context.font = "300% Comic Sans MS"; //font chữ
    context.fillStyle = "#FFD700"; //Màu chữ
    context.shadowColor = "#555"; //Màu bóng
    context.shadowBlur = 10; //Độ nhòe bóng
    context.shadowOffsetX = 5; //Khoảng cách bóng tới chữ, tính theo chiều ngang
    context.shadowOffsetY = 5; //Khoảng cách bóng tới chữ, tính theo chiều dọc
    context.fillText("Bảy Ban", 70, 50);

    let ctx = canvas.getContext("2d");
    ctx.font = "175% Comic Sans MS";
    ctx.fillStyle = "#FFD700";
    ctx.fillText("restaurant", 260, 55);
  };
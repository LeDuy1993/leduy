var student = student || {};
// student.drawTable = function () {
//     $.ajax({
//         url: "http://localhost:3000/Students",
//         method: "GET",
//         dataType: "json",
//         success: function (data) {
//             $.each(data, function (i, v) {
                  
//                     $('#tbStudent').append(
//                         "<tr>" +
//                         "<td>" + v.id + "</td>" +
//                         "<td>" + v.fullName + "</td>" +
//                         "<td><img src=" + v.avatar + " width='50px' height='60px' /></td>" +
//                         "<td>" + v.dob + "</td>" +
//                         "<td>" + " <input id='inputOrder' type='number' placeholder='Số lượng' oninput='main()' " + "</td>" +
//                         "</tr>",
//                     );
//                     main =function(){
//                         let a = $('#inputOrder').val();
//                         console.log(a);}
                
//             })
          
//         }
//     });

// };

student.drawSection = function () {

    $.ajax({
        url: "http://localhost:3000/Students",
        method: "GET",
        dataType: "json",
        success: function (data) {
            $.each(data, function (i, v) {
                $('#tbStudent1').append(
                    '<div class="col-md-6 col-lg-4 mb-4 mb-lg-4">' +
                    '<a href="#" class="unit-1 text-center">' +
                    '<img src=' + v.avatar + '   class="img-fluid">' +
                    '<div class="unit-1-text">' +
                    '<strong class="text-primary mb-2 d-block">$590</strong>' +
                    '<h3 class="unit-1-heading">Santorini, Greece</h3>' +
                    '</div>' +
                    ' </a>' +
                    ' </div>'
                );
            })

        }
    });
};


student.openModal = function () {
    $('#addStudent').modal('show');
};

student.init = function () {
    student.drawSection();
 
    // student.output();


}

$(document).ready(function () {
    student.init();

});
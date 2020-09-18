$(document).ready(function () {

    $('li').find('button2').click(function (evt) {
        evt.preventDefault();
        var num = this.id;

        var id = parseInt(num);

        debugger

        console.log("Participar en evento!");

        debugger

        var Event_id = 0;
        var User_id = 0;
        var data = { event_id: Event_id, user_id: User_id, Id: id };
        var url = "https://localhost:44304/Convocados/Create" + "/" + id;
        //var url = "https://localhost:44304/Convocados/Create";

        debugger
        $.get(url, id).done(function (dataLogin) {
            console.log(dataLogin)
            debugger

            if (dataLogin.ok) {

                evt.preventDefault();

                //swal({
                //    title: 'Estas seguro de querer jugar??',
                //    showDenyButton: true,
                //    showCancelButton: true,
                //    confirmButtonText: `Estoy seguro`,
                //    cancelButtonText: `No mejor no`,
                //    //denyButtonText: `No, mejor no`,                    
                //}).then((result) => {
                //    evt.preventDefault();
                //    if (result.isConfirmed) {
                //        swal('Convocado!!!', '', 'success')
                //    } else if (result.isDenied) {
                //        swal('Eres una gallina', '', 'info')
                //    }
                //})

                swal({
                    title: "Are you sure?",
                    text: "You will not be able to recover this imaginary file!",
                    icon: "warning",
                    buttons: [
                        'No, cancel it!',
                        'Yes, I am sure!'
                    ],
                    dangerMode: true,
                }).then(function (isConfirm) {
                    if (isConfirm) {
                        swal({
                            title: 'Shortlisted!',
                            text: 'Candidates are successfully shortlisted!',
                            icon: 'success'
                        }).then(function () {
                            form.submit(); // <--- submit form programmatically
                        });
                    } else {
                        swal("Cancelled", "Your imaginary file is safe :)", "error");
                    }
                })

            };
        });
          
    });
});

//$(document).ready(function () {

//    console.log("listos!");

//    $('#login').click(function (evt) {
//        evt.preventDefault();

//        var url = "https://localhost:44304/Users/Login";
//        var Email = $('#email').val();
//        var Password = $('#password').val();
//        var data = { email: Email, password: Password };



//        $.post(url, data).done(function (dataLogin) {
//            console.log(dataLogin)
//            //debugger           

//            if (dataLogin.ok) {
//                evt.preventDefault();
//                console.log(dataLogin)
//                //debugger
//                window.location.href = "https://localhost:44304/convoca/index";
//            } else {
//                //debugger
//                evt.preventDefault();
//                swal(
//                    'Oops!',
//                    'Algo esta mal!',
//                    'error'
//                )
//            }
//        })
//    })
//    //////////////////////*//////////////

//});


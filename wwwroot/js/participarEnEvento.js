$(document).ready(function () {

    $('li').find('.participate').click(function (evt) {
        evt.preventDefault();
        var num = this.id;
        num = num.substr(12); //Quita el String, solo devuelve ID

        var id = parseInt(num);

        //debugger

        var Event_id = 0;
        var User_id = 0;
        var data = { event_id: Event_id, user_id: User_id, Id: id };
        //var url = "https://localhost:44304/Convocados/Create" + "/" + id;
        var url = "https://localhost:44304/Convocados/Create";


        var request = $.ajax({
            type: "post",
            url: "https://localhost:44304/Convocados/Create",
            dataType: "json",
            //data: { event_id: Event_id, user_id: User_id, Id: id },
            statusCode: {
                401: function () {                    
                    console.log("Registrate caballo");
                    evt.preventDefault();
                    swal({
                        type: 'info',
                        title: 'Oops...Debes crear tu cuenta',
                        text: 'Se el mejor!!!',
                        showCancelButton: true,
                        confirmButtonColor: 'green',
                        confirmButtonText: 'Si, quiero crearla',
                        cancelButtonText: "No, no quiero!",
                        cancelButtonColor: 'red'
                    }).then(function (isConfirm) {

                        if (isConfirm && isConfirm.value == true) {
                            window.location.href = "https://localhost:44304/Users/Create";
                        }
                        else {
                            swal("Cobarde!!!", "Es mejor que corras", "error");
                        }
                    });
                }                
            }
            //success: function () {
            //    console.log("a Jugar")
            //    debugger
            //}
        });  

        swal({
            title: "Estas seguro que quieres participar??",
            text: "No seas cobarde, acepta el reto",
            type: "warning",
            showCancelButton: true,
            //confirmButtonColor: '#DD6B55',
            confirmButtonColor: 'green',
            confirmButtonText: 'Si, quiero participar',
            cancelButtonText: "No, no quiero!",
            cancelButtonColor: 'red'
            //closeOnConfirm: false,
            //closeOnCancel: false

        }).then(function (isConfirm) {

            if (isConfirm && isConfirm.value == true) {

                swal("Estas CONVOCADO", "Ha sido agreagado a este evento", "success");

                $.post(url, data).done(function (dataLogin) {
                    datlogin.preventDefault();
                    if (dataLogin.ok)
                        window.location.href = "https://localhost:44304/Events/Index/AllEvents";
                    else {
                        alert("HAY UN PUTO PROBLEMA")
                    }
                })
            }
            else {

                swal("Cobarde!!!", "Es mejor que corras", "error");
            }
        }); 
    });
});

//swal({
//    title: "Estas seguro que quieres participar??",
//    text: "No seas cobarde, acepta el reto",
//    type: "warning",
//    showCancelButton: true,
//    //confirmButtonColor: '#DD6B55',
//    confirmButtonColor: 'green',
//    confirmButtonText: 'Si, quiero participar',
//    cancelButtonText: "No, no quiero!",
//    cancelButtonColor: 'red'
//    //closeOnConfirm: false,
//    //closeOnCancel: false

//}).then(function (isConfirm) {

//    if (isConfirm && isConfirm.value == true) {

//        swal("Estas CONVOCADO", "Ha sido agreagado a este evento", "success");

//        $.post(url, data).done(function (dataLogin) {
//            datlogin.preventDefault();
//            if (dataLogin.ok)
//                window.location.href = "https://localhost:44304/Events/Index/AllEvents";
//            else {
//                alert("HAY UN PUTO PROBLEMA")
//            }
//        })
//    }
//    else {

//        swal("Cobarde!!!", "Es mejor que corras", "error");
//    }
//}); 






        //console.log(request);
        ////debugger       

        //request.fail(
        //    function () {
        //        evt.preventDefault();
        //        swal({
        //            icon: 'sad',
        //            title: 'Oops...Debes crear tu cuenta',
        //            text: 'Se el mejor!!!'                    
        //        })

        //        //alert("Oops, something went wrong!");
        //        window.location.href = "https://localhost:44304/Users/Create"
        //});
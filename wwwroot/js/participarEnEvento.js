$(document).ready(function () {

    $('li').find('button2').click(function (evt) {
        evt.preventDefault();
        var num = this.id;

        var id = parseInt(num);

        //debugger

        

        //debugger

        var Event_id = 0;
        var User_id = 0;
        var data = { event_id: Event_id, user_id: User_id, Id: id };
        //var url = "https://localhost:44304/Convocados/Create" + "/" + id;
        var url = "https://localhost:44304/Convocados/Create";

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


//if (dataLogin.ok) {

                    //Console.log("El dato llegó")


                    //window.location.href = "https://localhost:44304/Events/Details/id";

                    //swal({
                    //    title: 'CONVOCADO!',
                    //    text: 'Haz sido agregado al evento, Ganales!!!',
                    //    icon: 'success'
                    //})                    //debugger

                    //}
                    //    window.location.href = "https://localhost:44304/Events/index/id";
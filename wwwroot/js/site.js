//<script src="js/site.js"></script>


$(document).ready(function () {
    console.log("listos!");

    $("#test").click(function (event) {
        event.preventDefault();
        //alert("Click en pepe");        
        swal('Bienvenido', 'Haz sido registrado en este evento', 'success')
        //swal({
        //    title: "Has sido registrado en este evento",
        //    text: "Se cerrará en 3 segundos.",
        //    //timer: 3000,
        //    showConfirmButton: true
        //});
    });  
});


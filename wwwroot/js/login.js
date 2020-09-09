//<script src="js/site.js"></script>


$(document).ready(function () {
    console.log("listos!");

    $(":submit").click(function (event) {
        event.preventDefault();
         
        swal({
            title: "Bienvenido!",
            text: "Te estabamos esperando!",
            type: "success"
        }).then(function () {
            window.location = "https://localhost:44304/Convoca/Index";
            //window.location = "Convoca/Index";
        }, 1000);
    })
          
});
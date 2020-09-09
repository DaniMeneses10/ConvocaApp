$(document).ready(function () {

       
    $('li').find('h4').click(function () {        
        var id = this.id
        console.log(id)        
        var $parrafos = $('#parent-' + id).children('label')
        console.log($parrafos)
        mostrarSecuencia($parrafos, 20)
    });


    function mostrarSecuencia($coleccion) {
        $coleccion.each(function () {
            $(this).slideToggle();

        });
    }

});

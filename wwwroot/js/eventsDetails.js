$(document).ready(function () {

       
    $('li').find('button1').click(function () {        
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

    //$('.controls').first().slideDown();

    //$('h4').on('click', function (evt) {
    //    evt.preventDefault();
    //    $('.controls').not(this).each(function () {
    //        $(this).slideUp();
    //    });

    //    $(this).siblings('.controls').slideToggle();
    //})

});

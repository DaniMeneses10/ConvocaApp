$(document).ready(function () {

       
    //$('li').find('button1').click(function () {        
    $('li').find('.details').click(function () {        

        var id = this.id
        id = id.substr(8); //Quita el String, solo devuelve ID

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

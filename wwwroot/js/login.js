
$(document).ready(function () {
    
    console.log("listos!");

    $('#login').click(function (evt) {
        evt.preventDefault(); 
        
        var url = "https://localhost:44304/Users/Login";
        var Email = $('#email').val();
        var Password = $('#password').val();
        var data = { email: Email, password: Password};
        
     
        $.post(url, data).done(function (dataLogin) {
            console.log(dataLogin)

                        
            if (dataLogin.ok) {                
                evt.preventDefault();
                console.log(dataLogin)
                //debugger
                window.location.href = "https://localhost:44304/convoca/index";
            } else {
                //debugger
                evt.preventDefault();                
                swal(
                    'Oops!',
                    'Algo esta mal!',
                    'error'
                )
            }
        })
    }) 
});



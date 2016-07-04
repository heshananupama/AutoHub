

/*
        Welcome screen Script 
 */
jQuery(document).ready(function () {
	
    /*
        Fullscreen background
    */
    $.backstretch([
                    "assets/img/backgrounds/2.jpg"
	              , "assets/img/backgrounds/1.jpg"
	              , "assets/img/backgrounds/3.jpg"
	             ], {duration: 3000, fade: 750});
    
    /*
        Form validation
    */
    $('.login-form input[type="text"], .login-form input[type="password"], .login-form textarea').on('focus', function() {
    	$(this).removeClass('input-error');
    });
   
    
    
});
/*
       End of  Welcome screen Script 
 */
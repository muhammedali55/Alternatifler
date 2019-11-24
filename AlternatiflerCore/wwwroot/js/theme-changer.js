$(document).ready(function($) {

	$('#stylesw').styleSwitcher();
	$('#stylesw1').styleSwitcher1();
		
	$('.open-close-demo').click(function() {
		if ($(this).parent().css('left') == '-152px') {
			$(this).addClass("active-demo").parent().animate({
				"left": "0"
			}, 300);
			
		} else {
			$(this).removeClass("active-demo").parent().animate({
				"left": "-152px"
			}, 300);
		}
		
	});
	
	$('a.color-themes').click(function() {
		return false;
	});
	
});

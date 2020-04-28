$(window).on('scroll', function(){
  
  var e = $(window).scrollTop();
  if(e > 0) {
    $(".navigation").css({
      position : "span"
    });
  } else {
    $(".navigation").css({
      position : "absolute"
    });
  }
})
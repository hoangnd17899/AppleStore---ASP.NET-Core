window.onscroll = function() {scrollFunction()};

function scrollFunction() {
  if (document.body.scrollTop > 55 || document.documentElement.scrollTop > 55) {
    //Thay đổi header khi kéo thanh cuộn xuống
    $('#header').addClass('navbarscrolled');
    $('li.logo').css('top','10px');
    $('li.cart').css('padding-top','0px');
    
  } else {
    //Thay đổi header khi kéo thanh cuộn lên trên cùng
    $('#header').removeClass('navbarscrolled');
    $('.logo').css('top','22px');
    $('li.cart').css('padding-top','7px');
  }
}
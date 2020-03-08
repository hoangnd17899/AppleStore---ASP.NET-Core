$(document).ready(function(){
    var index=new Index();
})

class Index{
    constructor(){
        this.loadTotal();
    }

    //Hàm load tổng tiền để hiện thị
    //Nguyễn Đình Hoàng - 18/2/2020
    loadTotal(){
        var pros={};
        $.ajax({
            method: 'GET',
            url:'/products/cart',
            success:function(res){
                if(res.success){
                    pros=res.data;
                    //Biến lưu tổng tiền trong giỏ hàng hiện tại
                    var sub_total=0;
                    $.each(pros,function(index,item){
                        sub_total+=parseInt(item.price);
                    })
                    $('#total').html(sub_total.toLocaleString('it-IT', {style : 'currency', currency : 'VND'}));
                }
                else{
                    alert(res.message);
                }   
            }
        })
    }
}
$(document).ready(function(){
    var index=new Index();
})

class Index{
    constructor(){
        this.LoadProductsInCart();
        this.InitEvent();
    }

    //Hàm xử lý sự kiện trang cart 
    //Nguyễn Đình Hoàng - 15/2/2020
    InitEvent(){
        //Hàm click vào button xóa sản phẩm khỏi giỏ hàng
        $(document).on('click','button[productID]',{'this_Index':this},this.DeleteFromCart);
    }    

    //Hàm xóa sản phẩm khỏi giỏ hàng
    //Nguyễn Đình Hoàng - 15/2/2020
    DeleteFromCart(event){
        var _productID=$(this).attr('productID');
        var this_Index=event.data['this_Index'];
        $.ajax({
            method:'DELETE',
            url:'/products',
            data:{productID:_productID},
            success:function(res){
                if(res.success){
                    this_Index.LoadProductsInCart();
                }
                else{
                    alert(res.message);
                }
            },
            error:function(){
            }
        })
    }

    //Hàm load danh sách sản phẩm trong giỏ hàng 
    // Nguyễn Đình Hoàng - 15/2/2020
    LoadProductsInCart(){
        var pros={};
        $.ajax({
            method: 'GET',
            url:'/products/cart',
            success:function(res){
                if(res.success){
                    pros=res.data;
                    //Biến lưu tổng tiền trong giỏ hàng hiện tại
                    var sub_total=0;
                    $('#ProductsInCart').empty();
                    $.each(pros,function(index,item){
                        sub_total+=parseInt(item.price);
                        var pro = '<tr>'+
                                    '<td><img src="contents/images/products/{0}" /> </td>'.format(item.image)+
                                    '<td>{0}</td>'.format(item.productName)+
                                    '<td>In stock</td>'+
                                    '<td><input class="form-control" type="text" value="1" /></td>'+
                                    '<td class="text-right">{0} </td>'.format(item.price.toLocaleString('it-IT', {style : 'currency', currency : 'VND'}))+
                                    '<td class="text-right"><button class="btn btn-sm btn-danger" productID="{0}"><i class="fa fa-trash"></i> </button> </td>'.format(item.productID)+
                                '</tr>';
                        $('#ProductsInCart').append(pro);
                    })

                    //Chuỗi html cho tổng tiền giỏ hàng    
                    var sub_total_html='<tr><td></td><td></td><td></td><td></td><td>Sub-Total</td>'+
                    '<td class="text-right">{0} </td></tr>'.format(sub_total.toLocaleString('it-IT', {style : 'currency', currency : 'VND'}));
                    //Chuỗi html cho phần tiền ship
                    var ship_html='<tr><td></td><td></td><td></td><td></td><td>Shipping</td>'+
                    '<td class="text-right">{0} </td></tr>'.format('0 ₫');
                    //Chuỗi html cho tổng tiền (bao gồm ship)
                    var total_html= '<tr><td></td><td></td><td></td><td></td><td><strong>Total</strong></td>'+
                    '<td class="text-right"><strong>{0} </strong></td></tr>'.format(sub_total.toLocaleString('it-IT', {style : 'currency', currency : 'VND'}));
                    $('#ProductsInCart').append(sub_total_html);
                    $('#ProductsInCart').append(ship_html);  
                    $('#ProductsInCart').append(total_html);
                }
                else{
                    alert(res.message);
                }   
            }
        })
    }
}

$(document).ready(function(){
    var index=new Index();
})

//Biến lưu số sản phẩm hiển thị trong 1 trang
var pageSize=12;

class Index{
    constructor(){
        this.LoadProductS();
        this.InitEvents();
    }

    //Hàm xử lý sự kiện trang shop
    //Nguyễn Đình Hoàng - 7/2/2020
    InitEvents(){
        //Chọn danh mục hiển thị sản phẩm
        $(document).on('click','.cate_button',{ 'this_Index': this },this.ChoseCategory)

        //Các hàm xử lý phân trang
        //Chọn trang
        $(document).on('click','.pagenumber',{ 'this_Index': this },this.ChosePage)
        //Chọn trang trước
        $(document).on('click','.previouspage',{ 'this_Index': this },this.PreviousPage)
        //Chọn trang kế tiếp
        $(document).on('click','.nextpage',{ 'this_Index': this },this.NextPage)
    }

    //Hàm chọn trang trước
    //Nguyễn Đình Hoàng - 9/2/2020
    PreviousPage(event){
        var currentPage=$('.pagepicked').html();
        var this_Index=event.data["this_Index"];

        //Kiểm tra xem trang hiện tại có lớn hơn 1 không
        if(currentPage>1){
            $('.pagepicked').removeClass('pagepicked');
            $('a.pagenumber[page="{0}"]'.format(parseInt(currentPage)-1)).addClass('pagepicked');
            this_Index.LoadProductS();
            $('html, body').animate({scrollTop: '91px'}, 0);
        }
    }

    //Hàm chọn trang sau
    //Nguyễn Đình Hoàng - 9/2/2020
    NextPage(event){
        debugger
        var currentPage=$('.pagepicked').html();
        var this_Index=event.data["this_Index"];
        var countProducts=0;
        var maxPage=0;

        $.ajax({
            method:'GET',
            url:'/products/count?category={0}'.format($('.catepicked').attr('cate')),
            success: function(res){
                if(res.success){
                    //Xử lý hiển thị phần phân trang
                    debugger
                    countProducts=res.data;
                    if(countProducts%pageSize==0){
                        maxPage=countProducts/pageSize;
                    }
                    else{
                        maxPage=countProducts/pageSize+1;
                    }

                    if(currentPage<parseInt(maxPage)){
                        $('.pagepicked').removeClass('pagepicked');
                        $('a.pagenumber[page="{0}"]'.format(parseInt(currentPage)+1)).addClass('pagepicked');
                        this_Index.LoadProductS();
                        $('html, body').animate({scrollTop: '91px'}, 0);
                    }
                }
                else{
                    alert(res.message);
                }
            }
        })
    }

    //Hàm chọn danh mục hiển thị sản phẩm
    //Nguyễn Đình Hoàng - 8/2/2020
    ChoseCategory(event){
        //thực hiện thay đổi danh mục
        $('.catepicked').removeClass('catepicked');
        $(this).addClass('catepicked');
        var this_Index = event.data["this_Index"];

        //Xử lý hiển thị phần phân trang và load lại dữ liệu
        var countProducts=0;
        $.ajax({
            method:'GET',
            url:'/products/count?category={0}'.format($('.catepicked').attr('cate')),
            success: function(res){
                if(res.success){
                    //Xử lý hiển thị phần phân trang
                    countProducts=res.data;
                    $('.page-number-display').empty();
                    if(countProducts%pageSize == 0){
                        for(var i=1;i<=countProducts/pageSize;i++){
                            var pageDisplay='<li class="page-item"><a class="page-link pagenumber" page="{0}">{1}</a></li>'.format(i,i);
                            $('.page-number-display').append(pageDisplay);
                        }
                    }
                    else{
                        for(var i=1;i<=countProducts/pageSize+1;i++){
                            var pageDisplay='<li class="page-item"><a class="page-link pagenumber" page="{0}">{1}</a></li>'.format(i,i);
                            $('.page-number-display').append(pageDisplay);
                        }
                    }

                    //load lại danh sách sản phẩm theo danh mục mới
                    this_Index.LoadProductS();
                }
                else{
                    alert(res.message);
                }
            }
        })
    }

    //Hàm chọn trang trong mục phân trang
    //Nguyễn Đình Hoàng - 8/2/2020
    ChosePage(event){
        $('.pagepicked').removeClass('pagepicked');
        $(this).addClass('pagepicked');
        var this_Index = event.data["this_Index"];
        this_Index.LoadProductS();

        //Scroll lại lên đầu trang
        $('html, body').animate({scrollTop: '0px'}, 0);
    }

    //Hàm load dữ liệu sản phẩm theo danh mục và số trang
    //Nguyễn Đình Hoàng - 8/2/2020
    LoadProductS(){
        //Xử lý lấy dữ liệu    
        var productList={};
        var urlapi="";
        var category=$('.catepicked').attr('cate');
        var pagenumber=$('.pagepicked').html();
        if(category==null){
            $("a[cate='all']").addClass('catepicked');
            category="all";
        }
        if(pagenumber==null){
            urlapi='/products?category={0}'.format(category);
            $('a.pagenumber[page="1"]').addClass('pagepicked');
        }
        else{
            urlapi='/products?category={0}&pageNumber={1}'.format(category,pagenumber);
        }
        $.ajax({
            method:'GET',
            url:urlapi,
            contentType: 'application/json; charset=utf-8',
            success: function(res){
                if(res.success){
                    productList=res.data;

                    $('.productlist').empty();
                    $.each(productList,function(index,item){
                        var pro = '<div class="card" style="width: 288px;">'
                                        +'<img src="contents/images/products/{0}" class="card-img-top" alt="...">'.format(item.image)
                                        +'<div class="card-body">'
                                            +'<h5 class="card-title" style="text-align: center;">{0}</h5>'.format(item.productName)
                                            +'<a href="/Shop/AddToCart?productID={0}" class="btn btn-primary btnAdd">Add to Cart</a>'.format(item.productID)
                                            +'<a href="/Singleproduct/Index?id={0}" class="btn btn-primary btnView">Views Detail</a>'.format(item.productID)
                                        +'</div>'
                                    +'</div>';
                        $('.productlist').append(pro);
                    })
                }
                else{
                    alert(res.message);
                }
            }
        })
    }
}


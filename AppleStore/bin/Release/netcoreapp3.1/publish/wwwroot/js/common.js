/*
Chuyển cộng chuỗi sang kiểu truyền parameter
Người tạo: Nguyễn Đình Hoàng
Ngày tạo: 2/8/2019
*/
if (!String.prototype.format) {
    String.prototype.format = function () {
        var args = arguments;
        return this.replace(/{(\d+)}/g, function (match, number) {
            return typeof args[number] !== 'undefined'
                ? args[number]
                : match
                ;
        });
    };
};

/*
Thực hiện định dạng dữ liệu kiểu thời gian theo định dạng dd/MM/yyyy
Người tạo: Nguyễn Đình Hoàng
Ngày tạo: 2/8/2019
*/
Date.prototype.formatddMMyyyy = function () {
    var day = this.getDate() + "";
    if (day.length == 1) { day = "0" + day };
    var month = this.getMonth() + 1 + "";
    if (month.length == 1) { month = "0" + month };
    var year = this.getFullYear();
    return day + '/' + month + '/' + year;
}

/*
Thực hiện chuyển định dạng ngày ddMMyyyy(chuỗi) thành dạng yyyyMMdd để lưu vào database 
Người tạo: Nguyễn Đình Hoàng
Ngày tạo: 4/8/2019
*/
String.prototype.formatyyyyMMdd = function () {
    var element = this.split('/');
    var day = element[0];
    var month = element[1];
    var year = element[2];
    return year + '/' + month + '/' + day;
}
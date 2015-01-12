$(document).ready(function () {
    $(".top_text1").hover(function () {
        $(this).css("color", "red");
    }, function () {
        $(this).css("color", "white");
    });
});
$(document).ready(function () {
    $(".sidebarItem").hover(function () {
        $(this).addClass("mouseON");
        $(this).click(function () {
            $("#aktiw").removeAttr("id");
            $(this).attr('id', 'aktiw');
        });
    }, function () {
        $(this).removeClass("mouseON");
    });
   
});

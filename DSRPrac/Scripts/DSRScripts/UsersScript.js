$(document).ready(function () {
    $("#Submit").click(function () {
        if ($("#FirstName").val() == '' || $("#LastName").val() == '' || $("#Id").val()=='' ) {
            alert("Some fields are missing");
        }
        else {
            var user = {
                Id:$("#Id").val(),
                FirstName:$("#FirstName").val(),
                LastName:$("#LastName").val()
            }
        }
        debugger;
        $.ajax({
            type: "POST",
            url: "/Users/Add",
            data: user,
            cache: false,
            success: function(result) {
                alert("User Saved");
            }
        })
    })
}
    )
 
        

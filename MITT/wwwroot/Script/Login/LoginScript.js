$(document).ready(function ()
{
    demo.checkFullPageBackgroundImage();
});

$("#PASSWORD").keyup(function (event) {
    if (event.keyCode === 13) {
        Login();
    }
});

$("#USERNAME").keyup(function (event) {
    if (event.keyCode === 13) {
        Login();
    }
});

function showPassword()
{
    var x = document.getElementById("PASSWORD");
    if (x.type === "password") {
        x.type = "text";
    }
    else {
        x.type = "password";
    }
}

function Login()
{
    debugger;
    if ($("#USERNAME").val() == 0 && $("#PASSWORD").val() == 0)
    {
        document.getElementsByTagName("p")[0].innerHTML = "Your Username and Password cannot be empty";
    }
    else if ($("#USERNAME").val() == 0)
    {
        document.getElementsByTagName("p")[0].innerHTML = "Your Username cannot be empty";
    }
    else if ($("#PASSWORD").val() == 0)
    {
        document.getElementsByTagName("p")[0].innerHTML = "Your Password cannot be empty";
    }
    else
    {
        LoginProcess();
    }
}

function LoginProcess() {
    var data = new Object();
    data.USERNAME = $("#USERNAME").val();
    data.PASSWORD = $("#PASSWORD").val();
    $.ajax({
        "url": '@this.Url.Action("FE_Authentication","Login")',
        "type": "POST",
        "data": data,
    }).then((result) => {
        if (result.StatusCode == 200)
        {

        }
        else
        {

        }
    });
}

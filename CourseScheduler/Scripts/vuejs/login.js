new Vue({
    el: "#login-form",
    data() {
        return {
            user: { id: -1, username: "", password: "" }
        };
    },
    method: {
        login() {
            var data = JSON.stringify({
                'username':user.username,
                'password': user.password
            });
            console.log(data);
            $.ajax({
                type: "POST",
                url: "Home/Login/",
                data: data,
                dataType: "json",
                success: (result) => {
                    console.log("pass");
                },
                error: function (jqXHR, exception) {
                    console.log();
                    if (jqXHR.status === 0 || jqXHR.status === 404 || jqXHR.status === 500) {
                        console.log(jqXHR.status);
                    } else if (exception === 'parsererror' || exception === 'timeout' || exception === 'abort') {
                        console.log(exception);
                    } else {
                        alert('Uncaught Error.\n' + jqXHR.responseText);
                    }
                }
            });
        }
    }


});
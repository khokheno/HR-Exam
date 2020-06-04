

var users=["jaser","ahmad","amer","jbr"];
var passwords=["000","111","1101","00009"];
function check(){
    var name=document.getElementById('user-name').value;
    var pass=document.getElementById('user-password').value;

    if (users.includes(name)){
        if (passwords.includes(pass)){
            alert("you_are_in");
        }
        else{
            alert("your_password_is_wrong");
        }
    }
    else{
        alert("your_username_is_wrong");
    }
    
    
}
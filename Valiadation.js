function valid() {
    var txt = document.getElementsByClassName('form-control');
    var newPassword, confirmPassword;
    newPassword = txt[2].value;
    if (newPassword == "") {
        alert('Enter New Password');
        txt[2].focus();
        return false;
    }
}
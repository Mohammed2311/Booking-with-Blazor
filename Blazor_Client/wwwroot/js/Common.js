window.moo = function (type, message) {
    if (type == "sucess") {
        toastr.success(message, "sucess");
    }
    if (type == "error") {
        toastr.error(message, "errorrrrrrrrrr");
    }

}
window.moo1 = function (type, message) {
    if (type == "sucess") {
        Swal.fire({
            icon: 'success',
            title: 'success...',
            text: message,
        })
    }
    if (type == "error") {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: message,
        })
    }


}


function showDelteModal() {
    $('#deleteModelConfirmation').modal('show');
}

function hideDelteModal() {
    $('#deleteModelConfirmation').modal('hide');
}
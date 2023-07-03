$(document).ready(function () {
    function validateEducationForm() {
        var isValid = true;

        // Clear any existing error messages and remove the error styling
        $('.validation-error').empty().removeClass('text-danger');

        var institutionValue = $("#institutionId").val();
        if (institutionValue === "" || institutionValue === null) {
            $('#institutionValidation').text('Please enter an institution.').addClass('text-danger');
            isValid = false;
        }

        var startDateValue = $("#startDateId").val();
        if (startDateValue === "" || startDateValue === null) {
            $('#startDateValidation').text('Please select the start date of your qualification.').addClass('text-danger');
            isValid = false;
        }

        var qualificationValue = $("#qualificationId").val();
        if (qualificationValue === "" || qualificationValue === null) {
            $('#qualificationValidation').text('Please enter your qualification name.').addClass('text-danger');
            isValid = false;
        }

        var majorsValue = $("#majorsId").val();
        if (majorsValue === "" || majorsValue === null) {
            $('#majorsValidation').text('Please enter your qualification majors.').addClass('text-danger');
            isValid = false;
        }

        return isValid;
    }

    $('#educationForm').submit(function (event) {
        if (!validateEducationForm()) {
            event.preventDefault();
        }

    });
    $('#submitButton').click(function (event) {
        if (!validateEducationForm()) {
            event.preventDefault();
        }
    })
})
$(document).ready(function () {
    function validateRefereeForm() {
        var isValid = true;

        // Clear any existing error messages and remove the error styling
        $('.validation-error').empty().removeClass('text-danger');

        var refNameValue = $("#refNameId").val();
        if (refNameValue === "" ||  refNameValue === null) {
            $('#refNameValidation').text('Please enter the referee name.').addClass('text-danger');
            isValid = false;
        }

        var refTitleValue = $("#refTitleId").val();
        if (refTitleValue === "" || refTitleValue === null) {
            $('#refTitleValidation').text('Please enter the referre job title.').addClass('text-danger');
            isValid = false;
        }

        var refInstitutionValue = $("#refInstitutionId").val();
        if (refInstitutionValue === "" || refInstitutionValue === null) {
            $('#refInstitutionValidation').text('Please enter the institution where the referee is/was based.').addClass('text-danger');
            isValid = false;
        }

        var refCellValue = $("#refCellId").val();
        if (refCellValue === "" || refCellValue === null) {
            $('#refCellValidation').text('Please enter the referee cellphone number.').addClass('text-danger');
            isValid = false;
        }

        var refEmailValue = $("#refEmailId").val();
        if (refEmailValue === "" || refEmailValue === null) {
            $('#refEmailValidation').text('Please enter the referee email.').addClass('text-danger');
            isValid = false;
        }

        return isValid;
    }

    $('#refereeForm').submit(function (event) {
        if (!validateRefereeForm()) {
            event.preventDefault();
        }

    });
    $('#submitButton').click(function (event) {
        if (!validateRefereeForm()) {
            event.preventDefault();
        }
    })
})
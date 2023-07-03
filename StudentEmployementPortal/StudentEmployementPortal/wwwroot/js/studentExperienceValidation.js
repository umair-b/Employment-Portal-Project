$(document).ready(function () {
    function validateExperienceForm() {
        var isValid = true;

        // Clear any existing error messages and remove the error styling
        $('.validation-error').empty().removeClass('text-danger');

        var employerValue = $("#employerNameId").val();
        if (employerValue === "" || employerValue === null) {
            $('#employerValidation').text('Please enter the employer.').addClass('text-danger');
            isValid = false;
        }

        var startDateValue = $("#startDateId").val();
        if (startDateValue === "" || startDateValue === null) {
            $('#startDateValidation').text('Please select the start date.').addClass('text-danger');
            isValid = false;
        }

        var jobTitleValue = $("#jobTitleId").val();
        if (jobTitleValue === "" || jobTitleValue === null) {
            $('#jobTitleValidation').text('Please enter the job title.').addClass('text-danger');
            isValid = false;
        }

        var TRValue = $("#TRId").val();
        if (TRValue === "" || TRValue === null) {
            $('#TRValidation').text('Please enter your tasks and responsibilities.').addClass('text-danger');
        }

        return isValid;
    }

    $('#experienceForm').submit(function (event) {
        if (!validateExperienceForm()) {
            event.preventDefault();
        }

    });
})
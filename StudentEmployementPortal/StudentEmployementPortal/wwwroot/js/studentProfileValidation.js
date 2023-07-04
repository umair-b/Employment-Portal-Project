$(document).ready(function () {
    
    /*// Check the fields on change
    $('input[type="text"], input[type="radio"], select').change(function () {
        checkFields();
    });

    // Function to check the fields and set readonly attribute
    function checkFields() {
        var firstName = $('#firstName').val().trim();
        var lastName = $('#lastName').val().trim();
        var idNumber = $('#studentIdNumber').val().trim();
        var gender = $('#genderId').val();
        var race = $('#raceId').val();

        // Set readonly attribute based on field values
        $('#firstName').prop('readonly', firstName !== '');
        $('#lastName').prop('readonly', lastName !== '');
        $('#studentIdNumber').prop('readonly', idNumber !== '');

        if (gender !== null) {
        $('#genderId').css('pointer-events', 'none');
        $('#genderId').css('background-color', '#f7f7f7');
        $('#genderId').css('color', '#888');

        // Prevent the dropdown from being focused
        $('#genderId').on('focus', function () {
            this.blur();
        });
        }

        if (race !== null) {
            $('#raceId').css('pointer-events', 'none');
            $('#raceId').css('background-color', '#f7f7f7');
            $('#raceId').css('color', '#888');

            // Prevent the dropdown from being focused
            $('#raceId').on('focus', function () {
                this.blur();
            });
        }
    

        var radios = $('#citizenYes, #citizenNo');

        // Check if any radio button is selected on page load
        var isAnyRadioButtonSelected = radios.is(':checked');

        // Set the radio buttons to readonly if a value is selected
        if (isAnyRadioButtonSelected) {
            radios.click(function () {
                return false;
            });
        }

    }*/

    // Function to validate the ID number
    function validateIdNumber() {
        var idNumber = $('#studentIdNumber').val();
        var isCitizen = $('input[name="Citizen"]:checked').val();

        var digitRegex = /^[0-9]+$/;

        var month = idNumber.substr(2, 2);
        var mm = parseInt(month, 10);
        var day = idNumber.substr(4, 2);
        var dd = parseInt(day, 10);

        if (idNumber.length === 0 && (isCitizen === 'true' || isCitizen === 'false')) {
            $('#idNumberValidation').text('Please enter ID/Passport number.').addClass('text-danger');
            return false;
        } else if (isCitizen === 'true') {
            if (!digitRegex.test(idNumber)) {
                $('#idNumberValidation').text('ID number should contain only digits.').addClass('text-danger');
                return false;
            }
            if (idNumber.length !== 13) {
                $('#idNumberValidation').text('ID number must be 13 digits long.').addClass('text-danger');
                return false;
            }
            var validMonth = mm >= 1 && mm <= 12;
            var validDay = dd >= 1 && dd <= 31;

            if (!validMonth || !validDay) {
                $('#idNumberValidation').text('Please enter a valid ID number.').addClass('text-danger');
                return false;
            }

            if ((mm == 4 || mm == 6 || mm == 9 || mm == 11) && dd > 30) {
                $('#idNumberValidation').text('Please enter a valid ID number.').addClass('text-danger');
                return false;
            } else if (mm == 2) {
                if (dd > 28) {
                    $('#idNumberValidation').text('Please enter a valid ID number.').addClass('text-danger');
                    return false;
                }
            }

            $('#idNumberValidation').empty().removeClass('text-danger');
            return true;
        } else if (isCitizen === 'false' && idNumber.length < 6) {
            $('#idNumberValidation').text('Passport number must be at least 6 digits long.').addClass('text-danger');
            return false;
        } else {
            $('#idNumberValidation').empty().removeClass('text-danger');
            return true;
        }
    }

    // function to validate form, check if all the required fields are selected.
    function validateForm() {
        var isValid = true;

        // Clear any existing error messages and remove the error styling
        $('.validation-error').empty().removeClass('text-danger');

        var facultyValue = $("#facultyId").val();
        if (facultyValue === "" || facultyValue === null) {
            $('#facultyValidation').text('Please select a faculty.').addClass('text-danger');
            isValid = false;
        }

        var depValue = $("#departmentId").val();
        if (depValue === "" || depValue === null) {
            $('#departmentValidation').text('Please select a department.').addClass('text-danger');
            isValid = false;
        }

        var licenseValue = $("#licenseId").val();
        if (licenseValue === "" || licenseValue === null) {
            $('#licenseValidation').text('Please select a license.').addClass('text-danger');
            isValid = false;
        }

        var genderValue = $("#genderId").val();
        if (genderValue === "" || genderValue === null) {
            $('#genderValidation').text('Please select a gender.').addClass('text-danger');
            isValid = false;
        }

        var raceValue = $("#raceId").val();
        if (raceValue === "" || raceValue === null) {
            $('#raceValidation').text('Please select a race.').addClass('text-danger');
            isValid = false;
        }

        var yosValue = $("#yosId").val();
        if (yosValue === "" || yosValue === null) {
            $('#YOSValidation').text('Please select a year of study.').addClass('text-danger');
            isValid = false;
        }

        return isValid;
    }



    // Event handler for form submission
    $('#submitButton').click(function (event) {
        if (!validateForm()) {
            event.preventDefault();
        }

        var isCitizenSelected = $('#citizenContainer input[name="Citizen"]:checked').length > 0;

        if (!isCitizenSelected) {
            event.preventDefault(); // Prevent form submission
            $('#citizenError').addClass('text-danger'); // Add validation error styling
            $('#citizenError').text('Please select an option.'); // Display validation error message
        }
        else {
            $('#citizenError').empty().removeClass('text-danger');
        }

        if (!validateIdNumber()) {
            event.preventDefault(); // Prevent form submission if validation fails
        }

    });

    // Event handler for citizenship status change
    $('input[name="Citizen"]').change(function () {
        var isCitizen = $('input[name="Citizen"]:checked').val();
        if (isCitizen === 'true' || isCitizen === 'false') {
            $('#studentIdNumber').prop('disabled', false);
            $('#idNumberValidation').empty().removeClass('text-danger');
        } else {
            $('#studentIdNumber').prop('disabled', true);
            $('#studentIdNumber').val('');
            $('#idNumberValidation').empty().removeClass('text-danger');
        }
    }).change();

    
});
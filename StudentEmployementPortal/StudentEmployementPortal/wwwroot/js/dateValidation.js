document.addEventListener("DOMContentLoaded", function () {
    var startDateInput = document.getElementById("startDate");
    var endDateInput = document.getElementById("endDate");
    var closingDateInput = document.getElementById("closingDate");

    var startDateError = document.getElementById("startDateError");
    var endDateError = document.getElementById("endDateError");
    var closingDateError = document.getElementById("closingDateError");

    startDateInput.addEventListener("change", validateDates);
    endDateInput.addEventListener("change", validateDates);
    closingDateInput.addEventListener("change", validateDates);

    startDateError.textContent = "";
    endDateError.textContent = "";
    closingDateError.textContent = "";

    function validateDates() {
        var startDate = new Date(startDateInput.value);
        var endDate = new Date(endDateInput.value);
        var closingDate = new Date(closingDateInput.value);

        /*var currentdate = new date().getfullyear();

        if (closingdate < currentdate)
            closingdateerror.textcontent = "the closing date cannot be set earlier than the current date.";
            closingdateinput.value = null;
        }*/

        if (startDate > endDate) {
            startDateError.textContent = "The start date should not be set later than the end date.";
            startDateInput.value = null;
        }
        if (startDate < closingDate) {
            startDateError.textContent = "The start date should not be set earlier than the closing date.";
            startDateInput.value = null;
        }

        if (endDate < startDate) {
            endDateError.textContent = "The end date should not be set earlier than the start date.";
            endDateInput.value = null;
        }
        if (endDate < closingDate) {
            endDateError.textContent = "The end date should not be set earlier than the closing date.";
            endDateInput.value = null;
        }

        if (closingDate > startDate) {
            closingDateError.textContent = "The closing date should not be set earlier than the start date.";
            closingDateInput.value = null;
        }
        if (closingDate > endDate) {
            closingDateError.textContent = "The closing date should not be set earlier than the end date.";
            closingDateInput.value = null;
        }
        
    }
});
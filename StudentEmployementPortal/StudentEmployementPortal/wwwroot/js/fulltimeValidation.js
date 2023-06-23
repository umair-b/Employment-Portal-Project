document.addEventListener("DOMContentLoaded", function () {
    var noRadioButton = document.getElementById("noRadioButton");
    var yesRadioButton = document.getElementById("yesRadioButton");
    var partTimeHoursContainer = document.getElementById("partTimeHoursContainer");
    var partTimeHours = document.getElementById("partTimeHours");

    function handleNoRadioButtonChange() {
        partTimeHoursContainer.style.display = "block";
    }

    function handleYesRadioButtonChange() {
        partTimeHoursContainer.style.display = "none";
        partTimeHours.value = null;
    }

    noRadioButton.addEventListener("change", handleNoRadioButtonChange);
    yesRadioButton.addEventListener("change", handleYesRadioButtonChange);

    var fullTimeRadios = document.getElementsByName("FullTime");
    for (var i = 0; i < fullTimeRadios.length; i++) {
        fullTimeRadios[i].addEventListener("change", function () {
            if (document.querySelector('input[name="FullTime"]:checked')) {
                document.querySelector('input[name="FullTime"]:checked').dispatchEvent(new Event("change"));
            }
        });
    }

    if (noRadioButton.checked) {
        handleNoRadioButtonChange();
    } else if (yesRadioButton.checked) {
        handleYesRadioButtonChange();
    }
});

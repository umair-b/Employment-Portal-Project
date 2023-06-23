
$('#facultyId').change(function () {
    var facultyId = $(this).val();
    if (facultyId) {
        $.ajax({
            url: '/ManagePost/GetDepartmentsByFaculty',
            type: 'POST',
            data: { facultyId: facultyId },
            success: function (response) {
                $('#departmentId').html(response);
                $('#departmentId').prop('disabled', false);

                // Set the selected department based on the model's DepartmentId
                var selectedDepartment = '@Model.DepartmentId';
                $('#departmentId').val(selectedDepartment);
            }
        });
    } else {
        $('#departmentId').html('<option value="" selected disabled>Select Department</option>');
        $('#departmentId').prop('disabled', true);
    }
});

// Trigger the change event on faculty dropdown to initialize the department dropdown
$('#facultyId').trigger('change');
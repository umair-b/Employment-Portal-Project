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
            }
        });
    } else {
        $('#departmentId').html('<option value="" selected disabled>Select Department</option>');
        $('#departmentId').prop('disabled', true);
    }
});
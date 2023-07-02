using StudentEmployementPortal.Models;
using Bogus;

namespace StudentEmployementPortal.TestData
{
    public class Fakers
    {
        Faker<JobPost>? _postFaker = null;

        public Faker<JobPost> GetPostGenerator()
        {
            if (_postFaker is null)
            {
                var id = 0;

                _postFaker = new Faker<JobPost>()
                    .UseSeed(100)
                    .RuleFor(p => p.EmployerId, "c5001fdc-36ad-4846-99cf-cd4852e281eb")
                    .RuleFor(p => p.PostId, f => ++id)
                    .RuleFor(p => p.StartDate, f => f.Date.Future())
                    .RuleFor(p => p.EndDate, f => f.Date.Future())
                    .RuleFor(p => p.ClosingDate, f => f.Date.Future())
                    .RuleFor(p => p.ApplicationInstructions, f => f.Lorem.Paragraph())
                    .RuleFor(p => p.JobDescription, f => f.Lorem.Paragraph())
                    .RuleFor(p => p.JobLocation, f => f.Lorem.Word())
                    .RuleFor(p => p.JobTitle, f => f.Lorem.Text())
                    .RuleFor(p => p.KeyResponsibilities, f => f.Lorem.Paragraph())
                    .RuleFor(p => p.MinRequirements, f => f.Lorem.Paragraph())
                    .RuleFor(p => p.ContactEmail, f => f.Person.Email)
                    .RuleFor(p => p.ContactPerson, f => f.Person.FullName)
                    .RuleFor(p => p.ContactNumber, f => f.Person.Phone)
                    .RuleFor(p => p.DepartmentId, 1)
                    .RuleFor(p => p.FacultyId, 1)
                    .RuleFor(p => p.FullTime, f => f.Random.Bool())
                    .RuleFor(p => p.HourlyRate, f => f.Random.Double(1))
                    .RuleFor(p => p.Internal, f => f.Random.Bool());
            }

            return _postFaker;
        }

    }
}

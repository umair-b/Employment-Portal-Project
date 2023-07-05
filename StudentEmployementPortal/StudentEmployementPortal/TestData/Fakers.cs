using StudentEmployementPortal.Models;
using Bogus;

using StudentEmployementPortal.Data;
using Microsoft.Identity.Client;

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

                string[] PartTimeHours = { "< 2", "2 - 4", "4 - 6", "6 - 8", "8 - 12", "> 12"};

                _postFaker = new Faker<JobPost>()
                    .UseSeed(100)
                    .RuleFor(p => p.EmployerId, "2ac124d7-c58d-4b97-a63b-a0186b71cc00")
                    .RuleFor(p => p.PostId, f => ++id)
                    .RuleFor(p => p.StartDate, f => f.Date.Past())
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
                    .RuleFor(p => p.DepartmentId, f => f.Random.Int(1, 34))
                    .RuleFor(p => p.FacultyId, 1)
                    .RuleFor(p => p.CitizensOnly, f => f.Random.Bool())
                    .RuleFor(p => p.FullTime, f => f.Random.Bool())
                    .RuleFor(p => p.HourlyRate, f => f.Random.Double(1))
                    .RuleFor(p => p.Internal, f => f.Random.Bool())
                    .RuleFor(p => p.PartTimeHours, (f, p) => (bool)p.FullTime ? null : f.PickRandom(PartTimeHours));
            }

            return _postFaker;
        }

    }
}

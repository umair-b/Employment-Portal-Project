using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace StudentEmployementPortal.Utils
{
    public class Enums
    {

        public static IEnumerable<SelectListItem> GetEnumList<T>(IEnumerable<T> excludedVals = null) where T : struct, Enum
        {
            excludedVals ??= Enumerable.Empty<T>();

            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Where(e => !excludedVals.Contains(e))
                .Select(e => new SelectListItem { Text = e.ToString(), Value = e.ToString() });
        }

        public enum JobPostStatus
        {
            Approved,
            Rejected,
            Pending,
            Withdraw
        }

        public enum EmployerStatus
        {
            Approved, 
            Rejected,
            Pending
        }

        public enum Title
        {
            Mr,
            Mrs,
            Miss,
            Dr,
            Prof,
            Other
        }

        public enum BusniessType
        {
            ClosedCorporation,
            StateOwnedEntity,
            PtyLtd,
            SoleProprietorship,
            Partnership,
            NPO
        }

        public enum Gender
        {
            [Display(Name ="Male")]
            Male,
            [Display(Name ="Female")]
            Female,
            [Display(Name ="Non-binary")]
            NonBinary,
            [Display(Name ="Other")]
            Other,
            [Display(Name ="Prefer Not to Say")]
            PreferNotToSay
        }

        public enum YearOfStudy
        {
            [Display(Name ="First Year")]
            FirstYear,
            [Display(Name = "Second Year")]
            SecondYear,
            [Display(Name = "Third Year")]
            ThirdYear,
            [Display(Name = "Honours")]
            Honours,
            [Display(Name = "Masters")]
            Masters,
            [Display(Name = "PhD")]
            PhD
        }

     
        
    }
}

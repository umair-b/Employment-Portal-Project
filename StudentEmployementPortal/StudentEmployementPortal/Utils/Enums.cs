using Humanizer;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
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
                .Select(e => new SelectListItem { Text = e.Humanize(), Value = e.ToString() });
        }


        public enum JobPostStatus
        {
            Approved,
            Rejected,
            Pending,
            Withdrawn,
            Closed
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
            [Display(Name="Closed Corporation")]
            ClosedCorporation,
            [Display(Name ="State Owned Entity")]
            StateOwnedEntity,
            [Display(Name = "Pty Ltd")]
            PtyLtd,
            [Display(Name = "Sole Proprietorship")]
            SoleProprietorship,
            [Display(Name ="Partnership")]
            Partnership,
            [Display(Name = "Non-profit Organization")]
            NPO,
            [Display(Name ="Other")]
            Other
        }

        /*public enum Gender
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
        }*/

        /*public enum YearOfStudy
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
        }*/


        public enum ApplicationStatus
        {
            [Display(Name = "Pending")]
            Pending,
            [Display(Name = "Interview")]
            Interview,
            [Display(Name = "On Hold")]
            OnHold,
            [Display(Name = "Rejected")]
            Rejected,
            [Display(Name = "Appointed")]
            Appointed
        }

    }
}

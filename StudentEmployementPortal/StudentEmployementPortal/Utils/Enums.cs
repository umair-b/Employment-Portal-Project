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
            Closed,
            Queried
        }

        public enum EmployerStatus
        {
            Approved,
            Rejected,
            Pending
        }


        public enum BusniessType
        {
            [Display(Name = "Closed Corporation")]
            ClosedCorporation,
            [Display(Name = "State Owned Entity")]
            StateOwnedEntity,
            [Display(Name = "Pty Ltd")]
            PtyLtd,
            [Display(Name = "Sole Proprietorship")]
            SoleProprietorship,
            [Display(Name = "Partnership")]
            Partnership,
            [Display(Name = "Non-profit Organization")]
            NPO,
            [Display(Name = "Other")]
            Other
        }

        

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
            Appointed,
            Withdrawn
        }

    }
}

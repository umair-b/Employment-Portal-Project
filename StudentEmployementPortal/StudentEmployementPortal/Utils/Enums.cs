using Microsoft.AspNetCore.Mvc.Rendering;

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

        public enum Faculties
        {
            
            CLM,
            EBE,
            HS,
            H,
            S
        }

        
    }
}

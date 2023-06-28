namespace StudentEmployementPortal.Models;

using StudentEmployementPortal.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Application
{
    [Key]
    public int ApplicationId { get; set; }

    [ForeignKey(nameof(Student))]
    public string StudentId { get; set; }
    public Student Student { get; set; }

    public int PostId { get; set; }
    [ForeignKey(nameof(PostId))]
    public JobPost Post { get; set; }
    public IEnumerable<Document>? Documents { get; set; } 
    public Enums.ApplicationStatus ApplicationStatus { get; set; } = Enums.ApplicationStatus.Pending;

/*    public DateTime created = DateTime.Now;
*/    
}


using System.ComponentModel.DataAnnotations.Schema;

namespace WorkingWithEntityFramework.Models;

public class Blog
{
    public int  BLogId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreateDate { get; set; }
[ForeignKey("User")]
    public int  UserId { get; set; }
    // Navigation propterty
    public User User { get; set; }
}
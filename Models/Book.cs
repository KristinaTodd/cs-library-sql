using System.ComponentModel.DataAnnotations;

namespace cs_library_sql.Models
{
  public class Blog
  {
    public int Id { get; set; }
    [Required]
    [MaxLength(20)]
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }
  }
}
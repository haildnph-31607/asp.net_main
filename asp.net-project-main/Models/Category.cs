using System.ComponentModel.DataAnnotations;

namespace asp.net_project_main.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}

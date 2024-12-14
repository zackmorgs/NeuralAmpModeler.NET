using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class NAMModel
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<NAMFile> Files { get; set; }
        public string Url { get; set; } = string.Empty;
    }
}

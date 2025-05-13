using System.ComponentModel.DataAnnotations.Schema; 

namespace LibrLect.Model
{
    public class Books
    {
        public int id { get; set; }
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;

        [ForeignKey("Users")]   
        public int UserId { get; set; }

    }
}   

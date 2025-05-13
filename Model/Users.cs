namespace LibrLect.Model
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;   
        public string Dolgnost { get; set; } = string.Empty;

        public ICollection<Books>? Books { get; set; } = new List<Books>();

    }
}

namespace BugIt.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Project> Projects { get; set; }
        public List<Todo> Todo { get; set; }
    }
}

namespace BugIt.Model
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public List<Todo> Todos { get; set; }
    }
}

namespace BugIt.Model
{
    public class Todo
    {
        public int TodoId { get; set; }
        public int ProjetId { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Enums.Enums.Types Type { get; set; }
        public Enums.Enums.Status Status { get; set; }
        public Enums.Enums.Priority Priority { get; set; }
        public DateTime Created { get; set; }
        public DateTime? AssignedDate { get; set; }
        public DateTime? DoneDate { get; set; }
    }


}
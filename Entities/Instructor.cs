namespace EFCore07.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int? OfficeId { get; set; }  
        public Office? office { get; set; }

        public ICollection<Section> Sections {  get; set; } = new List<Section>();
    }
}

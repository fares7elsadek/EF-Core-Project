namespace EFCore07.Entities
{
    public class Enrollment
    {
        public int SectionId {  get; set;}
        public int ParticpantId { get; set;}

        public Particpants Particpant { get; set; } = null!;
        public Section ParticpantSection { get; set;} =null!;
    }
}

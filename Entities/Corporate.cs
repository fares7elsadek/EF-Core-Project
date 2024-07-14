namespace EFCore07.Entities
{
    public class Corporate: Particpants
    {
        public string Company { get; set; }
        public string JopTitle { get; set; }

        public override string ToString()
        {
            return $"{{ {FName} {LName} | {JopTitle} @ {Company} }}";
        }
    }
}

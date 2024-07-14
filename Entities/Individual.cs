namespace EFCore07.Entities
{
    public class Individual: Particpants
    {
        public string University { get; set; }
        public int YearOfGradutaion { get; set; }
        public bool isIntern { get; set; }

        public override string ToString()
        {
            return $"{{ {FName} {LName} | Graduated at {YearOfGradutaion} From {University} }}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore07.Entities
{
    public class Particpants
    {
        public int Id { get; set; }

        public string FName { get; set; }
        public string LName { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();
    }
}

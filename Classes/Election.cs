using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code_along_7_november.Classes
{
    public class Election
    {
        public Guid Id { get; set; } = new Guid();
        public List<Vote> Votes { get; set; } = new List<Vote>();
        public List<Alternative> Alternatives { get; set; } = new List<Alternative>();
    }
}
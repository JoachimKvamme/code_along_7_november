using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code_along_7_november.Classes
{
    public class Vote
    {
        public Guid Id { get; init; } = new Guid();
        public required ElectionOption ChosenAlternative { get; set; }
    }
}
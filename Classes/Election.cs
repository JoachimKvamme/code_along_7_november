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
        public List<ElectionOption> ElectionOptions { get; set; } = new List<ElectionOption>();

        public Election( List<ElectionOption> electionOptions)
        {
            if(electionOptions.Count <= 1)
                throw new ArgumentException("Et valg trenger minst to alternativer");

            ElectionOptions = electionOptions;
            Id = Guid.NewGuid();
        }
    }
}
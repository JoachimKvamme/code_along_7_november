using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code_along_7_november.Classes
{
    public class ElectionOption
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ElectionOption(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }

    }
}
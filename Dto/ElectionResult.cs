using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using code_along_7_november.Classes;

namespace code_along_7_november.Dto
{
    public class ElectionResult
    {

        public List<(ElectionOption, int)> Result { get; set; } = new List<(ElectionOption, int)>();
    }
}
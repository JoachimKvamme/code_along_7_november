using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using code_along_7_november.Classes;
using code_along_7_november.Dto;

namespace code_along_7_november.Interfaces
{
    public interface IVotingService
    {
        Election CreateElection();
        ElectionOption[] GetAlternatives(Guid id);
        void GiveVote(Vote vote);
        ElectionResult GetResult(Guid id);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using code_along_7_november.Classes;
using code_along_7_november.Dto;
using code_along_7_november.Interfaces;

namespace code_along_7_november.Services
{
    public class VotingService : IVotingService
    {
        public Election CreateElection()
        {
            throw new NotImplementedException();
        }

        public Alternatives[] GetAlternatives(Guid id)
        {
            throw new NotImplementedException();
        }

        public ElectionResult GetResult(Guid id)
        {
            throw new NotImplementedException();
        }

        public void GiveVote(Vote vote)
        {
            throw new NotImplementedException();
        }
    }
}
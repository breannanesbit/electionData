using System;
using System.Collections.Generic;

namespace Shared
{
    public partial class Tabulationresult
    {
        public int Id { get; set; }
        public int? CandidateOieId { get; set; }
        public string? VotingRound { get; set; }
        public int? Votesreceived { get; set; }
        public decimal? Pctvotesforoffice { get; set; }

        public virtual CandidateOie? CandidateOie { get; set; }
    }
}

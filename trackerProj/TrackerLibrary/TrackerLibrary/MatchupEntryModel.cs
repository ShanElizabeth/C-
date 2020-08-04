using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {


        /// <summary>
        /// represents one team in the matachup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this particular team
        /// </summary>
        public double Score { get; set;}

        /// <summary>
        /// represents which team they came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        

    }
}

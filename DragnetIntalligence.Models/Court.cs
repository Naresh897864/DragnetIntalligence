using System;
using System.Collections.Generic;
using System.Text;

namespace DragnetIntalligence.Models
{
    public class InsertCourt
    {
        public string CNRNumber { get; set; }
        public string FilingDate { get; set; }
        public string RegisterDate { get; set; }
        public string PetitionTypeId { get; set; }
        public string PetitionNo { get; set; }
        public string DivisionBenchId { get; set; }
        public string PetitionerName { get; set; }
        public string PetitionerCounsel { get; set; }
        public string RespondentName { get; set; }
        public string RespondentAdvocate { get; set; }
        public string BriefFacts { get; set; }    
        //public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }     
    }
}

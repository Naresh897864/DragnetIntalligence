using Dragnet;
using Dragnet.Constants;
using Dragnet.DataObjects;
using DragnetIntalligence.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DragnetIntalligence.Models;

namespace DragnetIntalligence.RepositoryManagement
{
    public class court : Dragnet.CommonMethods, ICourt
    {
       
        DBManager DBManager = new DBManager();
        public bool InsertCourt(InsertCourt court)
        {
            

            try
            {
                string qry = string.Format(@"CC_SaveCourtCases {0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                   string.IsNullOrEmpty(court.CNRNumber) ? "null" : string.Format("{0}", court.CNRNumber),
                   string.IsNullOrEmpty(court.FilingDate) ? "null" : string.Format("'{0}'", court.FilingDate),
                   string.IsNullOrEmpty(court.RegisterDate) ? "null" : string.Format("'{0}'", court.RegisterDate),
                   string.IsNullOrEmpty(court.PetitionTypeId) ? "null" : string.Format("'{0}'", court.PetitionTypeId),
                   string.IsNullOrEmpty(court.PetitionNo) ? "null" : string.Format("'{0}'", court.PetitionNo),
                   string.IsNullOrEmpty(court.DivisionBenchId) ? "null" : string.Format("{0}", court.DivisionBenchId),
                   string.IsNullOrEmpty(court.PetitionerName) ? "null" : string.Format("'{0}'", court.PetitionerName),
                   string.IsNullOrEmpty(court.PetitionerCounsel) ? "null" : string.Format("'{0}'", court.PetitionerCounsel),
                   string.IsNullOrEmpty(court.RespondentName) ? "null" : string.Format("'{0}'", court.RespondentName),
                   string.IsNullOrEmpty(court.RespondentAdvocate) ? "null" : string.Format("'{0}'", court.RespondentAdvocate),
                   string.IsNullOrEmpty(court.BriefFacts) ? "null" : string.Format("'{0}'", court.BriefFacts),
                   string.IsNullOrEmpty(court.CreatedBy) ? "null" : string.Format("'{0}'", court.CreatedBy));
                DataSet ds = DBManager.GetDataSet(qry);

                if (ds!=null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
               
            }
            catch (Exception ex)
            {
               
                return false;

            }
        }
    }
}

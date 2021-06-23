using Dragnet.Constants;
using Dragnet.DataObjects;
using Dragnet.IRepository;
using Dragnet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dragnet.Repository
{
    public class HomeManagement : CommonMethods, IHome
    {
        IDBManager dbManager = null;
        public List<Home> GetActivitiesDailyCount()
        {

            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Home home = null;
            List<Home> ActivityDailyCountList = new List<Home>();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(3);
                dbManager.AddParameters(0, "@Date", GetDBNullOrValue("2019-05-23"), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(1, "@RoleId", GetDBNullOrValue("2010"), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(2, "@OrgId", GetDBNullOrValue(0), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(3, "@RegionId", GetDBNullOrValue(null), ParameterDirection.Input, DaoConstants.InParamSize);
                dr = dbManager.ExecuteReader(CommandType.StoredProcedure, "GetActivitiesEnteredCount");
                while (dr.Read())
                {
                    home = new Home()
                    {
                       
                        DailyCount = dr["dailycount"] == DBNull.Value ? " " : dr["dailycount"].ToString(),
                        ContinousCount = dr["continuouscount"] == DBNull.Value ? " " : dr["continuouscount"].ToString(),
                        PeriscopeCount = dr["periscopecount"] == DBNull.Value ? " " : dr["periscopecount"].ToString(),
                        VipCount = dr["vipcount"] == DBNull.Value ? " " : dr["vipcount"].ToString(),
                        TotalCount = dr["totalcount"] == DBNull.Value ? " " : dr["totalcount"].ToString(),
                    };
                    ActivityDailyCountList.Add(home);
                }
                dr.Close();
                return ActivityDailyCountList;

            }
            catch (Exception ex)
            {
                if (dr != null)
                    dr.Close();
                return null;

            }
            finally
            {
                if (dr != null)
                    dr.Close();
                dbManager.Dispose();
                dbManager = null;
            }
        }

        public List<Home> GetActivitiesMonthlyCount()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Home home = null;
            List<Home> ActivityMonthlyCountList = new List<Home>();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(3);
                dbManager.AddParameters(0, "@Month", GetDBNullOrValue("2019-01-16"), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(1, "@RoleId", GetDBNullOrValue("2"), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(2, "@OrgId", GetDBNullOrValue("26"), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(3, "@RegionId", GetDBNullOrValue("7"), ParameterDirection.Input, DaoConstants.InParamSize);
                dr = dbManager.ExecuteReader(CommandType.StoredProcedure, "GetActivitiesEnteredCount");
                while (dr.Read())
                {
                    home = new Home()
                    {

                        DailyCount = dr["dailycount"] == DBNull.Value ? " " : dr["dailycount"].ToString(),
                        ContinousCount = dr["continuouscount"] == DBNull.Value ? " " : dr["continuouscount"].ToString(),
                        PeriscopeCount = dr["periscopecount"] == DBNull.Value ? " " : dr["periscopecount"].ToString(),
                        VipCount = dr["vipcount"] == DBNull.Value ? " " : dr["vipcount"].ToString(),
                        TotalCount = dr["totalcount"] == DBNull.Value ? " " : dr["totalcount"].ToString(),
                    };
                    ActivityMonthlyCountList.Add(home);
                }
                dr.Close();
                return ActivityMonthlyCountList;

            }
            catch (Exception ex)
            {
                if (dr != null)
                    dr.Close();
                return null;

            }
            finally
            {
                if (dr != null)
                    dr.Close();
                dbManager.Dispose();
                dbManager = null;
            }
        }

        public List<Home> GetMessagesCount()
        {

            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Home home = null;
            List<Home> MessagesDashBoardCountList = new List<Home>();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(2);
                dbManager.AddParameters(0, "@Date", GetDBNullOrValue("2019-9-04"), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(1, "@UserId", GetDBNullOrValue("dspkmm"), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(2, "@RoleId", GetDBNullOrValue(null), ParameterDirection.Input, DaoConstants.InParamSize);
                
                dr = dbManager.ExecuteReader(CommandType.StoredProcedure, "GetMessagesCountfordashboard");
                while (dr.Read())
                {
                    home = new Home()
                    {

                        MessagesReceived = dr["MessagesReceived"] == DBNull.Value ? " " : dr["MessagesReceived"].ToString(),
                        MessagesViewed = dr["MessagesViewed"] == DBNull.Value ? " " : dr["MessagesViewed"].ToString(),
                        MessagesSent = dr["MessagesSent"] == DBNull.Value ? " " : dr["MessagesSent"].ToString(),
                        MessagesSentViewed = dr["MessagesSentViewed"] == DBNull.Value ? " " : dr["MessagesSentViewed"].ToString()
                      
                    };
                    MessagesDashBoardCountList.Add(home);
                }
                dr.Close();
                return MessagesDashBoardCountList;

            }
            catch (Exception ex)
            {
                if (dr != null)
                    dr.Close();
                return null;

            }
            finally
            {
                if (dr != null)
                    dr.Close();
                dbManager.Dispose();
                dbManager = null;
            }
        }
    }
}

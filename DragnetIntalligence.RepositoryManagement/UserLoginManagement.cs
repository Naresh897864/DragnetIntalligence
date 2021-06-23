
using Dragnet.Constants;
using Dragnet.DataObjects;
using Dragnet.IRepository;
using Dragnet.Models;
using System;
using System.Collections.Generic;
using System.Data;




namespace Dragnet.Repository
{
    public class UserLoginManagement : CommonMethods, IUserLogin
    {
        IDBManager dbManager = null;
        public List<UserLogin> GetAllUSers()
        {
            if (dbManager == null)
                dbManager = new DBManager();

            IDataReader dr = null;

            UserLogin userLogin = null;
            List<UserLogin> UserList = new List<UserLogin>();

            try
            {
                dbManager.Open();

                dr = dbManager.ExecuteReader(CommandType.StoredProcedure, "LoginCheckNew");

                while (dr.Read())
                {

                    userLogin = new UserLogin()
                    {
                        /* userLogins = new UserLogin()
                         {
                          *//*   Id = dr["DistrictCode"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["DistrictCode"]),
                             Name = dr["DistrictName"] == DBNull.Value ? default(string) : dr["DistrictName"].ToString()*//*
                         },*/
                        /*                            TotNoOfVillages = dr["TotalVillages"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["TotalVillages"]),
                                                    OneThirdVillages = dr["OneByThirdVillages"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["OneByThirdVillages"]),
                                                    NoOfVillPendInVro = dr["VillagesCompByVro"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["VillagesCompByVro"]),
                                                    NoOfVillPendInRiDt = dr["VillagesCompByRiDtMs"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["VillagesCompByRiDtMs"]),
                                                    NoOfVillPendInTahLogin = dr["VillagesCompByTah"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["VillagesCompByTah"]),
                                                    NoOfVillPendInRdoLogin = dr["VillagesCompByRdo"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["VillagesCompByRdo"]),
                                                    TotVillAppByRDO = dr["TotalApproved"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["TotalApproved"]),
                                                    TotVillProcessed = dr["TotalVillagesProcessed"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["TotalVillagesProcessed"]),
                                                    PercOnOneThirdOfProcVill = dr["OneThirdTotalVillagesProcessed"] == DBNull.Value ? default(double) : Convert.ToDouble(dr["OneThirdTotalVillagesProcessed"]),
                                                    PercOnTotVill = dr["TotalVillagesPerc"] == DBNull.Value ? default(double) : Convert.ToDouble(dr["TotalVillagesPerc"])*/
                    };
                    UserList.Add(userLogin);
                }
                dr.Close();




                return null;
            }

            catch (Exception ex)
            {
                //   ErrorLog errorLog = new ErrorLog()
                /*     {
                         ErrorDescription = ex.Message.ToString(),
                         LoginUserId = "",
                         //DistrictId = DistrictCode,
                         // MandalId = MandalCode,
                         // VillageId = VillageCode,
                         ProformaId = 4
                     };*/
                ///  LogErrorRepo logErrorRepo = new LogErrorRepo();
                //  logErrorRepo.InsertErrorLog(errorLog);
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



        public List<UserLogin> Login(string UserId, string Password)
        {

            if (dbManager == null)
                dbManager = new DBManager();

            IDataReader dr = null;

            UserLogin userLogin = null;
            List<UserLogin> UserList = new List<UserLogin>();

            try
            {
                dbManager.Open();
                dbManager.CreateParameters(2);
                dbManager.AddParameters(0, "Userid", GetDBNullOrValue(UserId), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(1, "password", GetDBNullOrValue(Password), ParameterDirection.Input, DaoConstants.InParamSize);

                dr = dbManager.ExecuteReader(CommandType.StoredProcedure, "LoginCheck_New");

                while (dr.Read())
                {

                   userLogin = new UserLogin()
                    {
                        //UserName = dr["UserName"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["UserName"]),
                        UserId = dr["User_Id"] == DBNull.Value ? "": dr["User_Id"].ToString(),
                        UserName = dr["UserName"] == DBNull.Value ? "" : dr["UserName"].ToString(),
                        Type = dr["type"] == DBNull.Value ? "" : dr["type"].ToString(),
                        Features = dr["Features"] == DBNull.Value ? "" : dr["Features"].ToString(),
                        RoleId = dr["RoleId"] == DBNull.Value ? "" : dr["RoleId"].ToString(),
                        WorkPlaceMasterId = dr["WorkPlaceMasterId"] == DBNull.Value ? "" : dr["WorkPlaceMasterId"].ToString(),
                        DistrictId = dr["DistrictID"] == DBNull.Value ? "" : dr["DistrictID"].ToString(),
                        DistrictName = dr["DistrictName"] == DBNull.Value ? "" : dr["DistrictName"].ToString(),
                        OrganizationId = dr["OrganizationID"] == DBNull.Value ? "" : dr["OrganizationID"].ToString(),
                        RegionId = dr["Regionid"] == DBNull.Value ? "" : dr["Regionid"].ToString(),
                        PasswordEncryption = dr["PasswordEncryption"] == DBNull.Value ? "" : dr["PasswordEncryption"].ToString(),
                        FailedPasswordCount = dr["FailedPwdAttemptCount"] == DBNull.Value ? "" : dr["FailedPwdAttemptCount"].ToString(),
                        DistrictShortName = dr["ShortNameDistrict"] == DBNull.Value ? "" : dr["ShortNameDistrict"].ToString(),
                        DesignationId = dr["DesignationId"] == DBNull.Value ? "" : dr["DesignationId"].ToString(),
                        SPLHYDId = dr["SPLHYDId"] == DBNull.Value ? "" : dr["SPLHYDId"].ToString()
                    };
                    UserList.Add(userLogin);
                }
                dr.Close();
                return UserList;
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

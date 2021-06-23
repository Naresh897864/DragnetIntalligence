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
    public class OrganizationManagement : CommonMethods, IOrganization
    {
        IDBManager dbManager = null;

        public List<Organization> GetOrganizationLevels()
        {
            if (dbManager == null)
                dbManager = new DBManager();
            

            IDataReader dr = null;

            Organization org = null;
            List<Organization> organizationList = new List<Organization>();
            try
            {
                dbManager.Open();
               dr = dbManager.ExecuteReader(CommandType.Text, "select Id,LevelofOrganizationName  from LevelofOrganization");
                while (dr.Read())
                {
                    org = new Organization()
                    {
                        Id = dr["Id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["Id"]),
                        LevelOfOrganization = dr["LevelofOrganizationName"] == DBNull.Value ? " " : dr["LevelofOrganizationName"].ToString()
                    };
                    organizationList.Add(org);
                }
                dr.Close();
                return organizationList;
               
            }
            catch(Exception ex)
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

        public List<OrgTypes> GetOrgtypes()
        {
            if (dbManager == null)
                dbManager = new DBManager();

            string actionname = "Organization";
            IDataReader dr = null;

            OrgTypes org = null;
            List<OrgTypes> OrgTypeList = new List<OrgTypes>();
            try
            {
                dbManager.Open();
               
                dbManager.CreateParameters(2);
                dbManager.AddParameters(0, "@ID", GetDBNullOrValue(1), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(1, "@LookupType", GetDBNullOrValue(actionname), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(2, "@EventTypeId", GetDBNullOrValue(null), ParameterDirection.Input, DaoConstants.InParamSize);
                dr = dbManager.ExecuteReader(CommandType.StoredProcedure, "GetLookupValues");
                while (dr.Read())
                {
                    org = new OrgTypes()
                    {
                        Id = dr["ID"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["ID"]),
                        OrgType = dr["Type"] == DBNull.Value ? " ": dr["Type"].ToString(),
                        ParentType = dr["ParentType"] == DBNull.Value ? " ": dr["ParentType"].ToString(),
                    };
                    OrgTypeList.Add(org);
                }
                dr.Close();
                return OrgTypeList;

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

        public List<Organization> GetDistricts()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Organization org = null;
            List<Organization> DistrictList = new List<Organization>();
            try
            {
                dbManager.Open();
            dr =    dbManager.ExecuteReader(CommandType.Text, "select id,District_commissionerate,Tracking  from  District_Commissionerate");
                while (dr.Read())
                {
                    org = new Organization()
                    {
                        DistrictID = dr["id"] == DBNull.Value ? " " : dr["id"].ToString(),
                        District_commissionerate = dr["District_commissionerate"] == DBNull.Value ? " " : dr["District_commissionerate"].ToString(),
                        Tracking = dr["Tracking"] == DBNull.Value ? " " : dr["Tracking"].ToString()
                        
                    };
                    DistrictList.Add(org);
                }
                dr.Close();
                return DistrictList;

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

        public List<Organization> GetFronatalOrg()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Organization org = null;
            List<Organization> FrontalOrgList = new List<Organization>();
            try
            {
                dbManager.Open();
               dr =  dbManager.ExecuteReader(CommandType.Text, "select id,OrganizationName from OrganizationDetails order by OrganizationName");
                while (dr.Read())
                {
                    org = new Organization()
                    {
                        orgId = dr["id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["id"]),
                        orgName = dr["OrganizationName"] == DBNull.Value ? " " : dr["OrganizationName"].ToString()
                    };
                    FrontalOrgList.Add(org);
                }
                dr.Close();
                return FrontalOrgList;

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

        public List<Organization> GetOrgStatus()
        {

            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Organization org = null;
            List<Organization> OrgStatusList = new List<Organization>();
            try
            {
                dbManager.Open();
             dr =   dbManager.ExecuteReader(CommandType.Text, "select id,StatusName from OrganizationStatus");
                while (dr.Read())
                {
                    org = new Organization()
                    {
                        StatusId = dr["id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["id"]),
                        StatusName = dr["StatusName"] == DBNull.Value ? " " : dr["StatusName"].ToString()
                    };
                    OrgStatusList.Add(org);
                }
                dr.Close();
                return OrgStatusList;

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

        public bool InsertOrganizationDetails(InsertOrganizationDetails org)
        {
            if (dbManager == null)
                dbManager = new DBManager();

            try
            {
                dbManager.Open();
                int i  = dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "Sp_SaveOrgDetails");
                dbManager.CreateParameters(14);
                dbManager.AddParameters(0, "@Orgtype", GetDBNullOrValue(org.TypeOfOrgId), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(1, "@orgname", GetDBNullOrValue(org.OrganizationName), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(2, "@shortName", GetDBNullOrValue(org.OrganizationShortName), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(3, "@levelodorg", GetDBNullOrValue(org.LevelOfOrganizationId), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(4, "@frontalorg", GetDBNullOrValue(org.ParentOrganizationId), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(5, "@distid", GetDBNullOrValue(org.OrgId), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(6, "@founderNAme", GetDBNullOrValue(org.FounderName), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(7, "@formationDate", GetDBNullOrValue(org.FoundationDate), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(8, "@orgstatus", GetDBNullOrValue(org.OrgStatusId), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(9, "@location", GetDBNullOrValue(org.Location), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(10, "@address", GetDBNullOrValue(org.OrgAddress), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(11, "@psid", GetDBNullOrValue(org.Psid), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(12, "@Mob", GetDBNullOrValue(org.OrgMobileNo), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(13, "@emailid", GetDBNullOrValue(org), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.AddParameters(14, "@createdby", GetDBNullOrValue(org.CreatedBy), ParameterDirection.Input, DaoConstants.InParamSize);
                dbManager.Close();
                if (i >= 1)
                {

                    return true;

                }
                else
                {

                    return false;
                }
            }
            catch(Exception ex)
            {
                if (dbManager != null)
                    dbManager.Close();
                return false;

            }
        }

      
    }
}

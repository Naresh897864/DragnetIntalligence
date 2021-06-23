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
    public class PersonManagement : CommonMethods, IPerson
    {
        IDBManager dbManager = null;
        public List<Person> GetCommiteLevel()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Person person = null;
            List<Person> CommitteeLevelList = new List<Person>();
            try
            {
                dbManager.Open();
                dr = dbManager.ExecuteReader(CommandType.Text, "select Id ,LevelofOrganizationName from LevelofOrganization order by LevelofOrganizationName");
                while (dr.Read())
                {
                    person = new Person()
                    {
                        ID = dr["Id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["Id"]),
                        OccupationName = dr["OccupationName"] == DBNull.Value ? " " : dr["OccupationName"].ToString(),
                        OccuAbbrevation = dr["OccupationAbbrevation"] == DBNull.Value ? " " : dr["OccupationAbbrevation"].ToString(),
                    };
                    CommitteeLevelList.Add(person);
                }
                dr.Close();
                return CommitteeLevelList;

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

        public List<Person> GetCommitteeCadre()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Person person = null;
            List<Person> CommitteeCadreList = new List<Person>();
            try
            {
                dbManager.Open();
                dr = dbManager.ExecuteReader(CommandType.Text, "select Id,committeeCadreName from committeecadre order by committeeCadreName");
                while (dr.Read())
                {
                    person = new Person()
                    {
                        ID = dr["Id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["Id"]),
                        CommitteCadreName = dr["committeeCadreName"] == DBNull.Value ? " " : dr["committeeCadreName"].ToString()
                      
                    };
                    CommitteeCadreList.Add(person);
                }
                dr.Close();
                return CommitteeCadreList;

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

        public List<Person> GetDistricts()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Person person = null;
            List<Person> DistrictsList = new List<Person>();
            try
            {
                dbManager.Open();
                dr = dbManager.ExecuteReader(CommandType.Text, "select id,District_commissionerate,Tracking  from  District_Commissionerate");
                while (dr.Read())
                {
                    person = new Person()
                    {
                        ID = dr["Id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["Id"]),
                        DistrictCommissionerate = dr["District_commissionerate"] == DBNull.Value ? " " : dr["District_commissionerate"].ToString(),
                        Tracking = dr["Tracking"] == DBNull.Value ? " " : dr["Tracking"].ToString()

                    };
                    DistrictsList.Add(person);
                }
                dr.Close();
                return DistrictsList;

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

        public List<Person> GetEducationQualification()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Person person = null;
            List<Person> EduQuaList = new List<Person>();
            try
            {
                dbManager.Open();
                dr = dbManager.ExecuteReader(CommandType.Text, "select * from EducationQualification order by EducationQualification");
                while (dr.Read())
                {
                    person = new Person()
                    {
                        ID = dr["Id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["Id"]),
                        EducationQualification = dr["EducationQualification"] == DBNull.Value ? " " : dr["EducationQualification"].ToString()

                    };
                    EduQuaList.Add(person);
                }
                dr.Close();
                return EduQuaList;

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

        public List<Person> GetMarialStatus()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Person person = null;
            List<Person> MaritalStatusList = new List<Person>();
            try
            {
                dbManager.Open();
                dr = dbManager.ExecuteReader(CommandType.Text, "select Id,MaritalStatusName from PersonMaritalStatus");
                while (dr.Read())
                {
                    person = new Person()
                    {
                        ID = dr["Id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["Id"]),
                        MaritalStatusName = dr["MaritalStatusName"] == DBNull.Value ? " " : dr["MaritalStatusName"].ToString()

                    };
                    MaritalStatusList.Add(person);
                }
                dr.Close();
                return MaritalStatusList;

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

        public List<Person> GetOccupation()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetOrgName()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Person person = null;
            List<Person> OrgNameList = new List<Person>();
            try
            {
                dbManager.Open();
                dr = dbManager.ExecuteReader(CommandType.Text, "select Id,OrganizationName from OrganizationDetails order by OrganizationName");
                while (dr.Read())
                {
                    person = new Person()
                    {
                        ID = dr["Id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["Id"]),
                        OrgName = dr["OrganizationName"] == DBNull.Value ? " " : dr["OrganizationName"].ToString()

                    };
                    OrgNameList.Add(person);
                }
                dr.Close();
                return OrgNameList;

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

        public List<Person> GetOrgTypes()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Person person = null;
            List<Person> OrgTypeList = new List<Person>();
            try
            {
                dbManager.Open();
                dr = dbManager.ExecuteReader(CommandType.StoredProcedure, "getMasters_addActivity");
                while (dr.Read())
                {
                    person = new Person()
                    {
                        ID = dr["Id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["Id"]),
                        TypeofOrganization = dr["TypeofOrganization"] == DBNull.Value ? " " : dr["Religion"].ToString()

                    };
                    OrgTypeList.Add(person);
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

        public List<Person> GetPersonType()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Person person = null;
            List<Person> personTypeList = new List<Person>();
            try
            {
                dbManager.Open();
                dr = dbManager.ExecuteReader(CommandType.Text, "select Id,PersonType from PersonTypes order by PersonType");
                while (dr.Read())
                {
                    person = new Person()
                    {
                        ID = dr["Id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["Id"]),
                        PersonType = dr["PersonType"] == DBNull.Value ? " " : dr["PersonType"].ToString()
                     
                    };
                    personTypeList.Add(person);
                }
                dr.Close();
                return personTypeList;

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

        public List<Person> GetPoliceStations()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Person person = null;
            List<Person> PoliceStationList = new List<Person>();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(1);
                dbManager.AddParameters(0, "@orgID", GetDBNullOrValue(1), ParameterDirection.Input, DaoConstants.InParamSize);
                dr = dbManager.ExecuteReader(CommandType.StoredProcedure, "SelectPSByOrgID");
                while (dr.Read())
                {
                    person = new Person()
                    {
                        ID = dr["Id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["Id"]),
                        PoliceStation = dr["PoliceStation"] == DBNull.Value ? " " : dr["PersonType"].ToString()

                    };
                    PoliceStationList.Add(person);
                }
                dr.Close();
                return PoliceStationList;

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

        public List<Person> GetReligion()
        {
            if (dbManager == null)
                dbManager = new DBManager();


            IDataReader dr = null;

            Person person = null;
            List<Person> ReligionList = new List<Person>();
            try
            {
                dbManager.Open();
                dr = dbManager.ExecuteReader(CommandType.Text, "select Id,Religion from Religions order by Religion");
                while (dr.Read())
                {
                    person = new Person()
                    {
                        ID = dr["Id"] == DBNull.Value ? default(int) : Convert.ToInt32(dr["Id"]),
                        Religion = dr["Religion"] == DBNull.Value ? " " : dr["Religion"].ToString()

                    };
                    ReligionList.Add(person);
                }
                dr.Close();
                return ReligionList;

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

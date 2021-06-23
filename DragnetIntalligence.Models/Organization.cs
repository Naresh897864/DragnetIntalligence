using System;
using System.Collections.Generic;
using System.Text;

namespace Dragnet.Models
{
   public class Organization
    {
        public int Id { get; set; }
        public string  LevelOfOrganization { get; set; }


        /*************** District Commissionerate*************/
        public string DistrictID { get; set; }
        public string District_commissionerate { get; set; }
        public string Tracking { get; set; }
       

        /*************** Frontal Organization*************/
        public int orgId  { get; set; }
        public string orgName  { get; set; }

        /*************** Organization Status*************/
        public int StatusId { get; set; }
        public string  StatusName { get; set; }

    }
    public class OrgTypes
    {
        public int Id { get; set; }
        public string OrgType { get; set; }
        public string ParentType { get; set; }
    }

    public class InsertOrganizationDetails
    {

        public int Id { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationShortName { get; set; }
        public string IsChildOrganization { get; set; }
        public int ParentOrganizationId { get; set; }
        public string FounderName { get; set; }
        public string FoundationDate { get; set; }
        public int LevelOfOrganizationId { get; set; }
        public string OrgMobileNo { get; set; }
        public int TypeOfOrgId { get; set; }
        public string OrgEmailId { get; set; }
        public int Psid { get; set; }
        public string Location { get; set; }
        public int  OrgStatusId { get; set; }
        public string OrgAddress { get; set; }
        public string FoundationYear { get; set; }
        public string PoliceStation { get; set; }
        public int PartyId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public int  OrgId { get; set; }



    }
}

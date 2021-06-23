using Dragnet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dragnet.IRepository
{
   public interface IOrganization
    {
        public List<Organization> GetOrganizationLevels();
        public List<OrgTypes> GetOrgtypes();
        public List<Organization> GetDistricts();
        public List<Organization> GetFronatalOrg();
        public List<Organization> GetOrgStatus();

        public bool InsertOrganizationDetails(InsertOrganizationDetails org);

    }
}

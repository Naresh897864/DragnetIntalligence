using System;
using System.Collections.Generic;
using System.Text;

namespace Dragnet.Models
{
   public class UserLogin
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Type { get; set; }
        public string Features { get; set; }
        public string SBInt { get; set; }
        public string RoleId { get; set; }
        public string WorkPlaceMasterId { get; set; }
        public string DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string OrganizationId { get; set; }
        public string RegionId { get; set; }
        public string PasswordEncryption { get; set; }
        public string FailedPasswordCount { get; set; }
        public string DistrictShortName { get; set; }
        public string DesignationId { get; set; }
        public string SPLHYDId { get; set; }
    }
}

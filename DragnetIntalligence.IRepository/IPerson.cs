using Dragnet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dragnet.IRepository
{
   public interface IPerson
    {
        public List<Person> GetOccupation();

        public List<Person> GetPersonType();

        public List<Person> GetReligion();

        public List<Person> GetOrgName();

        public List<Person> GetCommitteeCadre();

        public List<Person> GetCommiteLevel();

        public List<Person> GetPoliceStations();

        public List<Person> GetMarialStatus();

        public List<Person> GetOrgTypes();

        public List<Person> GetEducationQualification();

        public List<Person> GetDistricts();

    }
}

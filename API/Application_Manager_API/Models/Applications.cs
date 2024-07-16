using System;
using System.ComponentModel.DataAnnotations;

namespace Application_Manager_API.Models
{
    public class Applications
    {
        public int JobControl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }

        // Override Equals and GetHashCode
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Applications))
                return false;

            var other = (Applications)obj;
            return JobControl == other.JobControl
                && FirstName == other.FirstName
                && LastName == other.LastName
                && HomeAddress == other.HomeAddress;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(JobControl, FirstName, LastName, HomeAddress);
        }
    }
}
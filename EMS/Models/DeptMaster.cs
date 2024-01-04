using System;
using System.Collections.Generic;

namespace EMS.Models
{
    public partial class DeptMaster
    {
        public DeptMaster()
        {
            EmpProfiles = new HashSet<EmpProfile>();
        }

        public int DeptCode { get; set; }
        public string? DeptName { get; set; }

        public virtual ICollection<EmpProfile> EmpProfiles { get; set; }
    }
}

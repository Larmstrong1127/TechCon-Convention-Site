using LandonWebsite06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandonWebsite06.Services
{
        public interface ICompanyData
        {
            List<Companies> AllCompanies { get; set; }
        }
   
}

using LandonWebsite06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandonWebsite06.Services
{
    public class CompanyData : ICompanyData
    {
        public List<Companies> AllCompanies { get; set; }




        public CompanyData()
        {
            AllCompanies = new List<Companies>();
            Method();
            
        }

        public void Method()
        {
            AllCompanies.Add(new Companies() { companyName = "AMD", ID = 123, boothnumber = 210 });
            AllCompanies.Add(new Companies() { companyName = "Blizzard", ID = 124, boothnumber = 221});
            AllCompanies.Add(new Companies() { companyName = "Nintendo", ID = 125, boothnumber = 232});
            AllCompanies.Add(new Companies() { companyName = "Microsoft", ID = 126, boothnumber = 243});
            AllCompanies.Add(new Companies() { companyName = "Epic Games", ID = 127, boothnumber = 254});
            AllCompanies.Add(new Companies() { companyName = "The Void", ID = 128, boothnumber = 254});

        }
    }

    
}

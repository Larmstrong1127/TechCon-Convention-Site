using LandonWebsite06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandonWebsite06.Services
{
    public class SpecialGuestData
    {

        public List<SpecialGuests> AllSpecialGuests { get; set; }




        public SpecialGuestData()
        {
            AllSpecialGuests = new List<SpecialGuests>();
            Method();

        }

        public void Method()
        {
            AllSpecialGuests.Add(new SpecialGuests() { guestName = "Guest1", ID = 900});
            AllSpecialGuests.Add(new SpecialGuests() { guestName = "Guest2", ID = 901 });
            AllSpecialGuests.Add(new SpecialGuests() { guestName = "Guest3", ID = 902 });
            AllSpecialGuests.Add(new SpecialGuests() { guestName = "Guest4", ID = 903 });
            AllSpecialGuests.Add(new SpecialGuests() { guestName = "Guest5", ID = 904 });
            AllSpecialGuests.Add(new SpecialGuests() { guestName = "Guest6", ID = 905 });

        }
    }
}

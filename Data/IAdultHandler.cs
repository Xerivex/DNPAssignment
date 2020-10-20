using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNPAssignment.Models;

namespace DNPAssignment.Data {
    public interface IAdultHandler {
        IList<Adult> AquireAdults();
        void AddAdult(Adult adult);
        void removeAdult(int adultID);
        void updateAdult(Adult adult);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNPAssignment.Models;

namespace DNPAssignment.Data {
    public interface IUserService {
        User validateUser(string userName, string password);
        void registerUser(string username, string password);
    }
}

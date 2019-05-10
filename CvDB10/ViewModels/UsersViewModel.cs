using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvDB10.ViewModels
{
    public class UsersViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }
}

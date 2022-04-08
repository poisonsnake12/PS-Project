using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public String username
        { get; set; }
        public String password
        { get; set; }
        public String facultyNumber
        { get; set; }
        public DateTime dateCreated
        { get; set; }
        public DateTime validUntil
        { get; set; }
        public int userRole
        { get; set; }
}
}

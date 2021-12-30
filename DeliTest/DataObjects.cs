using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliTest
{
    public enum PersonGender { Mr, Mrs }

    public class Person : XPObject
    {
        public PersonGender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person Owner { get; set; }
        public string FirstName { get; set; }
        public Team Team { get; set; }
    }

    public class Team : XPObject
    {
        public string Name { get; set; }
    }
}

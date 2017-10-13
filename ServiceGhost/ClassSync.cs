using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceGhost
{
    public class ClassSync
    {
        public int MyAge { get; set; }
        public string MyName { get; set; }

        public string GetName()
        {
            var getPerson = MyName + " " + MyAge;
            return getPerson;
        }
    }
}
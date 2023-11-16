using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoviES.Models.Person
{
    class Admin : Person
    {
        private bool godMode;

        public Admin(int id, string name, string password) :
               this(id, name, password, true)
        { }

        public Admin(int id, string name, string password, bool godMode) : base(id, name, password)
        {
            this.godMode = godMode;

        }

        public bool GodMode { get => godMode; set => godMode = value; }
    }
}

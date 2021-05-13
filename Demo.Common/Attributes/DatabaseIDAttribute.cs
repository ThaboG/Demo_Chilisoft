using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class DatabaseIDAttribute : Attribute
    {
        public string ID
        {
            get; set;
        }
        public DatabaseIDAttribute()
        {

        }
    }
}

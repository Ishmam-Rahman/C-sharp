using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class PropertiesCsharp
    {
        private string name;
        public PropertiesCsharp(string Title)
        {
            Name = Title;
        }
        public string Name
        {
            get { return name; }
            set {
                name = value;
            }
        }
    }
}

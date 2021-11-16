using System;
using System.Collections.Generic;

namespace xBalsat
{
    public class Personenliste: List<string>
    {
        //Binding in constructor
        public Personenliste()
        {
             this.Add( "WYSIWYG");
             this.Add("Person 2");
             this.Add("Person 3");
        }        
    }
}
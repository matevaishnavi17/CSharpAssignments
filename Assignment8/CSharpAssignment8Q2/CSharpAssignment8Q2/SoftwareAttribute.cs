using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignment8Q2
{
    public class SoftwareAttribute:Attribute
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ClientName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}

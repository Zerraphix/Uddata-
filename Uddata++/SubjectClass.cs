using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uddata__
{
    public enum Subjects { Dan, Eng, Math, His, Geo, Prog }
    public enum Grade { ringe = -3, utilstrækkelige = 0, tilstrækkelig = 02, jævn = 4, god = 7, super = 10, fremragende = 12}
    class SubjectClass : ParentClass
    {
        public Grade Grade { get; set; }
        public Subjects Subject {  get; set; }
    }
}

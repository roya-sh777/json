using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    public  class Group
    {
        public string Name { get; set; }
        public List<Student> students = new List<Student>();
    }
}

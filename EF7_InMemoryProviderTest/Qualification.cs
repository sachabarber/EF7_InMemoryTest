using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7_InMemoryProviderTest
{
    public class Qualification
    {
       
        public int Id { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("Id : {0}, Description : {1}",
                        Id, Description);
        }

    }
}

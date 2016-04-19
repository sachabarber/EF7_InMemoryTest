using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7_InMemoryProviderTest
{
    public class Person
    {
        public Person()
        {
            Qualifications = new List<Qualification>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Qualification> Qualifications { get; set; }

        public override string ToString()
        {
            string qualifications = Qualifications.Any() ?
                    Qualifications.Select(x => x.Description)
                        .Aggregate((x, y) => string.Format("{0} {1}", x, y)) :
                    string.Empty;

            return string.Format("Id : {0}, FirstName : {1}, LastName : {2}, \r\nQualifications : {3}\r\n",
                        Id, FirstName, LastName, qualifications);
        }
    }
}

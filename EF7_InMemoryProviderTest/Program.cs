using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7_InMemoryProviderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClassDbContext>();
            optionsBuilder.UseInMemoryDatabase();

            using (var classDbContext = new ClassDbContext(optionsBuilder.Options))
            {
                SeedData(classDbContext);

                var personId1 = GetMember(classDbContext, 1);
                Console.WriteLine("> Adding a qualication\r\n");
                personId1.Qualifications.Add(classDbContext.Qualifications.First());
                classDbContext.SaveChanges();

                personId1 = GetMember(classDbContext, 1);


                Console.ReadLine();

            }
        }

        private static Person GetMember(ClassDbContext classDbContext, int id)
        {
            var person = classDbContext.Members.FirstOrDefault(x => x.Id == id);
            Console.WriteLine(person);
            return person;
        }


        private static void SeedData(ClassDbContext classDbContext)
        {
            classDbContext.Members.Add(new Person() { Id = 1, FirstName = "Sacha", LastName = "Barber" });
            classDbContext.Members.Add(new Person() { Id = 2, FirstName = "Sarah", LastName = "Barber" });

            classDbContext.Qualifications.Add(new Qualification() { Id = 1, Description = "Bsc Hons : Computer Science" });
            classDbContext.Qualifications.Add(new Qualification() { Id = 2, Description = "Msc : Computer Science" });
            classDbContext.Qualifications.Add(new Qualification() { Id = 3, Description = "Bsc Hons : Naturapathic medicine" });

            classDbContext.SaveChanges();
        }
    }
}

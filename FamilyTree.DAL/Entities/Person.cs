using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree.DAL.Entities
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public Person Spouse { get; set; }
    }
}

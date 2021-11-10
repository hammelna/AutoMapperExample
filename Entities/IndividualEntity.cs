using System;

namespace Entities
{
    public class IndividualEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RandomFact { get; set; }
        public DateTime Created { get; set; }
    }
}

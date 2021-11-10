using System;
using System.Collections.Generic;

namespace Entities
{
    public class TeamEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IndividualEntity> FullTimeEmployees { get; set; }
        public List<IndividualEntity> Interns { get; set; }
        public List<IndividualEntity> FormerInterns { get; set; }
        public DateTime Created { get; set; }
    }
}

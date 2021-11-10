using System.Collections.Generic;

namespace Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public List<Individual> FullTimeEmployees { get; set; }
        public List<Individual> Interns { get; set; }
        public List<Individual> FormerInterns { get; set; }
    }
}

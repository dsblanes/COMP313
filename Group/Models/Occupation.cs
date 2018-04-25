using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Group.Models
{
    public class Occupation
    {

        public string occName { get; set; }
        public string occProbability { get; set; }
        public string occDescription { get; set; }
        public List<string> occRelatedJobs { get; set; }

    }

    public class OccupationDBContext : DbContext
    {
        public DbSet<Occupation> Occupations { get; set; }
    }
}
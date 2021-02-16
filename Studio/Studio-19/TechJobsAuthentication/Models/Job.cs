using System;

namespace TechJobsAuthentication.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Employer { get; set; }
        public string Skill { get; set; }

        public Job()
        {
        }

        public Job(string name, string employer, string skill)
        {
            Name = name;
            Employer = employer;
            Skill = skill;
        }
    }
}

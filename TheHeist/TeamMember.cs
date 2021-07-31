using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist
{
    class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }


        public TeamMember(string name, int skillLevel, decimal courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }

        public void DisplayMemberInfo()
        {
            Console.WriteLine("Here is the team's info:");
            Console.WriteLine($"Team member is {Name}");
            Console.WriteLine($"The skill level is {SkillLevel}");
            Console.WriteLine($"The courage factor is {CourageFactor}");
        }
    }
}

using System;
using System.Collections.Generic;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");
            // Choose difficulty level
            Console.WriteLine("Choose the difficulty level of the bank");
            int difficultyLevel = int.Parse(Console.ReadLine());
            // Create team
            var team = new List<TeamMember> { };
            // Bank's difficulty level
            var bankLevel = 100;

            var noInput = true;
            while (noInput)
            {
                Console.WriteLine("Enter a team member's name.");
                var memberName = Console.ReadLine();

                if (memberName != "")
                {
                    Console.WriteLine($"Enter {memberName}'s skill level.");
                    var skillLevel = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter {memberName}'s courage factor.");
                    var courageFactor = decimal.Parse(Console.ReadLine());

                    var newMember = new TeamMember(memberName, skillLevel, courageFactor);
                    team.Add(newMember);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"You currently have {team.Count} people in your heist");
            // Prompting user to enter the number of trial runs the program should perform
            Console.WriteLine("Please enter how many times you would like to run this program.");
            var trialRun = int.Parse(Console.ReadLine());
            var i = 0;
            var successfulRuns = 0;
            var failedRuns = 0;
            while (i < trialRun)
            {
                // Random lucky value to add to bank level
                var rand = new Random();
                var luckValue = rand.Next(-10, 11);
                bankLevel += luckValue;
                // Displaying team's skill level and bank's level
                Console.WriteLine();
                Console.WriteLine("-----Your Team Info-----");
                var teamSkill = 0;
                foreach (var member in team)
                {
                    member.DisplayMemberInfo();
                    teamSkill += member.SkillLevel;
                }
                Console.WriteLine("------------------------");
                Console.WriteLine($"Your team's current combined skill level is {teamSkill}");
                Console.WriteLine($"The bank's difficulty level is {bankLevel}");

                // Comparing your team's level against bank's level
                if (bankLevel <= teamSkill)
                {
                    Console.WriteLine("Congratulations! You successfully stole all the money from bank.");
                    successfulRuns += 1;
                }
                else
                {
                    Console.WriteLine("YOU FAILED");
                    failedRuns += 1;
                }
                i++;
            }
            Console.WriteLine($"You succeeded {successfulRuns} times and failed {failedRuns} times");
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Heist
{
    class Heist
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Bank TargetBank = new Bank();
            Team HeistTeam = new Team();
            //Create first team member
            do
            {
            Member newMember = new Member();
            Console.WriteLine("Enter Team member's name: ");
            string newMemberName = Console.ReadLine();
            //Exit loop if newMemberName is empty string
            if(newMemberName==""){
                break;
            }
            else{
                //Create new member
                newMember.Name = newMemberName;
                Console.WriteLine("Enter Team member's skill level");
                newMember.SkillLevel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter team member's courage factor");
                newMember.CourageFactor = Double.Parse(Console.ReadLine());
                HeistTeam.MemberList.Add(newMember);
                //Display team member
            }} while(true);

            //Compute success||Failure
            Console.WriteLine($"Heisting with {HeistTeam.MemberList.Count} members");
            IEnumerable<int> totalSkillIE = HeistTeam.MemberList.Select(m => m.SkillLevel);
            int totalSkill = totalSkillIE.Sum();
            if(totalSkill >= TargetBank.Difficulty)
            {
                Console.WriteLine("Heist Successful!");
            }
            else
            {
                Console.WriteLine("You got caught.");
            }

            //Display team information
            // Console.WriteLine("----------------THE TEAM----------------");
            // foreach(Member member in HeistTeam.MemberList)
            // {
            //     Console.WriteLine($"{member.Name}");
            //     Console.WriteLine($"Skill Level: {member.SkillLevel}");
            //     Console.WriteLine($"Courage Factor: {member.CourageFactor}");
            //     Console.WriteLine("--------------------------------");
            // }
        }
    }
}


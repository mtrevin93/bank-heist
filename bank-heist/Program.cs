using System;

namespace Heist
{
    class Heist
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            //Create first team member
            Member starterMember = new Member();
            Console.WriteLine("Enter Team member's name: ");
            starterMember.Name = Console.ReadLine();
            Console.WriteLine("Enter Team member's skill level");
            starterMember.SkillLevel = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter team member's courage factor");
            starterMember.CourageFactor = Double.Parse(Console.ReadLine());
            //Display team member
            Console.WriteLine($"Heisting with {starterMember.Name}\nSkill Level: {starterMember.SkillLevel}\nCourage Factor: {starterMember.CourageFactor}");
        }
    }
}


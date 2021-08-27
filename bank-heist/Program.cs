using System;

namespace Heist
{
    class Heist
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            //Create first team member
            while(true){
            string newMemberName = Console.ReadLine();
            if(newMemberName==""){
                break;
            }
            else{
                Member newMember = new Member();
                Console.WriteLine("Enter Team member's name: ");
                Console.WriteLine("Enter Team member's skill level");
                newMember.SkillLevel = UInt32.Parse(Console.ReadLine());
                Console.WriteLine("Enter team member's courage factor");
                newMember.CourageFactor = Double.Parse(Console.ReadLine());
                //Display team member
                Console.WriteLine($"Heisting with {newMember.Name}\nSkill Level: {newMember.SkillLevel}\nCourage Factor: {newMember.CourageFactor}");
            }
            }
        }
    }
}


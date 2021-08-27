using System.ComponentModel.DataAnnotations;
namespace Heist
{
public class Member
{
public string Name {get; set;}
public uint SkillLevel {get; set;}
[Range(0, 2.0)]public double CourageFactor { get; set; }
public Member(){}
}
}
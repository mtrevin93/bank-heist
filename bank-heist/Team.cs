using System.Collections.Generic;
namespace Heist
{
public class Team {
public List<Member> MemberList { get; set; }
public Team()
{
    MemberList = new List<Member>();
}
}
}
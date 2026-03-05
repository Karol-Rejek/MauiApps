using System;
using System.Collections.Generic;
using System.Text;

namespace SocialAppSimulator.src.Models
{

    public enum Roles
    {
        Leader,
        VcLeader,
        Moderator,
        Member,
    }

    public class Team
    {

        public string name;
        public Dictionary<User, Roles> members;

        Team(string name, User teamLeader)
        {
            this.members = new Dictionary<User, Roles>();
            this.members.Add(teamLeader, Roles.Leader);
            this.name = name;

        }

        public void AddMember(User user, Roles role)
        {
            if (!members.ContainsKey(user))
            { 
                members.Add(user, role);
            }
        }

        public void UpdateMemberRole(User user, Roles newRole)
        {
            if (members.ContainsKey(user))
            {  
                members[user] = newRole;
            }
        }

    }
}

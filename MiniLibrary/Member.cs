using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniLibrary
{
    public class Member
    {
        public string Name { get; set; }
        public int MemberId { get; set; }
        public string MembershipType { get; set; }
        public Member(string name, int memberId, string membershipType)
        {
            Name = name;
            MemberId = memberId;
            MembershipType = membershipType;
        }
        public override string ToString()
        {
            return $"{Name}, Member ID: {MemberId}, Type: {MembershipType}";
        }
    }
}

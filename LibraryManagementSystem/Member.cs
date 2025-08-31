

using LibraryManagementSystem.Utils;

namespace LibraryManagementSystem
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string MemberShipCode { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Email { get; set; }

        public MemberTypeEnum MemberType { get; set; }

        public void Register()
        {
            
        }




    }
}

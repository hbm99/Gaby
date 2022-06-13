using Gaby.Shared.Model;

namespace Test
{
    public static class FrontTester
    {
        public static List<MemberClient> FakeMembersSearch()
        {
            MemberClient a = new MemberClient();
            a.Name = "Mateo Gonzales Andrade";
            a.PhoneNumber = "53429384";
            a.CheckInTime = new TimeOnly(12, 0);
            a.CheckOutTime = new TimeOnly(14, 0);
            a.Active = true;

            MemberClient b = new MemberClient();
            b.Name = "Luis Castillo Diaz";
            b.PhoneNumber = "71451345";
            b.CheckInTime = new TimeOnly(15, 30);
            b.CheckOutTime = new TimeOnly(16, 45);
            b.Active = false;

            MemberClient c = new MemberClient();
            c.Name = "Samuel Contreras Benitez";
            c.PhoneNumber = "50923432";
            c.CheckInTime = new TimeOnly(8, 45);
            c.CheckOutTime = new TimeOnly(10, 0);
            c.Active = true;

            return new List<MemberClient> { a, b, c };
        }
    }
}
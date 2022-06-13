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
        public static List<Coach> FakeCoachSearch()
        {
            Coach a = new Coach();
            a.Name = "Juan Garcia Cruz";
            a.BasicSalary = 120;
            a.ExtraSalary = 250;

            Coach b = new Coach();
            b.Name = "Marcelo Riveira Fernandez";
            b.BasicSalary = 400;
            b.ExtraSalary = 300;

            Coach c = new Coach();
            c.Name = "Carlos Manuel Yedra Vazquez";
            c.BasicSalary = 200;

            return new List<Coach> { a, b, c };
        }
        public static List<MaintenanceEmployee> FakeMaintenanceSearch()
        {
            MaintenanceEmployee a = new MaintenanceEmployee();
            a.Name = "Ernesto Alvarez Hernandez";
            a.BasicSalary = 200;

            MaintenanceEmployee b = new MaintenanceEmployee();
            b.Name = "Damian Chavez Gonzalez";
            b.BasicSalary = 300;
            b.ExtraSalary = 150;

            return new List<MaintenanceEmployee> { a, b };
        }
        public static List<CleanerEmployee> FakeCleanerSearch()
        {
            CleanerEmployee a = new CleanerEmployee();
            a.Name = "Susana Garcia Collado";
            a.BasicSalary = 200;



            return new List<CleanerEmployee> { a };
        }

        public static List<LessonTurn> FakeLessonTurnSearch()
        {
            LessonTurn a = new LessonTurn();
            a.Service = new Service();
            a.Service.ServiceType = new ServiceType();
            a.Service.ServiceType.ServiceTypeName = "Spinning";
            a.Coach = new Coach();
            a.Coach.Name = "Juan Garcia Cruz";
            a.Schedule = new DateTime(2022, 12, 23, 8, 30, 0);
            a.Price = 20;

            LessonTurn b = new LessonTurn();
            b.Service = new Service();
            b.Service.ServiceType = new ServiceType();
            b.Service.ServiceType.ServiceTypeName = "Aerobic";
            b.Coach = new Coach();
            b.Coach.Name = "Marcelo Riveira Fernandez";
            b.Schedule = new DateTime(2022, 12, 23, 10, 0, 0);
            b.Price = 10;

            LessonTurn c = new LessonTurn();
            c.Service = new Service();
            c.Service.ServiceType = new ServiceType();
            c.Service.ServiceType.ServiceTypeName = "Spinning";
            c.Coach = new Coach();
            c.Coach.Name = "Juan Garcia Cruz";
            c.Schedule = new DateTime(2022, 12, 23, 17, 30, 0);
            c.Price = 20;

            LessonTurn d = new LessonTurn();
            d.Service = new Service();
            d.Service.ServiceType = new ServiceType();
            d.Service.ServiceType.ServiceTypeName = "Crosfit";
            d.Coach = new Coach();
            d.Coach.Name = "Carlos Manuel Yedra Vazquez";
            d.Schedule = new DateTime(2022, 12, 23, 18, 0, 0);
            d.Price = 25;

            return new List<LessonTurn> { a, b, c, d };
        }
    }
}
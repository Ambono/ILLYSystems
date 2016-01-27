using System;
namespace IllySystems
{
  class DemoCompareObjects
  {
    public static void Main()
    {
      Console.WriteLine("Enter V to view demo C to create demo");
      string result = Console.ReadLine();
      if (result.ToLower().Equals("v"))
      {
        ViewDemo();
      }
      else if(result.ToLower().Equals("c"))
      {
        ObjectA person_A = new ObjectA();
        ObjectB person_B = new ObjectB();
        CreateDemo(person_A, person_B);
      }
    }

    private static void ViewDemo()
    {
      ObjectA person_A = new ObjectA("A", 26, new DateTime(1990, 6, 10));
      ObjectB person_B = new ObjectB("B", 10, new DateTime(2006, 7, 10));

      person_B.objectBEmploymentHistory.Department = "IT";
      person_B.objectBEmploymentHistory.startDate = new DateTime(2012, 02, 09);
      person_B.objectBEmploymentHistory.HourWorked = 38.5;

      person_A.objectAEmploymentHistory.Department = "HR";
      person_A.objectAEmploymentHistory.startDate = new DateTime(2010, 05, 09);
      person_A.objectAEmploymentHistory.HourWorked = 37.5;

      new Auditor().CompareObjects(person_A, person_B);
    }

    public static void CreateDemo(ObjectA person_A, ObjectB person_B)
    {
      Console.WriteLine("Enter name of first object");
      string name_A = Console.ReadLine();

      Console.WriteLine("Enter security number of first object");
      int age_A = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter date of birth of first object (mm/dd/yyyy)");
      DateTime dateOfBirth_A = Convert.ToDateTime(Console.ReadLine());

      person_A.Surname = name_A;
      person_A.SecurityNumber = age_A;
      person_A.DateOfBirth = dateOfBirth_A;

      Console.WriteLine("Enter department of first object");
      string dep_A = Console.ReadLine();
      person_A.objectAEmploymentHistory.Department = dep_A;

      Console.WriteLine("Enter start date of first object (mm/dd/yyyy)");
      DateTime startDate_A = Convert.ToDateTime(Console.ReadLine());
      person_A.objectAEmploymentHistory.startDate = startDate_A;

      Console.WriteLine("Enter work hours of first object");
     double workHours_A = Convert.ToDouble(Console.ReadLine());
      person_A.objectAEmploymentHistory.HourWorked = workHours_A;


      Console.WriteLine("Enter name of second object");
      string name_B = Console.ReadLine();

      Console.WriteLine("Enter security number of second object");
      int age_B = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter date of birth of second object (mm/dd/yyyy)");
      DateTime dateOfBirth_B = Convert.ToDateTime(Console.ReadLine());

      person_B.Surname = name_B;
      person_B.SecurityNumber = age_B;
      person_B.DateOfBirth = dateOfBirth_B;



      Console.WriteLine("Enter department of second object");
      string dep_B = Console.ReadLine();
      person_B.objectBEmploymentHistory.Department = dep_B;

      Console.WriteLine("Enter start date of second object (mm/dd/yyyy)");
      DateTime startDate_B = Convert.ToDateTime(Console.ReadLine());
      person_B.objectBEmploymentHistory.startDate = startDate_B;

      Console.WriteLine("Enter work hours of second object");
      double workHours_B = Convert.ToDouble(Console.ReadLine());
      person_B.objectBEmploymentHistory.HourWorked = workHours_B;      

      Console.ReadKey();
      new Auditor().CompareObjects(person_A, person_B);
    }
  }
}

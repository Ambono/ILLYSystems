using System;
using System.Collections;
namespace IllySystems
{
  public class ObjectB : ObjectClass
  {
    Hashtable objectBHashTable = new Hashtable();

    public EmploymentHistory objectBEmploymentHistory = new EmploymentHistory("Marketing", new DateTime(2014, 06, 19), 37.5);

    public ObjectB() { }

    public ObjectB(string surname, int securityNumber, DateTime dateOfBirth)
    {
      Surname = surname;
      SecurityNumber = securityNumber;
      DateOfBirth = dateOfBirth;
    }

    public override Hashtable GetHashtable()
    {
      objectBHashTable.Clear();
      objectBHashTable.Add("Surname", Surname);
      objectBHashTable.Add("Security Number", SecurityNumber);
      objectBHashTable.Add("Date of Birth", DateOfBirth.ToString("MM dd yyyy"));
      objectBHashTable.Add("Employment History", "Dept: " + objectBEmploymentHistory.Department
        + " " + "started:  " + objectBEmploymentHistory.startDate.ToString("MM dd yyyy")
        + " hour worked  " + " " + objectBEmploymentHistory.HourWorked);

      if (DateOfBirth >= objectBEmploymentHistory.startDate)
      {
        throw new Exception("Date of birth second object cannot be later than start date");
      }
      return objectBHashTable;
    }
  }
}

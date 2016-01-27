using System;
using System.Collections;

namespace IllySystems
{
  public class ObjectA : ObjectClass
  {
    Hashtable objectAHashTable = new Hashtable();
   
    public EmploymentHistory objectAEmploymentHistory = new EmploymentHistory("Marketing", new DateTime(2014, 06, 19), 37.5);

    public ObjectA() { }

    public ObjectA(string surname, int securityNumber, DateTime dateOfBirth)
    {
      Surname = surname;
      SecurityNumber = securityNumber;
      DateOfBirth = dateOfBirth;
    }

    public override Hashtable GetHashtable()
    {
      objectAHashTable.Clear();
      objectAHashTable.Add("Surname", Surname);
      objectAHashTable.Add("Security Number", SecurityNumber);
      objectAHashTable.Add("Date of Birth", DateOfBirth.ToString("MM dd yyyy"));
      objectAHashTable.Add("Employment History", "Dept: " + objectAEmploymentHistory.Department
        + " " + "started:  " + objectAEmploymentHistory.startDate.ToString("MM dd yyyy")
        + " hour worked  " + " " + objectAEmploymentHistory.HourWorked);
      if (DateOfBirth >= objectAEmploymentHistory.startDate)
      {
        throw new Exception("Date of birth first object cannot be later than start date");
      }
      return objectAHashTable;
    }
  }
}

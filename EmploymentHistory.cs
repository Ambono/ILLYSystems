using System;

namespace IllySystems
{
  public class EmploymentHistory
  {
    public String Department{get; set;}
    public DateTime startDate{get; set;}
    public Double HourWorked{get; set;}

    public EmploymentHistory()
    {
    }

    public EmploymentHistory(String department, DateTime startDate, Double hourWorked)
    {
      this.Department = department;
      this.startDate = startDate;
      this.HourWorked = hourWorked;
    }
  }
}

using lab2;

class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        while (flag) {
            Console.WriteLine("enter program to run");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Candidate c = new Candidate();
                    c.GetCandidateDetails();
                    c.DisplayCandidateDetails();
                    break;

                case 2:
                    int staffCount = 5;
                    Staff[] staffs = new Staff[staffCount];

                    for (int i = 0; i < staffCount; i++)
                    {
                        Console.WriteLine($"\nEnter details for Staff {i + 1}:");
                        staffs[i] = new Staff();
                        staffs[i].GetStaffDetails();
                    }
                    Console.WriteLine("\nDetails of HODs:");
                    for (int i = 0; i < staffCount; i++)
                    {
                        if (staffs[i].designation.ToLower() == "hod")
                        {
                            staffs[i].DisplayStaffDetails();
                        }
                    }
                    break;

                case 3:
                    Bank_Account bankAccount = new Bank_Account();
                    bankAccount.GetAccountDetails();
                    bankAccount.DisplayAccountDetails();
                    break;

                case 4:
                    Student s = new Student(602, 4, "shreyansh", 7.96, 7.96);
                    s.DisplayStudentDetails();
                    break;

                case 5:
                    Rectangle r = new Rectangle(10, 12);
                    r.Area();
                    break;

                case 6:
                    Interest account = new Interest("shreyansh", 50000, 3);
                    account.DisplayAccountDetails();
                    account.CalculateAndDisplayInterest();
                    break;

                case 7:
                    Salary s1 = new Salary(30000, 2000, 3000);
                    Salary s2 = new Salary(50000, 4000);
                    s1.DisplaySalaryDetails();
                    s2.DisplaySalaryDetails();
                    break;

                case 8:
                    Distance dist = new Distance(10.5, 20.3);
                    dist.CalculateAddition();
                    dist.DisplayAddition();
                    break;

                case 9:
                    Table myTable = new Table("Wood", 150, 5, 30);
                    myTable.DisplayTableDetails();
                    break;

                case 10:
                    Salary2 sal = new Salary2(5000, 2000, 1000);
                    sal.Disp_sal();
                    Console.WriteLine("Total Allowance (Gross Salary from Salary class): " + sal.Gross_sal());
                    Employee emp = new Employee("Dhairya", 20000);
                    emp.basic_sal();
                    Console.WriteLine("Gross Salary from Employee class (Basic): " + emp.Gross_sal());
                    break;

                case 11:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;



            }
        }
    }
}

   
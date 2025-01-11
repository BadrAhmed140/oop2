using opp2;

internal class Program
{
    private static void Main(string[] args)
    {
       
       


        HireDate hireDate1 = new HireDate(5, 1, 2020);
        HireDate hireDate2 = new HireDate(10, 4, 2021);
        HireDate hireDate3 = new HireDate(15, 8, 2022);

        Q1[] empArray = new Q1[3];

            
        empArray[0] = new Q1(1, "BADR", SecurityLevel.DBA, 85000, hireDate1, "M");
        empArray[1] = new Q1(2, "bico", SecurityLevel.Guest, 40000, hireDate2, "F");
        empArray[2] = new Q1(3, "tarek", SecurityLevel.Developer , 120000, hireDate3, "M");
        foreach (Q1 emp in empArray) { 
        Console.WriteLine(emp.ToString());
            Console.WriteLine("----------------------------");
        }
    }
}
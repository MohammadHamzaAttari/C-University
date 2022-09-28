internal class Program
{
    private static void Main(string[] args)
    {
        int month = 12, bonus = 1000;
        int monthWage = 1234;
        bool isactive = true;
        double rating = 99.25;
        double ratePerHour = 12.32;
        int numberOfHoursWorked = 165;
        double currentWage = ratePerHour * numberOfHoursWorked + bonus;
        Console.WriteLine(currentWage);
        currentWage += currentWage;
        if (currentWage > 3000 && isactive && monthWage > 1200 && month > 12 && rating > 99)
        {
            Console.WriteLine("Expensive and Brilliant Employee:");
        }
        else
        {
            Console.WriteLine("Moderate Employee");
        }
        char userdefined = 'a';
        bool letter = char.IsLetter(userdefined);
        bool digit = char.IsDigit(userdefined);
        char Upperversion = char.ToUpper(userdefined);
        Console.WriteLine(letter);
        Console.WriteLine(digit);
        Console.WriteLine(Upperversion);
        DateTime hiredate=new DateTime(2022,9,22,16,56,0);
        Console.WriteLine(hiredate);
        //Datetime complete introduction
        DateTime exitDate=new DateTime(2022,9,23,15,0,0);
        Console.WriteLine(exitDate);
        //when we increases client starting date
        DateTime newStartDate=hiredate.AddDays(15);
        Console.WriteLine(newStartDate);
        //Dealing with current date time
        DateTime currentDate=DateTime.Now;
        bool isweInDlst=currentDate.IsDaylightSavingTime();
        Console.WriteLine(currentDate);
        Console.WriteLine(isweInDlst);
        //dealing with time
        DateTime startHour=DateTime.Now;
        TimeSpan workTime=new TimeSpan(8,34,0);
        DateTime endHour=startHour.Add(workTime);
        Console.WriteLine(startHour.ToLongDateString());
        Console.WriteLine(endHour.ToShortTimeString());
        
        Console.ReadLine();
    }
}
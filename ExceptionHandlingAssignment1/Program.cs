// See https://aka.ms/new-console-template for more information

using ExceptionHandlingAssignment1;


Worker worker = new Worker(30000m);
string[] hours = File.ReadAllLines(@"C:\Users\Asus\Desktop\CypherCresent Software Academy\Assignments\ExceptionHandlingAssignment1\HoursWorked.txt");
decimal[] payRateForAWeek = new decimal[7];
try
{
    
    for (int i = 0; i < hours.Length; i++)
    {
        worker.HoursWorkedPerDay[i] = int.Parse(hours[i]);
    }

    for (int i = 0; i < worker.HoursWorkedPerDay.Length; i++)
    {
        payRateForAWeek[i] = worker.Wage / worker.HoursWorkedPerDay[i];
    }
    int index = 0;
    double value = GetAveragePayRate(index)/payRateForAWeek.Length;

    double GetAveragePayRate(int i)
    {
        if (index == payRateForAWeek.Length)
        {
            return 0;
        }
        return (double)payRateForAWeek[i] + GetAveragePayRate(i + 1);
    }
}catch(IOException ex)
{
    Console.WriteLine("You have passed in an incorrect file");
    Console.WriteLine(ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("An error occurred while trying to read your file");
    Console.WriteLine(ex.Message);
}
catch (ArrayTypeMismatchException ex)
{
    Console.WriteLine("An error occurred while trying to get all the hours");
    Console.WriteLine(ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("An error has occurred");
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("You have attempted to divide a number by zero!");
    Console.WriteLine(ex.Message);
}
catch (InvalidCastException ex)
{
    Console.WriteLine("An error has occurred");
    Console.WriteLine(ex.Message);
}
catch (StackOverflowException ex)
{
    Console.WriteLine("An error has occurred");
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

try 
{
    if (worker.Name is null || worker.Name == "")
    {
        throw new NoNameEnteredException("You don't have a name yet!");
    }
    if (worker.Wage <= 0)
    {
        throw new WageIsZeroExceptionOrNegative("Enter a positive non-zero number for wage");
    }
    if (payRateForAWeek.Length > 7)
    {
        throw new HigherThanAWeekException("The hours in your file are for more than a week");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
//this is still subject to modification please, this is all I could come up with
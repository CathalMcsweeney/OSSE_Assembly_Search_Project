using System.Text;

public class heartbeat
{
    public string assembly = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\Assembly_code.txt");
    
    public static void Main(string[] args)
    {
        heartbeat p = new heartbeat();
        //string pattern = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\..\Example_Patterns/pattern_1.txt");

        if (p.test1())
        {
            Console.WriteLine("1 Working");
        }
        else
        {
            Console.WriteLine("Nay Working");
        }
        Console.WriteLine("\n");
        if (p.test2())
        {
            Console.WriteLine("2 Working");
        }
        else
        {
            Console.WriteLine("Nay Working");
        }

        if (p.test3())
        {
            Console.WriteLine("3 Working");
        }
        else
        {
            Console.WriteLine("Nay Working");
        }
        //p.test2 ......
    }

    public bool test1()
    {
        pattern_finder pf = new pattern_finder();
        //get correct pattern to compare program function and ensure its output is correct
        string[] pat1 = System.IO.File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_1_correct.txt"));
        StringBuilder stringPat = new StringBuilder();
        foreach (string str in pat1)
        {
            stringPat.Append(str);
        }
        string pattern = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_1.txt");
        string[] argsToTest = { pattern, assembly };

        patternReturnInfo patternReturnInfo = pf.heartBeat(pattern, assembly);
        StringBuilder returnedString = pf.hmsamm(patternReturnInfo);

        if (stringPat.ToString() == returnedString.ToString())
        {
            return true;
        }
        else{
           return false;
        }
    }

    public bool test2()
    {
        pattern_finder pf = new pattern_finder();
        //get correct pattern to compare program function and ensure its output is correct
        string[] pat1 = System.IO.File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_2_correct.txt"));
        StringBuilder stringPat = new StringBuilder();
        foreach (string str in pat1)
        {
            stringPat.Append(str);
        }
        string pattern = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_2.txt");
        string[] argsToTest = { pattern, assembly };

        patternReturnInfo patternReturnInfo = pf.heartBeat(pattern, assembly);
        StringBuilder returnedString = pf.hmsamm(patternReturnInfo);

        //pf.heartBeat(pattern, assembly);
        if (stringPat.ToString() == returnedString.ToString())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool test3()
    {
        pattern_finder pf = new pattern_finder();
        //get correct pattern to compare program function and ensure its output is correct
        string[] pat1 = System.IO.File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_3_correct.txt"));
        StringBuilder stringPat = new StringBuilder();
        foreach (string str in pat1)
        {
            stringPat.Append(str);
        }
        string pattern = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_3.txt");
        string[] argsToTest = { pattern, assembly };

        patternReturnInfo patternReturnInfo = pf.heartBeat(pattern, assembly);
        StringBuilder returnedString = pf.hmsamm(patternReturnInfo);

        //pf.heartBeat(pattern, assembly);
        if (stringPat.ToString() == returnedString.ToString())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
using System.Text;

public class heartbeat
{
    public string assembly = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\Assembly_code.txt");
    
    public static void Main(string[] args)
    {
        heartbeat p = new heartbeat();

        //if anyone reads this and feels like cleaning this up
        //I wanted to put these tests in a loop so if you can do that
        //I would be grateful, I may fix it one day but for now,
        //she remains this beast only a mother can love. xox

        try
        {
            if (p.test1())
            {
                Console.WriteLine("1 Working");
            }
            else
            {
                Console.WriteLine("Nay Working");
            }
        }catch (TestCaseErrorFound ex)
        {
            Console.WriteLine(ex.Message);
        }
        try
        {
            if (p.test2())
            {
                Console.WriteLine("2 Working");
            }
            else
            {
                Console.WriteLine("Nay Working");
            }
        }
        catch (TestCaseErrorFound ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
        try
        {
            if (p.test3())
            {
                Console.WriteLine("3 Working");
            }
            else
            {
                Console.WriteLine("Nay Working");
            }
        }
        catch (TestCaseErrorFound ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
        try
        {
            if (p.test4())
            {
                Console.WriteLine("4 Working");
            }
            else
            {
                Console.WriteLine("Nay Working");
            }
        }
        catch (TestCaseErrorFound ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
        try
        {
            if (p.test5())
            {
                Console.WriteLine("5 Working");
            }
            else
            {
                Console.WriteLine("Nay Working");
            }
        }
        catch (TestCaseErrorFound ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }

        try
        {
            if (p.test6())
            {
                Console.WriteLine("6 Working");
            }
            else
            {
                Console.WriteLine("Nay Working");
            }
        }
        catch(TestCaseErrorFound ex) 
        { 
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
        try
        {
            if (p.test7())
            {
                Console.WriteLine("7 Working");
            }
            else
            {
                Console.WriteLine("Nay Working");
            }
        }
        catch (TestCaseErrorFound ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
        try
        {
            if (p.test8())
            {
                Console.WriteLine("8 Working");
            }
            else
            {
                Console.WriteLine("Nay Working");
            }
        }
        catch (TestCaseErrorFound ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
        try
        {
            if (p.test9())
            {
                Console.WriteLine("9 Working");
            }
            else
            {
                Console.WriteLine("Nay Working");
            }
        }
        catch (TestCaseErrorFound ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
        try
        {
            if (p.test10())
            {
                Console.WriteLine("10 Working");
            }
            else
            {
                Console.WriteLine("Nay Working");
            }
        }
        catch (TestCaseErrorFound ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
    }


    public bool test1()
    {
        pattern_finder pf = new pattern_finder();
        pf.testInProgress();
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
        StringBuilder returnedString = pf.heartbeatReturnString(patternReturnInfo);

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
        StringBuilder returnedString = pf.heartbeatReturnString(patternReturnInfo);

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
        StringBuilder returnedString = pf.heartbeatReturnString(patternReturnInfo);

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
    public bool test4()
    {
        pattern_finder pf = new pattern_finder();
        //get correct pattern to compare program function and ensure its output is correct
        string[] pat1 = System.IO.File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_4_correct.txt"));
        StringBuilder stringPat = new StringBuilder();
        foreach (string str in pat1)
        {
            stringPat.Append(str);
        }
        string pattern = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_4.txt");
        string[] argsToTest = { pattern, assembly };

        patternReturnInfo patternReturnInfo = pf.heartBeat(pattern, assembly);
        StringBuilder returnedString = pf.heartbeatReturnString(patternReturnInfo);

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
    public bool test5()
    {
        pattern_finder pf = new pattern_finder();
        //get correct pattern to compare program function and ensure its output is correct
        string[] pat1 = System.IO.File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_5_correct.txt"));
        StringBuilder stringPat = new StringBuilder();
        foreach (string str in pat1)
        {
            stringPat.Append(str);
        }
        string pattern = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_5.txt");
        string[] argsToTest = { pattern, assembly };

        patternReturnInfo patternReturnInfo = pf.heartBeat(pattern, assembly);
        StringBuilder returnedString = pf.heartbeatReturnString(patternReturnInfo);

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
    public bool test6()
    {
        pattern_finder pf = new pattern_finder();
        //get correct pattern to compare program function and ensure its output is correct
        string[] pat1 = System.IO.File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_6_correct.txt"));
        StringBuilder stringPat = new StringBuilder();
        foreach (string str in pat1)
        {
            stringPat.Append(str);
        }
        string pattern = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_6.txt");
        string[] argsToTest = { pattern, assembly };

        patternReturnInfo patternReturnInfo = pf.heartBeat(pattern, assembly);
        StringBuilder returnedString = pf.heartbeatReturnString(patternReturnInfo);

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
    public bool test7()
    {
        pattern_finder pf = new pattern_finder();
        //get correct pattern to compare program function and ensure its output is correct
        string[] pat1 = System.IO.File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_7_correct.txt"));
        StringBuilder stringPat = new StringBuilder();
        foreach (string str in pat1)
        {
            stringPat.Append(str);
        }
        string pattern = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_7.txt");
        string[] argsToTest = { pattern, assembly };

        patternReturnInfo patternReturnInfo = pf.heartBeat(pattern, assembly);
        StringBuilder returnedString = pf.heartbeatReturnString(patternReturnInfo);

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
    public bool test8()
    {
        pattern_finder pf = new pattern_finder();
        //get correct pattern to compare program function and ensure its output is correct
        string[] pat1 = System.IO.File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_8_correct.txt"));
        StringBuilder stringPat = new StringBuilder();
        foreach (string str in pat1)
        {
            stringPat.Append(str);
        }
        string pattern = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_8.txt");
        string[] argsToTest = { pattern, assembly };

        patternReturnInfo patternReturnInfo = pf.heartBeat(pattern, assembly);
        StringBuilder returnedString = pf.heartbeatReturnString(patternReturnInfo);

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
    public bool test9()
    {
        pattern_finder pf = new pattern_finder();
        //get correct pattern to compare program function and ensure its output is correct
        string[] pat1 = System.IO.File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_9_correct.txt"));
        StringBuilder stringPat = new StringBuilder();
        foreach (string str in pat1)
        {
            stringPat.Append(str);
        }
        string pattern = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_9.txt");
        assembly = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\Random_Text.txt");
        
        patternReturnInfo patternReturnInfo = pf.heartBeat(pattern, assembly);
        StringBuilder returnedString = pf.heartbeatReturnString(patternReturnInfo);
        assembly = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\Assembly_code.txt");
        
        if (stringPat.ToString() == returnedString.ToString())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool test10()
    {
        pattern_finder pf = new pattern_finder();
        //get correct pattern to compare program function and ensure its output is correct
        string[] pat1 = System.IO.File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_10_correct.txt"));
        StringBuilder stringPat = new StringBuilder();
        foreach (string str in pat1)
        {
            stringPat.Append(str);
        }
        string pattern = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\assembly_patterns\Example_Patterns\pattern_10.txt");
        string[] argsToTest = { pattern, assembly };

        patternReturnInfo patternReturnInfo = pf.heartBeat(pattern, assembly);
        StringBuilder returnedString = pf.heartbeatReturnString(patternReturnInfo);

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

class TestCaseErrorFound : Exception
{
    public TestCaseErrorFound()
        : base(String.Format("Test Case Failed")) { }
}
using System;

public class A
{
    public string M1(int number)
    {
        switch (number) // +1
        {
            case 1:
                return "one";
            case 2:                   
                return "a couple";
            case 3:
                return "a few";
            default:                  
                return "lots";
        }
    }
    
    public string M2(int number)
    {
        switch (number) // +1
        {
            case 1:
                if (true) // +2 (N=1)
                    return "one";
                return "ONE";
            case 2:                   
                return "a couple";
            case 3:
                return "a few";
            default:                  
                return "lots";
        }
    }
}

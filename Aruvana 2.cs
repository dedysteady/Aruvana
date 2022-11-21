using System;
 
class GFG
{
     
static void print24(String str)
{
    // Get hours
    int h1 = (int)str[1] - '0';
    int h2 = (int)str[0] - '0';
    int hh = (h2 * 10 + h1 % 10);
 
    // If time is in "AM"
    if (str[8] == 'A')
    {
        if (hh == 12)
        {
            Console.Write("00");
            for (int i = 2; i <= 7; i++)
                Console.Write(str[i]);
        }
        else
        {
            for (int i = 0; i <= 7; i++)
                Console.Write(str[i]);
        }
    }
 
    // If time is in "PM"
    else
    {
        if (hh == 12)
        {
            Console.Write("12");
            for (int i = 2; i <= 7; i++)
                Console.Write(str[i]);
        }
        else
        {
            hh = hh + 12;
            Console.Write(hh);
            for (int i = 2; i <= 7; i++)
                Console.Write(str[i]);
        }
    }
}
 
// Driver code
public static void Main(String[] args)
{
    String str = "07:05:45PM";
    print24(str);
}
}
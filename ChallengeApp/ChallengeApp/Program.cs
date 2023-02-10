int number = 4566;
string numberInString = number.ToString();
char[] digits = numberInString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (var digit in digits)
{
    if (digit == '0')
    {
        counter0++;
    }
    else if (digit == '1')
    {
        counter1++;
    }
    else if (digit == '2')
    {
        counter2++;
    }
    else if (digit == '3')
    {
        counter3++;
    }
    else if (digit == '4')
    {
        counter4++;
    }
    else if (digit == '5')
    {
        counter5++;
    }
    else if (digit == '6')
    {
        counter6++;
    }
    else if (digit == '7')
    {
        counter7++;
    }
    else if (digit == '8')
    {
        counter8++;
    }
    else if (digit == '9')
    {
        counter9++;
    }
}
Console.WriteLine(number);
Console.WriteLine(" 0\t" + counter0);
Console.WriteLine(" 1\t" + counter1);
Console.WriteLine(" 2\t" + counter2);
Console.WriteLine(" 3\t" + counter3);
Console.WriteLine(" 4\t" + counter4);
Console.WriteLine(" 5\t" + counter5);
Console.WriteLine(" 6\t" + counter6);
Console.WriteLine(" 7\t" + counter7);
Console.WriteLine(" 8\t" + counter8);
Console.WriteLine(" 9\t" + counter9);

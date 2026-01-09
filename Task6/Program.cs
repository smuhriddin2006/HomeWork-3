void Print(int n1, int n2)
{
    if(n1 > n2)
    {
        return;
    }
    else
    {
        if(n1 % 2 == 0)
        {
            System.Console.WriteLine(n1);
            Print(n1+1, n2);
        }
    }
}
Print(1, 20);
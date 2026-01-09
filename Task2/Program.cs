void Recursia(int n)
{
    System.Console.Write(n + " ");
    if(n == 1)
    {
        return;
    }
    else
    {
         Recursia(n-1);
    }
}
Recursia(10);
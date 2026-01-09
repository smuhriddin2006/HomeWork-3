void Recursia(int n)
{
    
    if(n == 0)
    {
        return;
    }
    else
    {
     Recursia(n-1);
     System.Console.Write(n + " ");
    }
}
Recursia(10);
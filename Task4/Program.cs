void Divide(int n)
{
    if(n==0)
    {
        return;
    }
    else
    {
       Divide(n/10);
       n %=10;
      System.Console.WriteLine(n + " ");
      
    }

}
Divide(1234);

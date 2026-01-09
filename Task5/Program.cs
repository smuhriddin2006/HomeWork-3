int cnt = 0;
void Cnt(int n)
{
    if(n == 0)
    {
        return 0;
    }
    else
    {
        return Cnt(n/10);
        
        
    }
}
Cnt(1234);
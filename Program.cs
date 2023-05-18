Console.Write("введите число ");
long n=long.Parse(Console.ReadLine());
int index=0;
int count = 0;
int proverka = 0;
while (n > 0)
{
    long p = n % 10;
    n /= 10;
    count++;
    if (p == 3 && proverka == 0) 
    {
    proverka++;
        index = count;
    }
}
Console.WriteLine($"номер цифры '3' с конца = {index}") ;
int n = int.Parse(Console.ReadLine());
int sum = 0;

for(int i = 1; i <= n; i++)
{
    int odd = i * 2 - 1;
    Console.WriteLine(odd); //gives odd numbers
    sum += odd;
    
}
Console.WriteLine($"Sum: {sum}");
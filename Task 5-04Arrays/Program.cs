Console.WriteLine("Hello World!!");

while (true) 
{
    Console.Write("Enter the Value: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Following are the prime numbers between 1 and {n}");
    primeNumbers(n);
    Console.WriteLine("\n");
    
}
void primeNumbers(int n)
{
    bool[] prime = new bool[n + 1];

    for (int i = 0; i < n; i++)
        prime[i] = true;

    for (int p = 2; p * p < n; p++)
    {

        if (prime[p] == true)
        {
            for (int i = p * p; i < n; i += p)
                prime[i] = false;
        }
    }

    // Print all prime numbers
    for (int i = 2; i <= n; i++)
    {
        if (prime[i] == true)
            Console.Write(i + " ");
    }
}
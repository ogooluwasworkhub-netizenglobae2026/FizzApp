// FizzApp: prints numbers 1 to 250
// multiples of 3 -> "fizz"
// multiples of 5 -> "buzz"

for (int i = 1; i <= 250; i++)            // count from 1 to 250
{
   if (i % 3 == 0)                  // only a multiple of 3?
    {
        Console.WriteLine("fizz");
    }
    else if (i % 5 == 0)                  // only a multiple of 5?
    {
        Console.WriteLine("buzz");
    }
    else                                  // none of the above
    {
        Console.WriteLine(i);
    }
}
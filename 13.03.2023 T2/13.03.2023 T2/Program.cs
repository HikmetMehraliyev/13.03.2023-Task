
//Task 2

int num = 678;
int i = 0;
int x = 1;

while (num > 0)
{
    i += x * (num % 10);
        num = (num / 10);
    x *= 10;
}
i = 3 * x + i;

Console.WriteLine(i);


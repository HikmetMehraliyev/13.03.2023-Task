//Task 1

int num = 5987;
int j = 0;
int i = 0;

while (num > 0)
{
    j = num % 10;
    i = (i * 10) + j;
    num = num / 10;
}

Console.WriteLine(i);


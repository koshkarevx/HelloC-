//              0   1   2   3    4   5   6   7   8   9
int[] array = {11, 24, 53, 123, 53, 52, 75, 232, 75, 55};

int n = array.Length;
int find = 75;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
// index = index + 1;
index++;
}
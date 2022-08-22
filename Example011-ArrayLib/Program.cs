void FillArray(int[] collection)
{
    int len = collection.Length;
    int ind = 0;

    while(ind < len)
    {
        collection[ind] = new Random().Next(1,10);
        ind++;
    }

}

void PrintArray(int[] col)
{
    int cnt = col.Length;
    int pos = 0;

    while(pos < cnt)
    {
        Console.WriteLine(col[pos]);
        pos++;
    }

}


int IndexOf(int[] col, int find)
{
    int cnt = col.Length;
    int ind = 0;
    int pos = -1;

    while(ind<cnt)
    {
        if(col[ind]==find)
        {
            pos = ind;
            break;
        }
        ind++;
    }
    return pos;
}

int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);
Console.WriteLine();

int pos = IndexOf(arr, 4);
Console.WriteLine(pos);

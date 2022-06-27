int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 4566;
int b1 = 4645;
int c1 = 6456;
int a2 = 546;
int b2 = 546;
int c2 = 46000;
int a3 = 46;
int b3 = 486;
int c3 = 847;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
using static System.Console;
using static System.Convert;
using static System.Math;

int n, m;
string[] arr2 = new string[3005];
string[] arr3 = new string[3005];
string str4 = "";
string str1 = ReadLine();
var arr1 = str1.Split(" ");
n = ToInt32(arr1[0]);
m = ToInt32(arr1[1]);
for(int i = 0; i < m; i++)
{
    string str2 = ReadLine();
    string[] arr4 = str2.Split(" ");
    arr2[i] = arr4[0];
    arr3[i] = arr4[1];

}
string str3 = ReadLine();
string[] arr5 = str3.Split();
for(int j = 0; j < n; j++)
{
    for(int k = 0; k < m; k++)
    {
        if (arr5[j].Equals(arr2[k]))
        {
            if (arr2[k].Length <= arr3[k].Length)
            {
                str4 += $"{arr2[k]} ";
            }
            else
            {
                str4 += $"{arr3[k]} ";
            }
        }
    }
}

WriteLine(str4);


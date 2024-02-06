using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class TwoD_Array_DS_Day1
{
    //2d array in Data structure see the detailed problem statement from the given link https://www.hackerrank.com/challenges/2d-array/problem?isFullScreen=true
    public static void GetMaximumHourGlassSum(List<List<int>> arr)
    {
        var rowLength = arr.Count;
        var columnLength = arr[0].Count;
        List<int> sumValues = new List<int>();
        for(int i = 0; i < columnLength-2; i++)
        {
            for(int j = 0; j < rowLength-2; j++)
            {
                var sum = arr[i][j] + arr[i][j+1] + arr[i][j+2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
                sumValues.Add(sum);
            }

        }
        Console.WriteLine(sumValues.Max());
    }
}

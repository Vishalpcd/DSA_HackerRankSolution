using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MirgatoryBirds
{
    /// <summary>
    /// Given an array of bird sightings where every element represents a bird type id,
    /// determine the id of the most frequently sighted type. If more than 1 type has 
    /// been spotted that maximum amount, return the smallest of their ids.
    /// https://hackerrank.com/challenges/migratory-birds/problem
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int migratoryBirds(List<int> arr)
    {
        var grouped = arr.GroupBy(e => e, e => e)
            .OrderByDescending(g => g.Count())
           .ThenBy(g => g.Key);

        return grouped.FirstOrDefault().Key;
    }
}

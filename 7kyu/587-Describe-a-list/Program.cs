
using System;
using System.Collections.Generic;


public class Describe
{
    public static string describeList(List<int> list)
    {
        if (list.Count == 0)
        {
            return "empty";
        }
        if (list.Count == 1)
        {
            return "singleton";
        }
        return "longer";

        //    Alternative
        // return list.Count switch {0 => "empty", 1 => "singleton", _ => "longer"};
    }
}
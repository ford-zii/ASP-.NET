using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    public string name;
    public string sum(int a, int b)
    {
        return string.Format("{0} : {1}",name,(a + b).ToString());
    }

    public string sum(int a, int b,int c)
    {
        return string.Format("{0} : {1}", name, (a + b + c).ToString());
    }
}
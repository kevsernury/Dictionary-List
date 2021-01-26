using System;

namespace DictonaryLists
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> liste = new MyList<int, string>();
            liste.Add(12, "Ali");
            liste.ShowByKey(12);
            liste.Add(22, "Kerem");
            liste.ShowList();
        }
    }
}

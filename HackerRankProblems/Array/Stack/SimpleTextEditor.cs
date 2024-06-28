using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Array.Stack
{
    internal class SimpleTextEditor
    {
        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        //    int iteratrion = int.Parse(Console.ReadLine());
        //    Stack<string> stringStack = new Stack<string>();
        //    string s = string.Empty;
        //    string input;
        //    for (int i = 0; i < iteratrion; i++)
        //    {
        //        input = Console.ReadLine();
        //        string[] inputs = input.Split(' ');
        //        switch (inputs[0])
        //        {
        //            case "1":
        //                stringStack.Push(s);
        //                s += inputs[1];
        //                break;
        //            case "2":
        //                int deleteCount = int.Parse(inputs[1]);
        //                if (s != string.Empty && s.Length >= deleteCount)
        //                {
        //                    stringStack.Push(s);
        //                    s = s.Remove(s.Length - deleteCount, deleteCount);
        //                }
        //                break;
        //            case "3":
        //                int index = int.Parse(inputs[1]) - 1;
        //                if (s != string.Empty && s.Length >= index)
        //                    Console.WriteLine(s[index]);
        //                break;
        //            case "4":
        //                if (stringStack.Count > 0)
        //                    s = stringStack.Pop();
        //                break;
        //        }
        //    }
        //}
    }
}

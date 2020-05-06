using System;
using System.IO;


namespace LAB3._2OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader start = new StreamReader("E:\\C#\\input1.txt");
            
            string line = start.ReadLine().Trim();
            Console.WriteLine(line);
            string res= brackets(line);
            Console.WriteLine(res);
        }
        static string brackets(string input)
        {
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '(')
                {
                    int k = i + 1;
                    while (arr[k] != ')')
                    {
                        arr[k] = '\0';
                        k++;
                    }
                }
            }
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != '\0')
                {
                    result += arr[i];
                }
            }
            return result;
        }
    }
}

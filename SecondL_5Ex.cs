using System;
using System.Reflection;

namespace _3rd_Lab
{
    class SecondL_5Ex
    {
        static void Main(string[] args)
        {
                        int size;
            Console.Write("Introduce the size of the matriz: ");
            if (!int.TryParse(Console.ReadLine(), out size))
                return;
            double[] x = new double[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the {i + 1} element of the array: ");
                if (!double.TryParse(Console.ReadLine(), out x[i])) return;
            }
            double MaxElement = x[0];
            double MinElement = x[0];
            int MaxElementIndex = 0 , MinElementIndex = 0;
            int index = 0;
            foreach (int element in x) {
                if (element > MaxElement){
                    MaxElement = element;
                    MaxElementIndex = index;
                }
                if (element < MinElement) {
                    MinElement = element;
                    MinElementIndex = index;
                }
                index++;
            }
            index = 0;
            int indexOfY = 0;
            double[] y = new double[MaxElementIndex - MinElementIndex - 1];
            foreach(int element in x){
                if(index > MinElementIndex && index < MaxElementIndex){
                    if(element < 0){
                    y[indexOfY] = element;
                    indexOfY++;
                    }
                }
                index++;   
            }
            foreach(int element in y){
                Console.WriteLine(element);
            }
        }
    }
}

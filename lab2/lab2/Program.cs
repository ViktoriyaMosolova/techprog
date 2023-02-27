
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        //Вывод информации о программе
        string lastchange = File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location).ToString();
        string version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "1";
        Console.WriteLine("LastChange: " + lastchange + "\nVersion: " + version + "\n");

        //Индекс наиболее подходящей формулы для расчета
        int Index = Сalculations.IndexMostSuitableFormula();

        //вывод результатов по наиболее подходящей формуле
        Console.WriteLine("|{0,5}   |{1,8}   |\n", "T, C", "CH, %");
        for (int t = 0; t <= 90; t++)
        {
            Console.WriteLine("|{0,5}   |{1,8:0.00}   |", t, Сalculations.ValueCH(t)[Index]);
            if ((t+1)%10==0)
            {
                Console.WriteLine();
            }
        }
    }
}

public class Сalculations
{
    public static int IndexMostSuitableFormula()//определяет наиболее подходящую формулу
    {
        double[] sum = { 0, 0, 0, 0, 0 };
        double[] exp_CH = { 64.44, 65.4, 66.74, 68.36, 70.22, 72.24, 74.32, 76.51, 78.74, 80.86 };
        int[] t = { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        for (int i = 0; i <= 9; i++)
        {
            sum[0] += Math.Abs(exp_CH[i] - ValueCH(t[i])[0]) / 10;
            sum[1] += Math.Abs(exp_CH[i] - ValueCH(t[i])[1]) / 10;
            sum[2] += Math.Abs(exp_CH[i] - ValueCH(t[i])[2]) / 10;
            sum[3] += Math.Abs(exp_CH[i] - ValueCH(t[i])[3]) / 10;
            sum[4] += Math.Abs(exp_CH[i] - ValueCH(t[i])[4]) / 10;
        }
        return sum.ToList().IndexOf(sum.Min());
    }

    public static double[] ValueCH(int t)//расчет значений функции
    {
        double[] CH = { 0, 0, 0, 0, 0 };
        CH[0] = 64.496 + 0.0659625 * t + 0.224306 * Math.Pow(10, -2) * Math.Pow(t, 2) - 0.105729 * Math.Pow(10, -4) * Math.Pow(t, 3);
        CH[1] = 64.496 + 0.066027 * t + 0.2241304 * Math.Pow(10, -2) * Math.Pow(t, 2) - 0.10560396 * Math.Pow(10, -4) * Math.Pow(t, 3);
        CH[2] = 64.4724 + 8.1564207 * Math.Pow(10, -2) * t + 2.3034122 * Math.Pow(10, -4) * Math.Pow(t, 2.8) - 2.6492852 * Math.Pow(10, -5) * Math.Pow(t, 3.3) + 2.4826037 * Math.Pow(10, -8) * Math.Pow(t, 4.5);
        CH[3] = 64.18 + 0.1348 * t + 5.31 * Math.Pow(10, -4) * Math.Pow(t, 2);
        CH[4] = 63.608 + 0.133 * t + 7.22 * Math.Pow(10, -4) * Math.Pow(t, 2);
        return CH;
    }
}
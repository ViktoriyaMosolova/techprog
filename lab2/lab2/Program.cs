
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        double[] sum = { 0, 0, 0, 0, 0 };
        Deviations.sum_of_squared_deviations(sum);
        for (int i = 0; i < sum.Length; i++)
        {
            Console.WriteLine(sum[i]);
        }
    }
}

public class Calc
{
    public static double CH1(int t)
    {
        return 64.496 + 0.0659625 * t + 0.224306 * Math.Pow(10, -2) * Math.Pow(t, 2) - 0.105729 * Math.Pow(10, -4) * Math.Pow(t, 3);
    }

    public static double CH2(int t)
    {
        return 64.496 + 0.066027 * t + 0.2241304 * Math.Pow(10, -2) * Math.Pow(t, 2) - 0.10560396 * Math.Pow(10, -4) * Math.Pow(t, 3);
    }

    public static double CH3(int t)
    {
        return 64.4724 + 8.1564207 * Math.Pow(10, -2) * t + 2.3034122 * Math.Pow(10, -4) * Math.Pow(t, 2.8) - 2.6492852 * Math.Pow(10, -5) * Math.Pow(t, 3.3) + 2.4826037 * Math.Pow(10, -8) * Math.Pow(t, 4.5);
    }

    public static double CH4(int t)
    {
        return 64.18 + 0.1348 * t + 5.31 * Math.Pow(10, -4) * Math.Pow(t, 2);
    }

    public static double CH5(int t)
    {
        return 63.608 + 0.133 * t + 7.22 * Math.Pow(10, -4) * Math.Pow(t, 2);
    }
}

public class Deviations
{
    public static double[] sum_of_squared_deviations(double []sum)
    {
        double[] exp_CH = { 64.44, 65.4, 66.74, 68.36, 70.22, 72.24, 74.32, 76.51, 78.74, 80.86 };
        int[] t = { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        for (int i = 0; i <= 9; i++)
        {
            sum[0] += Math.Abs(exp_CH[i] - Calc.CH1(t[i])) / 10;
            sum[1] += Math.Abs(exp_CH[i] - Calc.CH2(t[i])) / 10;
            sum[2] += Math.Abs(exp_CH[i] - Calc.CH3(t[i])) / 10;
            sum[3] += Math.Abs(exp_CH[i] - Calc.CH4(t[i])) / 10;
            sum[4] += Math.Abs(exp_CH[i] - Calc.CH5(t[i])) / 10;
        }
        return sum;
    }
}
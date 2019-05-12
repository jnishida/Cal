using System;
namespace Cal
{
    class Program
    {
        public static void Main(String[] args)
        {
            DateTime now = DateTime.Now;
            if (args.Length == 0)
            {
                CalBody(new DateTime(now.Year, now.Month, 1));
                return;
            }
            if (args.Length == 2)
            {
                try
                {
                    CalBody(new DateTime(int.Parse(args[0]), int.Parse(args[1]), 1));
                    return;
                }
                catch
                {
                    Console.WriteLine("エラー");
                    return;
                }
            }
            Console.WriteLine("エラー");
        }

        private static void CalBody(DateTime start)
        {
            Console.WriteLine(String.Format("{0}年{1}月", start.Year, start.Month));
            Console.WriteLine(" 日 月 火 水 木 金 土");
            for (DayOfWeek d = DayOfWeek.Sunday; d < start.DayOfWeek; d++)
            {
                Console.Write("   ");
            }
            for (DateTime d = start; d < start.AddMonths(1); d = d.AddDays(1))
            {
                Console.Write(String.Format("{0, 3}", d.Day));
                if (d.DayOfWeek == DayOfWeek.Saturday) {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}

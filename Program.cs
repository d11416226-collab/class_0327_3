using static System.Net.Mime.MediaTypeNames;

namespace class_0327_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Test std1 = new Test(78, 72);
                Test std2 = new Test(68, 84);

            std1.SetMid(88);
            std2.SetFinal(82);

                Console.WriteLine("1:"+std1.GetMid().ToString());
                Console.WriteLine("2:"+std2.GetFinal().ToString());
          }
    }
}

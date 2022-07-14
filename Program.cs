using System.Text;

namespace GCH1103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //bai 1
            Console.WriteLine("Bài tập 1");
            Console.WriteLine("Ngôn ngữ lập trình C#");
            int n, rows = 5, i, j; //declare
            //bai 2
            Console.WriteLine("Bài tập 2");
            n = 100;
            Console.WriteLine("n= {0}", n);
            n += 100;
            Console.WriteLine("n= {0}", n);
            //bai 3
            Console.WriteLine("Bài tập 3");
            Console.WriteLine("Hình dạng 1");
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Hình dạng 2");
            for (i = rows; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Hình dạng 3");
            for (i = 1; i <= rows; i++)
            {
                for (j = (rows - 1); j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Hình dạng 4");
            for (i = rows; i >= 1; i--)
            {
                for (j = (rows - 1); j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Hình dạng 5");
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Hình dạng 6");
            for(i = 1; i <= rows; i++)
            {
                for (j = 1; j < (2 * rows)  ; j++)
                {
                    if(i==1)
                    {
                        Console.Write("*");
                    }
                    else if((j < i) || (j > (2 * rows)  - i))
                    {
                        Console.Write(" ");
                    }
                    else {Console.Write("*");}
                }
                Console.Write("\n");
            }
            Console.WriteLine("Hình dạng 7");
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j < (2 * rows); j++)
                {
                    if (i == 1)
                    {
                        Console.Write("*");
                    }
                    else if ((j < i) || (j > (2 * rows) - i))
                    {
                        Console.Write(" ");
                    }
                    else { Console.Write("*"); }
                }
                Console.Write("\n");
            }
            for (i = 2; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Hình dạng 8");
            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 11; j++)
                {
                    if (i == 1 || j == 1 || i == 6 || j == 11)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            //bai 4
            Console.WriteLine("Bài tập 4");
            int dayso;
            Console.Write("Nhập dãy số: ");
            dayso = Convert.ToInt32(Console.ReadLine());
            for (; dayso != 0;)
            {
                int sotachra = dayso % 10;
                dayso /= 10;
                Console.Write("{0}  ",sotachra);
            }
            Console.WriteLine("\nBài tập 5");
            Console.Write("Nhập điểm thi lần 1: ");
            int lan1, lan2, lan3, canh1, canh2, canh3;
            double C, dientich, chuvi, canhhuyen;
            lan1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập điểm thi lần 2: ");
            lan2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập điểm thi lần 3: ");
            lan3 = Convert.ToInt32(Console.ReadLine());
            double diemtongket = lan1 * 0.25 + lan2 * 0.25 + lan3 * 0.5;
            Console.Write("Điểm tổng kết môn học C#: {0}",diemtongket);
            Console.WriteLine("\nBài tập 6");
            Console.Write("Nhập cạnh a: ");
            canh1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            canh2 = Convert.ToInt32(Console.ReadLine());
            canhhuyen = Math.Sqrt(Math.Pow(canh1,2)+ Math.Pow(canh2,2));
            chuvi = canh1 + canh2 + canhhuyen;
            dientich = (canh1 * canh2) / 2;
            Console.WriteLine("Chu vi tam giác vuông: {0}", chuvi);
            Console.WriteLine("Diện tích tam giác vuông: {0}", dientich);
            Console.WriteLine("Bài tập 7");
            Console.Write("Nhập cạnh a: ");
            canh1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            canh2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập cạnh c: ");
            canh3 = Convert.ToInt32(Console.ReadLine());
            chuvi = canh1 + canh2 + canh3;
            C = chuvi / 2;
            dientich = Math.Sqrt(C * (C - canh1) * (C - canh2) * (C - canh3));
            Console.WriteLine("Chu vi tam giác: {0}", chuvi);
            Console.WriteLine("Diện tích tam giác: {0}", dientich);
            Console.WriteLine("\nBài tập 8");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|         |                       |                       | Diem he so |             |             |             |");
            Console.WriteLine("|   STT   |     Ha hoc sinh       |                       |------------|  Diem TBKT  |   Diem thi  |  Diem TBMH  |");
            Console.WriteLine("|         |                       |                       |  HS1 | HS2 |             |             |             |");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|    1    |          HS001        |    Ngueyn Ngoc Anh    |   8  |  8  |     8.0     |      8      |     8.0     |");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|    2    |          HS002        |    Ngueyn Ba Nam      |   8  |  9  |     8.7     |      8      |     8.5     |");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|    3    |          HS003        |    Le Duc Tu          |   7  |  6  |     6.3     |      9      |     7.2     |");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|    4    |          HS004        |    Mac Van Chien      |   7  |  7  |     7.0     |      8      |     7.3     |");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|    5    |          HS005        |    Vu Dinh Toan       |   9  |  7  |     8.0     |      8      |     8.0     |");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|    6    |          HS006        |    Tran Ba Minh       |   9  |  10 |     9.7     |      10     |     9.8     |");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|    7    |          HS007        |    Ngo Dinh Tung      |   8  |  9  |     8.7     |      8      |     8.5     |");
            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|    8    |          HS008        |    Do Huu Nam         |   7  |  7  |     7.0     |      9      |     7.7     |");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
        }
    }
}
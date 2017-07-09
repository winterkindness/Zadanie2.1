// Класс «Шар». В классе определить поле с радиусом шара, автовычисляемые поля с площадью поверхности и объемом шара, 
// непараметризированный метод, вычисляющий объем куба, в который вписан шар, параметризированный метод, 
// вычисляющий объем шарового слоя по заданным высотам шаровых сегментов. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2._1
{
    class Ball                     // Класс "Шар"
    {
        public static int count = 0;
        public const double pi = 3.14;     // Число пи
        public static double radius;             // Поле: радиус шара
        public double height;                   // Высота
        public double area;        // Автовычисляемое поле: площадь поверхности
        public double volume;      // Автовычисляемое поле: объём шара
        public double Vcub;        // Объем куба, в который вписан шар
        public double Vs;          // Объем шарового слоя по заданным высотам шаровых сегментов
        

        //Конструктор класса

        public Ball(double _height, double _radius)
        {
            height = _height;
            radius = _radius;
            count++;
            area = 4 * pi * Math.Pow(radius, 2);
            volume = 4 * pi * Math.Pow(radius, 3)/3;
        }

        // Непараметризированный метод, вычисляющий объем куба, в который вписан шар

        public void Vc () 
        {
            Vcub = Math.Pow(2 * radius, 3);
        }

        // Параметризированный метод, вычисляющий объем шарового слоя по заданным высотам шаровых сегментов

        public void Vss(double _height, double _radius)
        {
           height = _height;
           radius = _radius;
           Vs = pi* Math.Pow(height,2)*(radius-height/3);      
        }

        

        public void Print()
        {
            Console.WriteLine("Шар № " + count);
            Console.WriteLine("Радиус шара: " + radius);
            Console.WriteLine("Высота шара: " + height);
            Console.WriteLine("Площадь поверхности шара: " + area);
            Console.WriteLine("Объем шара: " + volume);
            Console.WriteLine("Объем куба, в который вписан шар: " + Vcub);
            Console.WriteLine("Объем шарового слоя по заданным высотам шаровых сегментов: " + Vs);
            
        }
        
        // Параметризированный метод, вычисляющий объем шарового слоя по заданным высотам шаровых сегментов
    }
    class Program
    {
       public static void Main(string[] args)
        {

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Введите радиус:");
               double  _radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите высоту:");
               double _height = Convert.ToInt32(Console.ReadLine());
                Ball ball = new Ball(_height, _radius);
                ball.Vc();
                ball.Vss(_height,_radius);
                ball.Print();
            }
           
            Console.ReadKey();
        }
    }
}

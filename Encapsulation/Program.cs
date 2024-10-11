using Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point();
			//Console.WriteLine($"X = {A.GetX()}\tY ={A.GetY()}");
			/*A.SetX(200);
			A.SetY(300);
			A.Print();*/
			A.X = 2;
			A.Y = 2;
			A.Print();
			Point B = new Point();
			B.X = 4;
			B.Y = 6;
			B.Print();

			
		}
		

	}

}

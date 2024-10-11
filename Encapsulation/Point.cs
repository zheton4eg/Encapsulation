using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation



{ class Point
	{
		/*double x;
		double y;
		public double X
		{
			get
			{
				return x;
			}
			set
			{
				if (value > 200) value = 200;
				x = value;
			}
		}
		public double Y
		{
			get
			{
				return y;
			}
			set
			{
				if (value > 200) value = 150;
				y = value;
			}
		}
		public double GetX()
		{
			return x;
		}
		public double GetY()
		{
			return y;
		}
		public void SetX(double x)
		{
			if (x > 200) x = 200;
			this.x = x;
		}
		public void SetY(double y)
		{
			if (y > 150) y = 150;
			this.y = y;
		}*/

		public double X { get; set; }
		public double Y { get; set; }

		
		public double Distance(Point other)
		{
			double XDistance = this.X-other.X;
			double YDistance=this.Y-other.Y;
			double Distance = Math.Sqrt(XDistance* XDistance+ YDistance* YDistance);
			return Distance;
		}

		public double Distance(Point left,Point right)
		{
			double XDistance = left.X - right.X;
			double YDistance = left.Y - right.Y;
			double Distance = Math.Sqrt(XDistance * XDistance + YDistance * YDistance);
			return Distance;
		}

		public Point(double x=0, double y = 0)
		{
			X = x;
			Y = y;
			Console.WriteLine($"DefaultConstructor:{this.GetHashCode()}");
		}
		public Point(Point other)
		{
			this.X = other.X;
			this.Y = other.Y;
			Console.WriteLine($"CopyConstructor{this.GetHashCode()}");
		}
		~Point()
		{
			Console.WriteLine($"Destructor:{this.GetHashCode()}");
		}
		public static Point operator+(Point left, Point right)
		{
Point resoult = new Point();
			resoult.X = left.X+right.X;
			resoult.Y = left.Y+right.Y;	
			return resoult;
		}
		public static Point operator -(Point left, Point right)
		{
			
			
			return new Point(left.X - right.X,
			                 left.Y - right.Y);
		}

		public static Point operator ++(Point obj)
		{
			obj.X++;
			obj.Y++;
			return obj;
		}
		public static bool operator==(Point left, Point right)
		{
			return left.X==right.X&&left.Y==right.Y;
		}
		public static bool operator !=(Point left, Point right)
		{
			return !(left==right);
		}
		public void Print()
		{
			Console.WriteLine($"X = {X}\tY ={Y}\t{this.GetHashCode()}");
			/*Console.WriteLine($"X = {GetX()}\tY ={GetY()}");*/
		}

	}
}


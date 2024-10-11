﻿using System;
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
		public void Print()
		{
			Console.WriteLine($"X = {X}\tY ={Y}");
			/*Console.WriteLine($"X = {GetX()}\tY ={GetY()}");*/
		}

	}
}


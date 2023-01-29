namespace UML
{
	public class Shape
	{
		protected Location c;
		public Shape(Location c)
		{
			this.c = c;
		}
		public virtual string ToString()
		{
			return string.Empty;
		}
		public virtual double Area()
		{
			return 0.00;
		}
		public virtual double Perimeter()
		{
			return 0.00;
		}
	}
	public class Location
	{
		private double x, y;

		public Location(double x, double y)
		{
			this.x = x;
			this.y = y;
		}
		public void setX(double x)
		{
			this.x = x;
		}

		public double getX()
		{
			return this.x;
		}

		public void setY(double y)
		{
			this.y = y;

		}

		public double getY()
		{
			return this.y;
		}
	}
	public class Rectangle : Shape
	{
		protected double side1, side2;
		public Rectangle(double side1, double side2, Location c) : base(c)
		{
			this.side1 = side1;
			this.side2 = side2;
			this.c = c;
		}

		public override double Area()
		{
			return Math.Round((side1 * side2), 2);
		}
		public override double Perimeter()
		{
			return Math.Round((2 * (side1 + side2)), 2);
		}
		public override string ToString()
		{
			return $"Location: ({c.getX()}, {c.getY()})" +
				$"\nSide: {side1}, {side2}";
		}
	}
	public class Circle : Shape
	{
		protected double radius;
		public Circle(double radius, Location c) : base(c)
		{
			this.radius = radius;
			this.c = c;
		}

		public override double Area()
		{
			return Math.Round((Math.PI * Math.Pow(radius, 2)), 2);
		}

		public override double Perimeter()
		{
			return Math.Round((2 * Math.PI * radius), 2);
		}

		public override string ToString()
		{
			return $"Location: ({c.getX()}, {c.getY()})" +
				$"\nRadius {radius}";
		}
	}
	class Program
	{
		private static void Main(string[] args)
		{
			int shape_type;
			double x, y, side1, side2, radius;
			Shape shape = null;

			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("      MODULE 3: Rectangle or Circle      ");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

			Console.WriteLine("What shape would you want to compute?: ");
			Console.WriteLine("  [1] Rectangle");
			Console.WriteLine("  [2] Circle");
			Console.Write("\nEnter shape type: ");
			shape_type = int.Parse(Console.ReadLine());

			Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

			if (shape_type == 1 || shape_type == 2)
			{
				Console.WriteLine("Enter Location of the center");
				Console.Write("  x coordinate: ");
				x = double.Parse(Console.ReadLine());
				Console.Write("  y coordinate: ");
				y = double.Parse(Console.ReadLine());

				Location c = new Location(x, y);

				Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

				if (shape_type == 1)
				{
					Console.WriteLine("                Rectangle                ");
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

					Console.Write("Enter length: ");
					side1 = double.Parse(Console.ReadLine());
					Console.Write("Enter width: ");
					side2 = double.Parse(Console.ReadLine());

					shape = new Rectangle(side1, side2, c);
				}
				else if (shape_type == 2)
				{
					Console.WriteLine("                  Circle                 ");
					Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

					Console.Write("Enter radius: ");
					radius = double.Parse(Console.ReadLine());

					shape = new Circle(radius, c);
				}
			}
			else
			{
				Console.WriteLine("            Invalid shape type           ");
			}

			Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

			Console.WriteLine("\n" + shape.ToString());
			Console.WriteLine("Area: " + shape.Area());
			Console.WriteLine("Perimeter: " + shape.Perimeter());

			Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		}
	}
}
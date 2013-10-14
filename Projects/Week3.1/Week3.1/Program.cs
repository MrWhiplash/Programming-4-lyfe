using System;

namespace structandstuff
{


	struct Point
	{
		//private Def
		private float _x;
		private float _y;

		//public Def
		public float X
		{
			get {return _x;}
			set {_x = value;}
		}

		public float Y
		{
			get{return _y;}
			set{ _y = value;}
		}
		//END PUBLIC DEF
	

		public Point(float _x, float _y)
		{
			this._x = _x;
			this._y = _y;

		}
	
		public override string ToString()
		{
			return "(" + _x + ", " + _y + ")";
		}

	}
	struct Circle
	{
		private float _ciry;
		private float _cirx;
		private float _radius;

		public Circle(float cirx,float ciry, float radius)
		{
			this._cirx = cirx;
			this._ciry = ciry;
			this._radius = radius;
		}

		public float X
		{
			get{return X;}
		}

	

		public float Circumference
		{
			get{return((float)2 * (float)Math.PI * _radius);}

		}
		public override string ToString()
		{
			return "(" + Circumference + ")";
		}
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			Point point1 = new Point (12, 14);
			Circle cirPoint = new Circle (12,14,3);
			Console.WriteLine(point1.ToString ());
			Console.WriteLine (cirPoint.ToString());
		}
	}
}

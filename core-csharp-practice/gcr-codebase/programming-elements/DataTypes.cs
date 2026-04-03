using System;

class DataTypes{
	static void Main(){
		
		// Primitive DataTypes
		
		// byte
		byte age = 21;
		Console.WriteLine(age.GetType());
		Console.WriteLine(age);
		
		// short 
		short temp = -137;
		Console.WriteLine(temp.GetType());
		Console.WriteLine(temp);
		
		// int 
		int salary = 25000;
		Console.WriteLine(salary.GetType());
		Console.WriteLine(salary);
		
		
		// long 
		long population = 4500000000;
		Console.WriteLine(population.GetType());
		Console.WriteLine(population);
		
		// float
		float percentage = 72.5f;
		Console.WriteLine(percentage.GetType());
		Console.WriteLine(percentage);
		
		// double
		double pi = 3.1415926536793753d;
		Console.WriteLine(pi.GetType());
		Console.WriteLine(pi);
		
		// char
		char grade = 'A';
		Console.WriteLine(grade.GetType());
		Console.WriteLine(grade);
		
		// bool 
		bool isPassed = true;
		Console.WriteLine(isPassed.GetType());
		Console.WriteLine(isPassed);
		
		// console writeline remove unecessary value
		int a = 5;
		float f = (float)a;
		
		// but whlite writline remove the trailing zeros
		int b = 5;
		float f1 = b;
		Console.WriteLine(f.ToString("0.0"));
		
		
		// implicit conversion
		
			char c = 'A';
			
			int num11 = c;
			
			long num12 = num11;
			
			float num13 = num12;
			
			double num14 = num13;
			
			Console.WriteLine(c);
			
			Console.WriteLine(num11);
			
			Console.WriteLine(num12);
			
			Console.WriteLine(num13);
			
			Console.WriteLine(num14);
			
		// explicit conversion
		
			char ch = Convert.ToChar(65);
			
			int num21 = Convert.ToInt32(222134532L);
			
			Console.WriteLine(ch);
			
			Console.WriteLine(num21);
		
		
	}
}
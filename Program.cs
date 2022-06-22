using System;

namespace Tutorials_Teacher //Namespace Name
{
	class Program //Class Name
	{
		static void Main(string[] args) //Method
		{

			string /*Data Type*/ message /*Variable Name*/ = "Hello" /*Variable Value*/;

			Console.WriteLine(message) /*Method to display value on the console*/;

			@class.NumberProperty = 100; /*Setting the number property from the other class to 100*/

			Console.WriteLine(@class.NumberProperty);
		}
	}

	public class @class /* calling a class "class" when prefixed with an @*/
	{
		public static int NumberProperty { get; set; }

	}


}

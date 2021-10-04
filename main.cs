using System;

class MainClass {
  public static void Main (string[] args) 
	{

		MyName.details();
		Console.WriteLine("First Name : {0}", MyName.fName);
		Console.WriteLine("Last Name : {0}", MyName.lName);
    
  }

	public static class MyName
	{
		public static string fName = "Bob";
		public static string lName = "Lazar";

	public static void details()
	{
		Console.WriteLine("Here is my name: ");
	}
	}
}
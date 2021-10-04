using System;

class MainClass {
  public static void Main (string[] args) 
	{

		MyName.details();
		
    
  }

	public static class MyName
	{
		public static string fName = "Bob";
		public static string lName = "Lazar";

	public static void details()
	{
	Console.WriteLine("My first and last name are: ");
	Console.WriteLine("First Name : {0}", MyName.fName);
	Console.WriteLine("Last Name : {0}", MyName.lName);
	}
	}
}
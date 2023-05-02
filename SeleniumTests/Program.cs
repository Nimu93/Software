
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
	public class Program
	{
		public static void TestCase(string type, int age)
        {
			IWebDriver driver = new ChromeDriver();

			driver.Navigate().GoToUrl("https://s00244753.github.io/");
			IWebElement input_text = driver.FindElement(By.Id("location"));
			Thread.Sleep(2000);

			IWebElement input_age = driver.FindElement(By.Name("age"));
			Thread.Sleep(2000);

			IWebElement button = driver.FindElement(By.ClassName("button"));
			Thread.Sleep(2000);

			input_text.SendKeys(type);
			input_age.SendKeys(age.ToString());
			button.Click();

			Thread.Sleep(10000);
			Console.WriteLine();
			driver.Close();
		}
		public static void Test1()
        {
			TestCase("rural", 12);
			
		}
		public static void Test2()
		{
			TestCase("rural", 24);

		}
		public static void Test3()
		{
			TestCase("rural", 42);

		}
		public static void Test4()
		{
			TestCase("rural", 62);

		}
		public static void Test5()
		{
			TestCase("urban", 15);

		}
		public static void Test6()
		{
			TestCase("urban", 52);
		}
		public static void Test7()
        {
			TestCase("urban", 28);

		}
		public static void Test8()
		{
			TestCase("urban", 41);
		}
		public static void Test9()
		{
			TestCase("urban", 65);

		}
		public static void Main(string[] args)
        {
			Test1();
			Test2();
			Test3();
			Test4();
			Test5();
			Test6();
			Test7();
			Test8();
			Test9();
        }
	}
}
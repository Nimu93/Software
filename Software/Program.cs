using NUnit.Framework;

namespace Software
{

	public class Program
    {
		/*public static void Main(string[] args)
        {
			InsuranceService insuranceService = new InsuranceService();
			insuranceService.CalcPremium(17, "rural");
			//new Software();
		}*/
    }
	[TestFixture]
    public class Software
    {

		InsuranceService insuranceService;
		[SetUp]
		public void Setup()
        {
			insuranceService = new InsuranceService();
		}

        [Test]
		public void Test1()
        {
			Assert.AreEqual(0, insuranceService.CalcPremium(17,"rural"));
        }
		[Test]
		public void Test2()
		{
			Assert.AreEqual(5, insuranceService.CalcPremium(25, "rural"));
		}
		[Test]
		public void Test3()
		{
			Assert.AreEqual(2.5, insuranceService.CalcPremium(35, "rural"));
		}
		[Test]
		public void Test4()
		{
			Assert.AreEqual(0, insuranceService.CalcPremium(15, "urban"));
		}
		[Test]
		public void Test5()
		{
			Assert.AreEqual(6, insuranceService.CalcPremium(22, "urban"));
		}
		[Test]
		public void Test6()
		{
			Assert.AreEqual(4.5, insuranceService.CalcPremium(52, "urban"));
		}
		[Test]
		public void Test7()
		{
			Assert.AreEqual(0, insuranceService.CalcPremium(25, "other"));
		}
	}

	public class InsuranceService
	{

	public double CalcPremium(int age, string location)
	{
		double premium;

			if (location == "rural") {
				if ((age >= 18) && (age < 30)) {
					premium = 5.0;
				}
				else
				{
					if (age >= 31)
					{
						premium = 2.50;
					}
					else
					{
						premium = 0.0;
					}
				}
			}
			else
		if (location == "urban") {
				if ((age >= 18) && (age <= 35))
				{
					premium = 6.0;
				}
				else
				{
					if (age >= 36) {
						premium = 5.0;
					}
					else {
						premium = 0.0;
					}
				} 
			}
			else
				premium = 0.0;

		DiscountService ds = new DiscountService();
		double discount = ds.GetDiscount();
		if (age >= 50)
			premium = premium * discount;
		return premium;
	}
}

	public class DiscountService
    {
		private double discount = 0.9;
		public DiscountService() { }
		public double GetDiscount() { return discount; }

    }


}

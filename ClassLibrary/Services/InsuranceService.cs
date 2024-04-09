namespace ClassLibrary.Services
{
    public class InsuranceService
    {
        private readonly DiscountService _discountService;

        public InsuranceService(DiscountService discountService)
        {
            _discountService = discountService;
        }

        public double CalcPremium(int age, string location)
        {
            double premium = 0.0;


            if (location == "rural")
            {
                if (age >= 18 && age <= 30)
                    premium = 5.0;
                else if (age >= 31)
                    premium = 3.50;
                else
                    premium = 0.0;
            }
            else if (location == "urban")
            {
                if (age >= 18 && age <= 35)
                    premium = 6.0;
                else if (age >= 36)
                    premium = 5.0;
                else
                    premium = 0.0;
            }
            else
            {
                premium = 0.0;
            }


            if (age >= 50)
                premium *= _discountService.GetDiscount();


            return premium;
        }

    }
}
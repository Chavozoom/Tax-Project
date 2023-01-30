namespace Training.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpeditures { get; set; }
        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpeditures) : base(name, anualIncome)
        {
            HealthExpeditures = healthExpeditures;
        }
        public override double Tax()
        {
            if (HealthExpeditures > 0)
            {
                if (AnualIncome < 20000.00)
                {
                    return AnualIncome * 0.15 - HealthExpeditures * 0.5;
                }
                else
                {
                    return AnualIncome * 0.25 - HealthExpeditures * 0.5;
                }

            }
            else
            {
                if (AnualIncome < 20000.00)
                {
                    return AnualIncome * 0.15;
                }
                else
                {
                    return AnualIncome * 0.25;
                }
            }
        }
    }
}

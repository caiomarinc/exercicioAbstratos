namespace ExercicioPropostoMetodosAbstratos.Entities;
internal class PhysicalPerson : Person
{
    public double HealthExpenditures { get; set; }

    protected override int GetTaxPercentage()
    {
        if (AnnualIncome >= 20000)
        {
            return 25;
        }
        return 15;
    }

    public override double CalcTax()
    {
        return (GetTaxPercentage() * AnnualIncome) / 100.0 - HealthExpenditures / 2.0;
    }
}

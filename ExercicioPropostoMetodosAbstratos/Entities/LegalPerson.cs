namespace ExercicioPropostoMetodosAbstratos.Entities;
internal class LegalPerson : Person
{
    public int Employees { get; set; }

    protected override int GetTaxPercentage()
    {
        if (Employees > 10)
        {
            return 14;
        }
        return 16;
    }

    public override double CalcTax()
    {
        return (GetTaxPercentage() * AnnualIncome) / 100.0;
    }
}
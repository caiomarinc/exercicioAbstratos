namespace ExercicioPropostoMetodosAbstratos.Entities;
abstract class Person
{
    public string Name { get; set; }

    public double AnnualIncome { get; set; }


    protected abstract int GetTaxPercentage();

    public abstract double CalcTax();
}
namespace FietsRoutesLib.Interfaces
{
    public interface IFietsModel
    {
        string Merk { get; set; }
        string SoortFiets { get; set; }
        string FietsMateriaal { get; set; }
        int AantalVersnellingen { get; set; }
        string TypeRem { get; set; }
        string Wielset { get; set; }
    }
}

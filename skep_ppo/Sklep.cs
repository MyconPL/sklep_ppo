namespace skep_ppo;

public class Sklep
{


    private string Nazwa { get; set; }
    private int Rok_Powstania { get; set; }
    private int NIP { get; set; }

    public abstract Powitanie()

    public Sklep(string nazwa, int rokPowstania, int nip)
    {
        Nazwa = nazwa;
        Rok_Powstania = rokPowstania;
        NIP = nip;
    }
    public void Get_Store_Info()
    {
        Console.WriteLine($"Nazwa: {Nazwa}");
        Console.WriteLine($"Rok Powstania: {Rok_Powstania}");
        Console.WriteLine($"NIP: {NIP}");
    }

    public void Sposob_Platnosci(float kwotaZamowienia)
    {
        
    }
    
}
namespace SklepyApp
{
    public class SklepZoologiczny : Sklep
    {
        public SklepZoologiczny(string nazwa, int rokPowstania, string nip)
            : base(nazwa, rokPowstania, nip)
        {
        }

        public override string Info()
        {
            return $"Sklep zoologiczny: {Nazwa}, rok założenia: {RokPowstania}";
        }

        public override string MetodaPlatnosci()
        {
            return "Płatność: BLIK";
        }

        public override string Powitanie()
        {
            return $"Zapraszamy do sklepu zoologicznego {Nazwa}!";
        }
    }
}
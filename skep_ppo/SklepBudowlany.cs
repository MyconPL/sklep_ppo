namespace SklepyApp
{
    public class SklepBudowlany : Sklep
    {
        public SklepBudowlany(string nazwa, int rokPowstania, string nip)
            : base(nazwa, rokPowstania, nip)
        {
        }

        public override string Info()
        {
            return $"Sklep budowlany: {Nazwa}, rok założenia: {RokPowstania}";
        }

        public override string MetodaPlatnosci()
        {
            return "Płatność: gotówka";
        }
    }
}
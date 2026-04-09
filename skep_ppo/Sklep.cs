using System.Text.RegularExpressions;

namespace SklepyApp
{
    public abstract class Sklep
    {
        private string nazwa;
        private int rokPowstania;
        private string nip;

        public string Nazwa
        {
            get => nazwa;
            set => nazwa = value ?? throw new ArgumentNullException(nameof(Nazwa));
        }

        public int RokPowstania
        {
            get => rokPowstania;
            set
            {
                if (value < 1800 || value > DateTime.Now.Year)
                    throw new ArgumentException("Niepoprawny rok powstania.");
                rokPowstania = value;
            }
        }

        public string NIP
        {
            get => nip;
            set
            {
                if (!WalidujNip(value))
                    throw new ArgumentException("Niepoprawny NIP.");
                nip = value;
            }
        }

        protected Sklep(string nazwa, int rokPowstania, string nip)
        {
            Nazwa = nazwa;
            RokPowstania = rokPowstania;
            NIP = nip;
        }

        private bool WalidujNip(string nip)
        {
            return Regex.IsMatch(nip, @"^\d{10}$");
        }

        public abstract string Info();
        public abstract string MetodaPlatnosci();

        public virtual string Powitanie()
        {
            return $"Witamy w sklepie {Nazwa}!";
        }

        public virtual string PokazNazwe()
        {
            return $"Nazwa sklepu: {Nazwa}";
        }
    }
}
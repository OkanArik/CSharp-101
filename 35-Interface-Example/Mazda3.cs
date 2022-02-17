    namespace Interface_Example
    {
    public class Mazda3 : IOtomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.Mazda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}

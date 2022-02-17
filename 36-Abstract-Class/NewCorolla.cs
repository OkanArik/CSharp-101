namespace Abstract_Class
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkanınAracı()
        {
            return Marka.Toyota;
        }

        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}
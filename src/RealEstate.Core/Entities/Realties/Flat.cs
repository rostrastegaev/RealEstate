namespace RealEstate.Core
{
    public class Flat : Realty
    {
        public int Rooms { get; private set; }

        public override RealtyType Type => RealtyType.Flat;

        public void Update(Flat flat)
        {
            Rooms = flat.Rooms;
            base.Update(flat);
        }
    }
}

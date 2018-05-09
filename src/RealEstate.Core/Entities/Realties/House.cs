namespace RealEstate.Core.Entities.Realties
{
    public class House : Realty
    {
        public int Rooms { get; private set; }
        public int Floors { get; private set; }

        public override RealtyType Type => RealtyType.House;

        public void Update(House house)
        {
            Rooms = house.Rooms;
            Floors = house.Floors;
            base.Update(house);
        }
    }
}

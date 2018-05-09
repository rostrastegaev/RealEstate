namespace RealEstate.Core.Entities.Realties
{
    public class Room : Realty
    {
        public override RealtyType Type => RealtyType.Room;

        public void Update(Room room)
        {
            base.Update(room);
        }
    }
}

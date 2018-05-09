namespace RealEstate.Core
{
    public abstract class Realty : Entity
    {
        public Location Location { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public double Area { get; private set; }

        public abstract RealtyType Type { get; }

        protected void Update(Realty realty)
        {
            Location = realty.Location;
            Description = realty.Description;
            Price = realty.Price;
            Area = realty.Area;
            Update();
        }
    }
}


namespace Object_orientedProgramming.Business
{
    public abstract class Drink
    {
        public int Quantity { get; set; }

        protected Drink(int quantity)
        {
            this.Quantity = quantity;
        }

        public string GetQuantity()
        {
            return Quantity + " ml"; ;
        }


        public abstract string GetCategory();



    }
}

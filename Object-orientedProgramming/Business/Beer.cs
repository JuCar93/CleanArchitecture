

namespace Object_orientedProgramming.Business
{
    public class Beer
    {
        private decimal _alcohol; //Campo de respaldo del metodo Value y solo visible para esta clase, ni si quiera las clases que heredan pueden acceder a el
        public string Name { get; set; }
        protected decimal Price { get; set; } //Pueden acceder aa el esta clase y las clases hijas de esta, pero no clases externas

        public string SAlcohol {
            get
            {
                return "Alcohol: " + _alcohol.ToString();
            }
        
        }

        public decimal Alcohol
        {
            get { return _alcohol; }

            set
            {

                if (value < 0) // La palabra value evalua el valor que se le quiere asignar al la propiedad antes de asignarlo
                {
                    value = 0;
                }

                _alcohol = value;
            }
        }
      
        public Beer(string name, decimal price, decimal alcohol)
        {
            this.Name = name;
            this.Price = price;
            this.Alcohol = alcohol;

        }

        public virtual string GetInfo()
        {
            return "Nombre: " + Name + ", Precop: $" + Price + ", Alcohol: " + Alcohol;
        }


        public string GetInfo(string Message)
        {
            return Message + GetInfo();
        }


        public string GetInfo(int number)
        {
            return number +".- "+ GetInfo();
        }


    }
}




 

Beer erdingerBeer = new Beer("Erdinger", 3,-2);



Console.WriteLine(erdingerBeer.Name);


public class Beer
{

    private decimal _alcohol; //Campo de respaldo del metodo Value
    public string Name { get; set; }
    public decimal Price { get; set; }

    public decimal Alcohol
    {
        get { return _alcohol; }

        set {

            if (value < 0) // La palabra value evalua el valor que se le quiere asignar al la propiedad antes de asignarlo
            {
                value = 0;
            }

            _alcohol = value;
        }
    }
    public Beer()
    {
        
    }

    public Beer( string name, decimal price, decimal alcohol)
    {
        this.Name = name;
        this.Price = price;
        this.Alcohol = alcohol;
        
    }

    public string GetInfo()
    {
        return "Nombre: "+Name+", Precop: $"+Price+", Alcohol: "+Alcohol;
    }

    
}
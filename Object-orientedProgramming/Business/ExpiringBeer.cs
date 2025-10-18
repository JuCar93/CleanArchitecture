using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_orientedProgramming.Business
{
    public class ExpiringBeer : Beer
    {

        public DateTime Expiration { get; set; }

        public ExpiringBeer(string name, decimal price, decimal alcohol, DateTime expiration)
            :base(name, price, alcohol) // base invoca al constructor del padre 
        {
         
           Expiration = expiration; // aqui solo se asigna el valor de Expiration, ya que los otros que recibe ya se lo asigna en la clase Beer y solo es necesario enviarlo cuando se instancia la clase ExpirationBeer
        }

        public override string GetInfo()
        {
            return "Cerveza con caducidad:" + Name + ", " +
                "Precio: $"+Price+", Alcohol: "+ Alcohol+
                ", caducidad:"+Expiration.Date.ToString();

                
        }
    }
}

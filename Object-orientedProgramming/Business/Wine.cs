using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_orientedProgramming.Business
{
    public class Wine : Drink
    {
        private const string Category = "Vino";
        public Wine(int quantity) : base(quantity)
        {
        }

        public override string GetCategory()=>
            Category; //Esto solo se puede hacer cuando se tiene una sola linea de codigo y no es necesario pasar las llaves, se ahorra la palabra return
        
    }
}

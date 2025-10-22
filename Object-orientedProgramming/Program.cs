using Object_orientedProgramming.Business;


 

Beer erdingerBeer = new Beer("Erdinger", 3,-2,355);
var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024, 12, 01),355); // Al instanciar deliruum se mandan los 3 parametros que necesita la clase Beer y un parametro mas que necesita ExpiringBeer

//Drink drink =new Drink(); //No se puede crear un objeto drink porque es abstracta esa clase

//Drink drink = new Beer("Delirium", 4, 8, 355); // se´puede crear un objeto de la clase abstracta pero invocando a uno de los que la heredan
//drink.Quantity = 1;//esto nos limita a solo usar las propiedades del la clase abstracta más no la de la que la heredan


//Console.WriteLine(delirium.GetCategory());
//Console.WriteLine(erdingerBeer.GetInfo());
//Console.WriteLine(delirium.GetInfo()); // podemos utilizar los metodos de la clase Beer porque heredamos de ella
//Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));//Mismo metodo diferentes parametros
//Console.WriteLine(delirium.GetInfo(1));//Mismo metodo diferentes parametros => aqui como se sobreescribe el metodo GetInfo que se utiliza aqui se cambia por el sobreescrito


Drink drink = new Wine(500);

//Show(drink);


drink = new Beer("Corona", 23, 6, 355);
//Show(drink);

//Show(erdingerBeer);
void Show(Drink drink)
    => Console.WriteLine(drink.GetCategory());



SendSome(erdingerBeer);
SendSome(delirium);


var service = new Service(100, 10);


service.GetPrice();


//Aqui vamos a listar conceptos que pueden ser vendibles con un array y que  inplementan el metodo Isellable


ISalable[] concepts = [
    erdingerBeer,
    delirium,
    service // aqui entra todo tipo de clases que son Vendibles sin importar que no se trate de lo mismo
    
    ];



Console.WriteLine(GetTotal(concepts));

//SendSome(drink); En este caso no se puede usar drink, que aunque este inicializado como Beer desde un principio se pone que es un objeto Drink, el cual no implementa a ISend


void SendSome(ISend some) // Este metodo recibe un pbjeto de la interface ISend
{
    some.Send(); //Cualquier clase que implemente ISend tiene un metodo implementado llamado Send();
}


decimal GetTotal(ISalable[] concepts)
{
    decimal total = 0;
    foreach (var item in concepts)
    {
        total += item.GetPrice();
    }

    return total;
}
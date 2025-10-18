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

Show(drink);


drink = new Beer("Corona", 23, 6, 355);
Show(drink);

Show(erdingerBeer);
void Show(Drink drink)
    => Console.WriteLine(drink.GetCategory());


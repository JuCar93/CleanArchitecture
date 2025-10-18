using Object_orientedProgramming.Business;


 

Beer erdingerBeer = new Beer("Erdinger", 3,-2);
var delirium = new ExpiringBeer("Delirium", 4, 8, new DateTime(2024, 12, 01)); // Al instanciar deliruum se mandan los 3 parametros que necesita la clase Beer y un parametro mas que necesita ExpiringBeer


Console.WriteLine(erdingerBeer.GetInfo());
Console.WriteLine(delirium.GetInfo()); // podemos utilizar los metodos de la clase Beer porque heredamos de ella
Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));//Mismo metodo diferentes parametros
Console.WriteLine(delirium.GetInfo(1));//Mismo metodo diferentes parametros => aqui como se sobreescribe el metodo GetInfo que se utiliza aqui se cambia por el sobreescrito





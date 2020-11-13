using System;

class MainClass {
  public static void Main (string[] args) {
    Caballo miBabieca = new Caballo("Babieca");
		Humano miJuan = new Humano("Juan");
		Gorila miGorila = new Gorila("Gorila");
    Ballena miBallena = new Ballena("Moby");

		//array de los objetos 
		Mamiferos[] almacenMamiferos = new Mamiferos[4];
		almacenMamiferos[0] = miBabieca;
		almacenMamiferos[1] = miJuan;
		almacenMamiferos[2] = miGorila;
    almacenMamiferos[3] = miBallena;
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("El número de patas de caballo son: " + miBabieca.numeroPatas());
    Console.WriteLine("El número de patas del gorila son: " + miGorila.numeroPatas());
    Console.WriteLine("---------------------------------------------------");
    //polimorfismo
    Console.WriteLine("Ejemplo de polimorfismo:");
    for(int i = 0; i<4;i++){
      almacenMamiferos[i].pensar();
      almacenMamiferos[i].getNombre();
    }
  }
}

//creacion de intefaces
//obliga a seguir parametros cuando se crean nuevas clases. Interface es un conjunto de directrices que deben cumplir las clases
//en las interfaces no hay codigo solo se declaran, no hay llaves, no indicar public ni private 
interface IMamiferoTerrestre{
  int numeroPatas();
}  

class Mamiferos{//superclase
  private string nombreSerVivo;
  
  //contructor
	public Mamiferos(string nombre){
		nombreSerVivo = nombre;
	}

	public void respirar(){
		Console.WriteLine("Soy capaz de respirar");
	}
	public void cuidarCrias(){
		Console.WriteLine("Soy capaz de cuidad crías");
	}
	public virtual void pensar(){
	  Console.WriteLine("Pensamiento básico e instintivo");
	}
	public void getNombre(){
		Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
	}
  
}

//subclases
class Ballena:Mamiferos{
  public Ballena(string nombreBallena):base(nombreBallena){}
  public void nadar(){
    Console.WriteLine("Soy capaz de nadar");
  }
}
//en la clase caballo se agrego despues del nombre de la superclase el nombre de la interface, se dee respetar ese orden en c#
class Caballo:Mamiferos, IMamiferoTerrestre{
	public Caballo(string nombreCaballo):base(nombreCaballo){}
	public void galopar(){
		Console.WriteLine("Soy capaz de galopar");
	}
  public int numeroPatas(){
    return 4;
  }
}
class Humano:Mamiferos{
	public Humano(string nombreHumano):base(nombreHumano){}
	public override void pensar(){
		Console.WriteLine("Soy capaz de pensar");
	}
}
class Gorila:Mamiferos, IMamiferoTerrestre{
	public Gorila(string nombreGorila):base(nombreGorila){}
	public void trepar(){
		Console.WriteLine("Soy capaz de trepar");
	}
  public override void pensar(){
    Console.WriteLine("Pensamiento animal");
  }
  public int numeroPatas(){
    return 2;
  }
}

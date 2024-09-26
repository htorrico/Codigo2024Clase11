
using Demo02;

//Problema: No podemos aplicar herencia múltiple
void EjemploClaseAbstracta()
{

    Vehiculo bicicleta = new Bicicleta(); //Característica de las clases abstractas
    Bicicleta bicicleta1 = new Bicicleta();

    bicicleta.Encender();//Está implementada en el hijo
    bicicleta.Mostrar();//Está implementada en el padre (Clase Abstracta)

    bicicleta1.Encender();
    bicicleta1.Mostrar();
}



//MotoCicleta motoCicleta = new MotoCicleta();
//motoCicleta.Arrancar();
//motoCicleta.Acelerar(20);



MotorElectrico motorElectrico = new MotorElectrico();
MotorGAS motorGAS = new MotorGAS();
MotorGAS motorGAS2 = new MotorGAS();


motorElectrico.Arrancar();
motorElectrico.Apagar();

motorGAS.Arrancar();
motorGAS.Apagar();

motorGAS2.Arrancar();
motorGAS2.Apagar();


List<IMotor> motores = new List<IMotor>();

motores.Add(new MotorGAS());
motores.Add(new MotorElectrico());
motores.Add(new MotorElectrico());


foreach (var item in motores)
{
    //Polimorfismo
    item.Arrancar();
    item.Apagar();
}

Console.ReadLine();



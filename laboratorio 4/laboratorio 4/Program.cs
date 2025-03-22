using laboratorio_4.MisClases;

AutoDeCombustión MiAuto =  new AutoDeCombustión(2020, "Rojo", "Toyota", 10);

Motocicleta Minena = new Motocicleta(2016, "Negro", "Yamaha", 50);

Camión Coloso = new Camión(2025, "Blanco", "Cat", 5000);

MiAuto.InformacionVehiculo();
MiAuto.Encender();
MiAuto.Acelerar(100);
MiAuto.Frenar();
MiAuto.Apagar();

Minena.InformacionVehiculo();
Minena.Encender();
Minena.ColocarCasco();
Minena.Acelerar(150);
Minena.Frenar();
Minena.QuitarCasco();
Minena.Apagar();

Coloso.InformacionVehiculo();
Coloso.Encender();
Coloso.AcoplarRemolque();
Coloso.CargarMercancia(3000);
Coloso.Acelerar(120);
Coloso.Frenar();
Coloso.Apagar();





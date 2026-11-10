namespace Tarea2;

class Program
{
    static void Main(string[] args)
    {
        ViviendaParticular vivienda1 = new ViviendaParticular("Vivienda1", "Blvd Patria Calle Fresa #2332", 3);
        vivienda1.Imprime();
        vivienda1.Rentar(450);

        Console.WriteLine("--------------------------");

        LocalComercial localComercial = new LocalComercial("Cafe Veracruzano", "Blvd Francisco Villa Calle Diamante", "Alimentos",  new DateTime(2026, 11, 9));
        localComercial.Imprime();
        localComercial.Rentar(1000);

        Console.WriteLine("--------------------------");

        Oficina oficina1 = new Oficina("Oficina Gubernamental", "Blvd Francisco Villa Calle Esmeralda", new DateTime(2026, 11, 9), "Gobierno");
        oficina1.Imprime();
        oficina1.NombreInmueble = "Oficina Gubernamental 2";
        Console.WriteLine("--------------Con modificacion en nombre----------------");
        oficina1.Mostrar();
        oficina1.Rentar(1500);
        
    }
}

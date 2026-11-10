class ViviendaParticular: Inmueble {
    int numHabitaciones;

    public int NumHabitaciones {
        get {
            return numHabitaciones;
        }
        set {
            numHabitaciones = value;
        }
    }

    public ViviendaParticular(){}
    public ViviendaParticular(string nombreInmueble, string direccion, int numHabitaciones){
        NombreInmueble = nombreInmueble;
        Direccion = direccion;
        NumHabitaciones = numHabitaciones;
    }
    public override void Rentar(double monto){
        Console.WriteLine("Rentar vivienda particular con monto de {0}", monto);
    }

    public void Imprime(){
        Imprimir();
        Console.WriteLine("Con {0} habitaciones", numHabitaciones);
    } 
}
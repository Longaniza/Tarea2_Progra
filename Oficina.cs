class Oficina: LocalComercial {
    string actividad = string.Empty;

    public string Actividad {
        get {
            return actividad;
        }
        set {
            actividad = value;
        }
    }

    public Oficina() {
    }

    public Oficina(string nombreInmueble, string direccion, DateTime horario, string actividad){
        NombreInmueble = nombreInmueble;
        Direccion = direccion;
        TipoComercio = "Oficina";
        Horario = horario;
        Actividad = actividad;
    }

    public void Mostrar(){
        Imprime();
        Console.WriteLine("Actividad de tipo {0}", actividad);
    }

}
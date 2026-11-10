class LocalComercial: Inmueble {

    string tipoComercio = string.Empty;
    DateTime horario;

    public string TipoComercio {
        get {
            return tipoComercio;
        }
        set {
            tipoComercio = value;
        }
    }

    public DateTime Horario {
        get {
            return horario;
        }
        set {
            horario = value;
        }
    }

    public LocalComercial(){}

    public LocalComercial(string nombreInmueble, string direccion, string tipoComercio, DateTime horario){
        NombreInmueble = nombreInmueble;
        Direccion = direccion;
        TipoComercio = tipoComercio;
        Horario = horario;
    }

    public void Imprime(){
        Imprimir();
        Console.WriteLine("Tipo de comercio: {0}, Horario de {1} ", tipoComercio, horario);
    }


    public override void Rentar(double monto){
        Console.WriteLine("Rentar local comercial con monto de {0}", monto);
    }
}
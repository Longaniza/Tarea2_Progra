abstract class Inmueble
{
    string nombreInmueble = string.Empty;
    string direccion = string.Empty;

    public string NombreInmueble {
        get {
            return nombreInmueble;
        }
        set {
            nombreInmueble = value;
        }
    }

    public string Direccion {
        get {
            return direccion;
        }
        set {
            direccion = value;
        }
    }

    public abstract void Rentar (double monto);
    
    // UML no especifica que este protegido pero es conveniente segun la estrutura del ejercicio(metodos Imprime en hijos)
    protected virtual void Imprimir () {
        Console.WriteLine("{0} en direccion {1}", nombreInmueble, direccion );
    }
}

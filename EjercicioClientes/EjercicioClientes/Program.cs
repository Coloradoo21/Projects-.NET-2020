using System;

namespace EjercicioClientes
{
    class Cliente
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
class Cliente
{
    int codigo;
    string nombre;
    int tipoDocumento;
    int numDocumento;
    DateTime fechaNacimiento;
    bool sexo;  //false=femenino true=masculino
    bool esCasado;

    //constructores

    public Cliente()
    {
        codigo = 0;
        nombre = "";
        tipoDocumento = 0;
        numDocumento = 0;
        fechaNacimiento = DateTime.Today;
        sexo = false;
        esCasado = false;
    }

    public Cliente(int codigo, string nombre, int tipoDocumento, int numDocumento, DateTime fechaNacimiento, bool sexo, bool esCasado)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.tipoDocumento = tipoDocumento;
        this.numDocumento = numDocumento;
        this.fechaNacimiento = fechaNacimiento;
        this.sexo = sexo;
        this.esCasado = esCasado;
    }
    //propiedades:

    public int pCodigo
    {
        set { codigo = value; }
        get { return codigo; }
    }

    public string pNombre
    {
        set { nombre = value; }
        get { return nombre; }
    }

    public int pTipoDocumento
    {
        set { tipoDocumento = value; }
        get { return tipoDocumento; }
    }

    public int pNumDocumento
    {
        set { numDocumento = value; }
        get { return numDocumento; }

    }

    public DateTime pFechaNacimiento
    {
        set { fechaNacimiento = value; }
        get { return fechaNacimiento; }
    }

    public bool pSexo
    {
        set { sexo = value; }
        get { return sexo; }
    }

    public bool pEsCasado
    {
        set { esCasado = value; }
        get { return esCasado; }
    }

    //metodos

    public string toStringSexo()
    {
        string sex;

        if (sexo)
            sex = "Masculino";
        else
            sex = "Femenino";
        return sex;

    }

    public string toStringesCasado()
    {
        String esCas;

        if (esCasado)
            esCas = "Casado";
        else
            esCas = "Soltero";
        return esCas;

    }

    public string toStringtipoDocumento()
    {
        string tipoDoc;

        switch (tipoDocumento)
        {
            case 1: tipoDoc = "LC"; break;
            case 2: tipoDoc = "LE"; break;
            case 3: tipoDoc = "DNI"; break;
            case 4: tipoDoc = "Pasaporte"; break;
            default: tipoDoc = "Desconocido"; break;

        }
        return tipoDoc;
    }

    public string toString()
    {
        string mensaje;

        mensaje = "Codigo: " + codigo.ToString()
            + "\nNombre: " + nombre + "\n"
            + toStringtipoDocumento() + ": " + numDocumento.ToString()
            + "\nFecha de nacimiento: " + fechaNacimiento.ToShortDateString()
            + "\nSexo: " + toStringSexo()
            + "\nEstado Civil: " + toStringesCasado();

        return mensaje;

    }




}

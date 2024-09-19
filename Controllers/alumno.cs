namespace WebApI.Controllers
{
    public class Alumno
    {
        //creando propiedades
        string Nombre;
        string apellido;
        string dni;
        DateTime fechanacimiento;



        //constructor sin parametros
        public Alumno()
        {
            Nombre = string.Empty;
            apellido = string.Empty;
            dni = string.Empty;
            fechanacimiento = DateTime.Now;

        }


        //constructor con parametros
        public Alumno(string pnombre, string papellido, string pdni)
        {
            Nombre = pnombre;
            apellido = papellido;
            dni = pdni;
        }

        //constructor con parametros pero con fechadenacimiento
        public Alumno(string pnombre, string papellido, string pdni, DateTime pfechanacimiento)
        {
            Nombre = pnombre;
            apellido = papellido;
            dni = pdni;
            fechanacimiento = pfechanacimiento;
        }






        public string DevolverNombreCompleto()
        {
            return dni;
        }


        public int DevolverEdad()
        { 
            return DateTime.Now.Year - fechanacimiento.Year;
        }


        
    }
}

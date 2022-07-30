namespace Ejemplo.Modelos{
    public class Usuario{
        public string Nombre;
        private string apellido;
        public string Apellido{
            get{return apellido;}
            set{apellido = value;}
        }

        public int Edad;
        private string Correo;
        public string Contrasenia{get;set;}

        public Telefono Telefono {get;set;}


        public void SetCorreo(string correo){
            Correo=correo;
        }
        public string GetCorreo(){
            return Correo;
        }
        public Usuario(){

        }
        //tradicional contructor
        /*public Usuario(string nombre,string apellido,string edad,int correo,string, contra,string){
            Nombre=nombre;
            Apellido=apellido;
            Edad=edad;
            Correo=correo;
            Contrasenia=contra;
        }*/
        //Constructor Reducido

        public Usuario (string nombre,string apellido, int edad, string correo, string contra,Telefono tel)=>
           (Nombre,Apellido,Edad,Correo,Contrasenia,Telefono) = (nombre,apellido,edad,correo,contra,tel);
            
        public string Info(){
            return $"{Nombre} {Apellido} {Edad} {Correo} {Contrasenia} ";
        }
    }
}
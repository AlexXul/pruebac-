namespace Ejemplo.Modelos{
    public class Telefono{
       public int CodigoPais{get;set;}
       public string Numero{set;get;}
        public string Info(){
            return $"+{CodigoPais} {Numero}";
        }

    }
}
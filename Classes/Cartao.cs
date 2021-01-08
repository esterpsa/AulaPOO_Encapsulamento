namespace AulaPOO_Encapsulamento.Classes
{
    public class Cartao
    {
        //Declaração de varáveis 
        private string numero; 

        protected string token = "Qwertyui";

        private string cvv;

        protected float limite = 5000;

        //declaração dos metodos 
        public string RegistrarCompra(bool validado){
            return "";
        }

        private bool ValidarCompra(float saldo){
            return true;
        }
        protected string ValidarToken(string token){
            return "";
        }




    }
}
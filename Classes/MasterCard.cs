namespace AulaPOO_Encapsulamento.Classes
{
    public class MasterCard : Cartao
    {
        //Declaração dos atributos 
        private int parcela;

        //Get e Set 
        public int Parcela {
            get {return parcela;}//Pegar dados - leitura
            set {parcela = value;}//Inserir Dados - escrita
        }

        //Métodos 
        public string ComprarComDesconto(){
            return "";
        }

    }
}
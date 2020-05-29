namespace Aula06Herança
{
    public class CNPJ : Pessoa
    {
        public string cnpj;
        public bool ValidarCNPJ(){
            if(cnpj != " "){
                return true ;
            }
            else{
                return false;
            }
        }
    }
}
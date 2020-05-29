namespace Aula06Herança
{
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;

        public bool ValidarCPF(string cpf){
            if(cpf != " "){
                return true ;
            }
            else{
                return false;
            }
            }
    }
}
using Cadastro_Pessoa.Interfaces;

namespace Cadastro_Pessoa.Classes
{
    public class PessoaJuridica: Pessoa, IPessoJuridica
    {
        public string ?cnpj { get; set; }
        public string ?razaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarCNPJ(string cnpj)
        {
            if (cnpj.Length == 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
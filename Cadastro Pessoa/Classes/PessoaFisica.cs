using Cadastro_Pessoa.Interfaces;

namespace Cadastro_Pessoa.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }
        public string? dataNascimento { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarDataNascimento(string dataNasc)
        {
            DateTime resultado;
            if (DateTime.TryParse(dataNasc, out resultado))
            {
                DateTime dataAtual = DateTime.Today;
                double anos = (dataAtual - resultado).TotalDays / 365;

                if (anos >= 18)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool validarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}
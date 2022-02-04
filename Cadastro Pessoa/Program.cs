// See https://aka.ms/new-console-template for more information
using Cadastro_Pessoa.Classes;

PessoaFisica metodoPF = new PessoaFisica();

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

novaPf.nome = "Ordilei";
novaPf.dataNascimento = "01/01/2000";
novaPf.cpf = "12345678901";
novaPf.redimento = 15000.5f;

novoEnd.logradouro = "Rua dois";
novoEnd.numero = 123;
novoEnd.complemento = "Apto 101";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

bool dataValida = metodoPF.validarDataNascimento(novaPf.dataNascimento);

//Console.WriteLine(novaPf.nome);
//Console.WriteLine($"Endereco: {novaPf.endereco}, {novaPf.endereco.logradouro}, {novaPf.endereco.numero}, {novaPf.endereco.complemento}, {novaPf.endereco.endComercial}");
Console.WriteLine(@$"
Nome: {novaPf.cpf}
Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}, {novaPf.endereco.complemento}, {novaPf.endereco.endComercial}
");
Console.WriteLine($"Data de Nascimento: {novaPf.dataNascimento}");

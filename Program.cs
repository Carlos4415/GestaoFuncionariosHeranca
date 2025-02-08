// Este programa implementa uma hierarquia de classes para representar funcionários de uma empresa. 
// Utilizando os conceitos de herança, são definidas classes específicas como Gerente, Programador e Analista, 
// que herdam propriedades comuns, como Nome e Salário, da classe base Funcionario. 
// Cada classe derivada possui atributos e métodos específicos relacionados ao seu papel na organização. 
// O objetivo é modelar a estrutura corporativa e demonstrar a aplicação de princípios de Orientação a Objetos.
using GestaoFuncionariosHeranca;

Gerente gerente = new Gerente();
gerente.Nome = "Carlos Silva";
gerente.Salario = 12000.50;
gerente.Setor = "Recursos Humanos";

Console.WriteLine("Gerente:");
Console.WriteLine($"Nome: {gerente.Nome}");
Console.WriteLine($"Salário: {gerente.Salario}");
Console.WriteLine($"Setor: {gerente.Setor}");

Programador programador = new Programador();
programador.Nome = "Ana Oliveira";
programador.Salario = 8000.00;
programador.LinguagemProgramacao = "C#";

Console.WriteLine("\nProgramador:");
Console.WriteLine($"Nome: {programador.Nome}");
Console.WriteLine($"Salário: {programador.Salario}");
Console.WriteLine($"Linguagem de Programação: {programador.LinguagemProgramacao}");

Analista analista = new Analista();
analista.Nome = "João Pereira";
analista.Salario = 9500.75;
analista.AreaAtuacao = "Financeiro";

Console.WriteLine("\nAnalista:");
Console.WriteLine($"Nome: {analista.Nome}");
Console.WriteLine($"Salário: {analista.Salario}");
Console.WriteLine($"Área de Atuação: {analista.AreaAtuacao}");
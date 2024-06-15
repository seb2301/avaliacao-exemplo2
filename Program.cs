namespace Avaliacao {
    public class Program {

        // static public List<Pessoa> pessoas = [];
        static void Main() {
            int op = 0;
            do {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - para Criar Pessoa");
                Console.WriteLine("2 - para Listar Pessoas");
                Console.WriteLine("3 - para Alterar Pessoa");
                Console.WriteLine("4 - para Deletar Pessoa");
                Console.WriteLine("5 - para Sair do programa");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op) {
                    case 1:
                        ViewPessoa.CriarPessoa();
                        break;
                    case 2:
                        ViewPessoa.ListarPessoa();
                        break;
                    case 3:
                        ViewPessoa.AlterarPessoa();
                        break;
                    case 4:
                        ViewPessoa.DeletarPessoa();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa - Tchau");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while(op != 5);
        }

        // criar aqui funções
        // static void CriarPessoa() {
        //     Console.WriteLine("---- Criando uma pessoa  -----");
        //     Pessoa person = new Pessoa();

        //     Console.WriteLine("Digite o nome da pessoa: ");
        //     person.Nome = Console.ReadLine() ?? "";
        //     Console.WriteLine("Digite a Idade da pessoa: ");
        //     person.Idade = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine("Digite o CPF da pessoa: ");
        //     person.Cpf = Console.ReadLine() ?? "";

        //     pessoas.Add(person);
        //     Console.WriteLine("Pessoa criada com sucesso");
        // }
        // static void ListarPessoa() {
        //     Console.WriteLine("----- Listando pessoas ------");
        //     if(pessoas.Count > 0) {
        //         foreach (Pessoa person in pessoas) {
        //             Console.WriteLine($"{person.Nome} - {person.Idade}");
        //         }
        //     } else {
        //         Console.WriteLine("Nenhuma pessoa cadastrada.");
        //     }
        // }
        // static void AlterarPessoa() {
        //     Console.WriteLine("---- Alterando uma pessoa ----");
        //     Console.WriteLine("Informe o indice da pessoa para alterar: ");
        //     int indice = Convert.ToInt32(Console.ReadLine());
        //     if(indice >= 0 && indice < pessoas.Count){
        //         Pessoa person = pessoas[indice];

        //         Console.WriteLine("Digite o nome da pessoa para alterar: ");
        //         person.Nome = Console.ReadLine();
        //         Console.WriteLine("Digite a Idade da pessoa para alterar: ");
        //         person.Idade = Convert.ToInt32(Console.ReadLine());
        //         Console.WriteLine("Digite o CPF da pessoa para alterar: ");
        //         person.Cpf = Console.ReadLine();

        //         pessoas[indice] = person;
        //         Console.WriteLine("Pessoa alterada com sucesso");
        //     } else {
        //         Console.WriteLine("Indice inválido");
        //     }
        // }
        // static void DeletarPessoa() {
        //     Console.WriteLine("---- Deletando uma pessoa ----");
        //     Console.WriteLine("Informe o indice da pessoa para deletar: ");
        //     int indice = Convert.ToInt32(Console.ReadLine());
        //     if(indice >= 0 && indice < pessoas.Count){
        //         pessoas.RemoveAt(indice);
        //     } else {
        //         Console.WriteLine("Indice inválido");
        //     }
        // }
    }
}
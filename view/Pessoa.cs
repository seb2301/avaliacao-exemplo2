namespace Avaliacao {
    public class ViewPessoa {
        
        public static void CriarPessoa() {
            Console.WriteLine("---- Criando uma pessoa  -----");

            Console.WriteLine("Digite o nome da pessoa: ");
            string nome = Console.ReadLine() ?? "";
            Console.WriteLine("Digite a Idade da pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o CPF da pessoa: ");
            string cpf = Console.ReadLine() ?? "";

            ControllerPessoa.CriarPessoa(nome, idade, cpf);
            Console.WriteLine("Pessoa criada com sucesso");
        }

        public static void ListarPessoa() {
            Console.WriteLine("----- Listando pessoas ------");
            List<Pessoa> pessoas = ControllerPessoa.ListarPessoa();

            if(pessoas.Count > 0) {
                foreach (Pessoa person in pessoas) {
                    Console.WriteLine($"{person.Nome} - {person.Idade}");
                }
            } else {
                Console.WriteLine("Nenhuma pessoa cadastrada.");
            }
        }

        public static void AlterarPessoa() {
            Console.WriteLine("---- Alterando uma pessoa ----");
            Console.WriteLine("Informe o indice da pessoa para alterar: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome da pessoa para alterar: ");
            string nome = Console.ReadLine() ?? "";
            Console.WriteLine("Digite a Idade da pessoa para alterar: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o CPF da pessoa para alterar: ");
            string cpf = Console.ReadLine() ?? "";

            ControllerPessoa.AlterarPessoa(indice, nome, idade, cpf);
        }

        public static void DeletarPessoa() {
            Console.WriteLine("---- Deletando uma pessoa ----");
            Console.WriteLine("Informe o indice da pessoa para deletar: ");

            int indice = Convert.ToInt32(Console.ReadLine());
            ControllerPessoa.DeletarPessoa(indice);
        }
    } 
}
using System;
using System.Linq;

namespace CursoNelioAula1701
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source/ -> Especificar a fonte dos dados, lugar de onde vão vir os dados.
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the query expression/ -> Definir a consulta dos dados, e escrever a expressão com Linq.
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Executar the query/ -> Executar a consulta dos dados, vai ser utilizando um foreach ou por outra operação terminal, é uma operação q vai forçar essa consulta ser executada.
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}

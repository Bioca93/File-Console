using System;
using System.Runtime.Serialization;

namespace Ficha_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o teu primeiro nome?");
            string firstName = Console.ReadLine();
            //  Console.WriteLine("O primeiro nome é " + firstName);
            
            Console.Clear();

            Console.WriteLine("Qual o teu segundo nome?");
            string middleName = Console.ReadLine();
            //   Console.WriteLine("O nome do meio é " + middleName);
           
            Console.Clear();

            Console.WriteLine("Qual o teu último nome?");
            string lastName = Console.ReadLine();
            //   Console.WriteLine("O último nome é " + lastName);
           
            Console.Clear();

            Console.WriteLine("Se tiveres mais nomes do meio acrescenta: ");
            string fullName = Console.ReadLine();
            //  Console.WriteLine("O nome completo é " + firstName + " " + middleName + " " + fullName + " " + lastName);
            
            Console.Clear();

            Console.WriteLine("Qual o teu género?");
            string gender = Console.ReadLine();
            //    Console.WriteLine("O género é " + gender);
           
            Console.Clear();

            Console.WriteLine("Qual a tua idade?");
            int age = Convert.ToInt32(Console.ReadLine());
            //   Console.WriteLine("A idade é " + age);
           
            Console.Clear();

            Console.Write("Qual o teu dia de nascimento?");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual o teu mês de nascimento em número?");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual o teu ano de nascimento?");
            int year = Convert.ToInt32(Console.ReadLine());
           
            DateTime nascimento = new DateTime(2020, month, 1);

            Console.WriteLine("Em que mês estamos em números?");
            int mes = Convert.ToInt32(Console.ReadLine());

            int idade = DateTime.Now.Year - year;
            if (mes < month)
            {
                idade--;
            }
           
            //  Console.WriteLine("Tens" + idade + " anos.");

            Console.Clear();


            Console.WriteLine("Qual a tua profissão?");
            string currentJob = Console.ReadLine();
          //  Console.WriteLine("A profissão atual é " + currentJob);
           
            Console.Clear();


            Console.WriteLine("Qual a tua altura?");
            decimal height = Convert.ToDecimal(Console.ReadLine());
         //   Console.WriteLine("A altura é " + height + " metros.");
           
            Console.Clear();

            Console.WriteLine("Qual a cor dos teus olhos?");
            string eyeColour = Console.ReadLine();
         //   Console.WriteLine("A cor dos olhos é " + eyeColour);
            Console.ReadKey();
            Console.Clear();


            // CALCULAR IDADE CONSOANTE O ANO DE NASCIMENTO.

            Console.WriteLine("O primeiro nome é " + firstName);
            Console.WriteLine("O nome do meio é " + middleName);
            Console.WriteLine("O último nome é " + lastName);
            Console.WriteLine("O nome completo é " + firstName + " " + middleName + " " + fullName + " " + lastName);
            Console.WriteLine("O género é " + gender);
            Console.WriteLine("A idade é " + age);
            Console.WriteLine("Data de Nascimento é " + day + " de " + nascimento.ToString("MMMM") + " de " + year);
            Console.WriteLine("Tens " + idade + " anos.");
            Console.WriteLine("A profissão atual é " + currentJob);
            Console.WriteLine("A altura é " + height + " metros.");
            Console.WriteLine("A cor dos olhos é " + eyeColour);

        }
    }
}

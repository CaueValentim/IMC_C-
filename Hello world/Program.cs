namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome =  Console.ReadLine();
            
            Console.WriteLine("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());


            double alturaEmMetros = altura / 100;
            double imc = peso / Math.Pow(alturaEmMetros, 2);

            if (imc < 18.5)
            {
                Console.WriteLine("seu estado fisico MAGREZA");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("seu estado fisico NORMAL");
            }
            else if (imc >= 24.9 && imc < 29.9)
            {
                Console.WriteLine("seu estado fisico SOBREPESO");
            }
            else if (imc >= 29.9 && imc < 39.9)
            {
                Console.WriteLine("seu estado fisico OBESIDADE");
            }
            else
            {
                Console.WriteLine("seu estado fisico OBESIDADE GRAVE");
            }




        }
    }
}
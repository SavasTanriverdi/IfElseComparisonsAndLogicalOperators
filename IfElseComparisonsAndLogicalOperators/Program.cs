using System;

namespace IfElseComparisonsAndLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan yaş ve öğrencilik durumu bilgisi alınır
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Are you a student? (yes/no): ");
            string isStudentInput = Console.ReadLine();
            bool isStudent = isStudentInput.ToLower() == "yes";

            // Yaşa göre yetişkin olup olmadığını kontrol eder
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }

            // Mantıksal operatörler ile çeşitli durumları kontrol eder
            if (age >= 18 && isStudent)
            {
                Console.WriteLine("You are an adult student.");
            }
            else if (age >= 18 && !isStudent)
            {
                Console.WriteLine("You are an adult but not a student.");
            }
            else if (age < 18 && isStudent)
            {
                Console.WriteLine("You are a minor and a student.");
            }
            else
            {
                Console.WriteLine("You are a minor and not a student.");
            }

            // Karşılaştırma operatörleri örneği
            if (age == 18)
            {
                Console.WriteLine("You just became an adult!");
            }
            else if (age != 18)
            {
                Console.WriteLine("You are not exactly 18 years old.");
            }
        }
    }
}
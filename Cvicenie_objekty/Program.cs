namespace Cvicenie_objekty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string name = "Markus";
            int age = 15;
            string adress = "Budatín";
            
            string name1 = "Jozik";
            int age1 = 16;
            string adress1 = "Rudinská";*/

            Student student = new Student();
            student.Age = 15;
            student.Name = "Markus";
            student.Adress = "Budatín";
            student.Gender = 'M';
            

            Student student1 = new Student();
            student1.Age = 16;
            student1.Name = "Jozik";
            student1.Adress = "Budatín";
            student1.Gender = 'M';
            Console.WriteLine(student1.IsAdult());
            
            Student menoStudenta = student;
            menoStudenta.Name = "Jozek";
            student.Name = menoStudenta.Name;
            Console.WriteLine(student1.Name);

            Console.WriteLine(student.GetAll());




        }
    }
}

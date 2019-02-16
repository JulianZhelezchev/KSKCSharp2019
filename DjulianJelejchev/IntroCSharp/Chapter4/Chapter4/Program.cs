using System;

namespace Chapter4
{
    class Program
    {
        

        static void Main(string[] args)
        {

            // Напишете програма, която чете от конзолата три числа от тип int и
            //отпечатва тяхната сума.
            //  Използвайте методите Console.ReadLine() и Int32.Parse().



            string a = Console.ReadLine();
            int number1 = Convert.ToInt32(a);
            string b = Console.ReadLine();
            int number2 = Convert.ToInt32(b);
            string c = Console.ReadLine();
            int number3 = Convert.ToInt32(c);
            Console.WriteLine("You entered : {0},{1},{2}", number1, number2, number3);




            //2.Напишете програма, която чете от конзолата радиуса "r" на кръг и
            //отпечатва неговото лице и обиколка.
            //2.Използвайте константата Math.PI и добре известните формули от
            //планиметрията.


            // Area of Circle





            //Perimeter and Radius of a Circle
            {


                Console.Write("Input the radius of the circle:");
                double rad = double.Parse(Console.ReadLine());
                double area = Math.PI * (Math.Pow(rad, 2));
                double peri = 2 * Math.PI * rad;

                Console.WriteLine($"The area is {area:N} and the perimeter is {peri:N}");

                // 3 .Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт
                ////и мениджър. Мениджърът има име, фамилия и телефонен номер.
                //Напишете програма, която чете информацията за фирмата и нейния мениджър и я отпечатва след това на конзолата.
                //3.Форматирайте текста с Write(…) или WriteLine(…) подобно на този от
                //примера с писмото, който разгледахме.
            }

            //Company's task

            //Console.Write("Enter company's name: ");
            //string companyName = Console.ReadLine();

            //Console.Write("Enter company's adress: ");
            //string companyAdress = Console.ReadLine();

            //Console.Write("Enter company's telephone number: ");
            //string cp = Console.ReadLine();
            //int companyPhone = Convert.ToInt32(cp);

            //Console.Write("Enter company's fax number: ");
            //string cf = Console.ReadLine();
            //int companyFax = Convert.ToInt32(cf);

            //Console.Write("Enter company's website: ");
            //string companyWebsite = Console.ReadLine();

            //Console.Write("Enter the manager's first and last name: ");
            //string managerName = Console.ReadLine();

            //Console.Write("Enter the manager's phone number: ");
            //string mp = Console.ReadLine();
            //int managerPhone = Convert.ToInt32(mp);

            //Console.WriteLine(" Your company's name is-{0}, Your company's adress-{1}, Your company's telephone number is-{2}, Your company's fax number is -{3}, Your company's website is -{4}, The manager's first and last names are-{5} and the the manager's phone number-{ 6}", companyName, companyAdress, companyPhone, companyFax, companyWebsite, managerName, managerPhone);






            Console.Write("Enter company name: ");
            string compName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string compAddr = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            string compPhone = Console.ReadLine();
            Console.Write("Enter company fax: ");
            string compFax = Console.ReadLine();
            Console.Write("Enter company website: ");
            string compSite = Console.ReadLine();
            Console.Write("Enter company manager: ");
            string compManager = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string managerFName = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string managerLName = Console.ReadLine();
            Console.Write("Enter manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Firm: Name - {0}, Address - {1}, Number - {2}, Fax - {3}, Website - {4}, Manager - {5}", compName, compAddr, compPhone, compFax, compSite, compManager);
            Console.WriteLine("Manager: Name - {0} {1}, Phone - {2}", managerFName, managerLName, managerPhone);




        }

    }
}

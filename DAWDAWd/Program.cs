using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
namespace DAWDAWd
{
    class Program
    {
       static bool isEntered = false;
       static Good good = new Good();
       
        static void Main(string[] args)
        {

            good.AddProduct("огурцы", 228, TypeProduct.fruits);
            good.AddProduct("мыло", 2284, TypeProduct.flour);
            good.AddProduct("хлеб", 56, TypeProduct.food);
            good.AddProduct("HCL", 213, TypeProduct.chemistry);
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. Вход/регистрация");
                if (isEntered == true)
                {
                    Console.WriteLine("\n2. Выбор товара");
                    Console.WriteLine("\n3. Корзина");
                    Console.WriteLine("\n4. Оплата");
                    Console.WriteLine("\n5. Категории");
                    Console.WriteLine("\n6. Содержимое вашей корзины");
                }
                System.Threading.Thread.Sleep(500);
                string idk = Console.ReadLine();

                switch (idk)
                {
                    case "1":
                        Enter();
                        break;

                    case "2":
                        good.PrintProducts();
                        break;
                    case "3":
                        Console.WriteLine("Введите номер продукта вы хотите добавить в корзину: ");
                        int number = int.Parse(Console.ReadLine());
                    
                        good.AddToBasket(number);
                        break;
                    case "5":
                        good.PrintProducts();
                        break;
                    case "4":
                        Console.WriteLine("Точно все добавили? Нажмите 2 для покупки");
                        string num = Console.ReadLine();
                        if (num == "2")
                        {
                            Console.WriteLine("Корзина очищена!");
                            good.ClearBasket();
                        }
                        break;
                    case "6":
                        Console.WriteLine("Вот что находится в данной корзине: ");
                        good.ShowBasket();
                        break;
                }

            }


        }

        public static void Enter()
        {
            Console.Clear();

            string type;
            Console.WriteLine("Войти или Регистрация");
            type = Console.ReadLine();
            if (type == "Войти")
            {
                Console.WriteLine("Введите ваш логин: ");
                string login = Console.ReadLine();
                Console.WriteLine("Введите ваш пароль: ");
                string password = Console.ReadLine();
                isEntered = true;
            }
            else if (type == "Регистрация" || type == "регистрация")
            {
                Console.WriteLine("Введите ваш логин: ");
                string login = Console.ReadLine();
                Console.WriteLine("Введите ваш пароль: ");
                string password = Console.ReadLine();
                Console.WriteLine("Подтвердите ваш пароль: ");
                string password2 = Console.ReadLine();
                Console.WriteLine("Введите ваш номер телефона");
                string telephone = Console.ReadLine();
                Console.WriteLine("3. Зарегестрироваться");
                string what = Console.ReadLine();
                if (what == "3")
                {
                    if (password != password2)
                    {
                        Console.WriteLine("Пароли разные ");
                        Console.WriteLine("Введите код от смс на ваш телефон: ");
                        Console.ReadLine();
                    }
                   if (password == password2)
                    {
                        const string accountSid = "ACb3eb071e31939d4c6c8ed99ea71f8081";
                        const string authToken = "dc60410b12420c13e7d223481fa40388";

                        TwilioClient.Init(accountSid, authToken);

                        var message = MessageResource.Create(

                            from: new Twilio.Types.PhoneNumber("+18508763141"),
                            body: "123",
                            to: new Twilio.Types.PhoneNumber("+77086514231")
                            );
                        Console.WriteLine("Введите сообщение присалнное на ваш телефон");
                        string verificationCode = Console.ReadLine();
                        if (verificationCode == "123")
                        {
                            Console.WriteLine("Поздравляю вы успешно зарегестрированы!");
                             isEntered= true;
                            Console.ReadLine();
                        }
                       
                    }
                }
            }
        }

        public static void Select()
        {

        }
    }
}

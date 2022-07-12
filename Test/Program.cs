using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        static void Main(string[] args)
        {

            IEnumerable<char> query = "Not what you might expect";
            string vowels = "aeiou";
            foreach (char vowel in vowels)
                query = query.Where(c => c != vowel);
           
           
            foreach (char item in query)
            {
                Console.WriteLine(item);
            }

            //string[] name = { "mona", "Ali", "sara", "Noorrrrr" };

            //IEnumerable<string> names =
            //    from n in name
            //    where n.Contains("a")
            //    orderby n.Length
            //    select n.ToUpper();
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
        }

            //int[] num1 = new int[] { 1,2,5,6,10,12};
            //int[] num2 = new int[] { 1, 2, 5, 6, 10, 12,1,88 };
            //IEnumerable<int> numOrder = num1.Intersect(num2);
            ////Console.WriteLine(numOrder);
            //foreach (var item in numOrder)
            //{
            //    Console.Write(item+" ");
            //}



            //var regiterUser = new RegisterUser();
            //var emailVerification = new EmailVerification();
            //var sMSVerivication = new SMSVerivication();
            //regiterUser.UserRegisterEvent += emailVerification.OnUserRegister;
            //regiterUser.UserRegisterEvent += sMSVerivication.OnUserRegister;
            //regiterUser.RegisterMethod();

            //**************Deleget****************
            //var regiterUser = new RegisterUser();
            //var emailVerification = new EmailVerification();
            //var sMSVerivication = new SMSVerivication();
            //regiterUser.UserRegisterDelegetInstance += emailVerification.OnUserRegister;
            //regiterUser.UserRegisterDelegetInstance += sMSVerivication.OnUserRegister;
            //regiterUser.RegisterMethod();



        }
    }
    public class RegisterUser
    {
        public delegate void UserRegisterDeleget(object o, EventArgs eventArgs);//declare deleget
        public event UserRegisterDeleget UserRegisterEvent;// declare event

        public void RegisterMethod()
        {
            Console.WriteLine("User Register");
            if (UserRegisterEvent != null)
            {
                UserRegisterEvent(this, EventArgs.Empty);//call event
            }
        }

    }

    public class EmailVerification
    {
        public void OnUserRegister(object o, EventArgs eventArgs)
        {
            Console.WriteLine("Email Sent");
        }
    }

    public class SMSVerivication
    {
        public void OnUserRegister(object o, EventArgs eventArgs)
        {
            Console.WriteLine("SMS Sent");
        }
    }

    //***************************Deleget****************************

    //public class RegisterUser
    //{
    //   public delegate void UserRegisterDeleget();//declare ddelger
    //   public UserRegisterDeleget UserRegisterDelegetInstance;// instance delecget

    //    public void RegisterMethod()
    //    {
    //        Console.WriteLine("User Register");
    //        if(UserRegisterDelegetInstance!=null)
    //        {
    //            UserRegisterDelegetInstance();//call delegete
    //        }
    //    }

    //}

    //public class EmailVerification
    //{
    //    public void OnUserRegister()
    //    {
    //        Console.WriteLine("Email Sent");
    //    }
    //}

    //public class SMSVerivication
    //{
    //    public void OnUserRegister()
    //    {
    //        Console.WriteLine("SMS Sent");
    //    }
    //}
//}

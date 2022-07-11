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

            string[] name = { "mona", "Ali", "sara","Noor" };

            IEnumerable<string> names = name
                                    .Where(n => n.Contains("a"))
                                    .OrderBy(n => n.Length)
                                    .Select(n => n.ToUpper());
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            

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
}

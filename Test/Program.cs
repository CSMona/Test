using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

 namespace Test
{
   public class Program
    {


        public delegate void mydelget();
        class Test {



            public mydelget mydel;
            public int? x;
            public string name;
            public Test()
            {
                mydel = myfunc;
            }
            public void myfunc()
            {
                Console.WriteLine("myfunc");
            }

            public void myfunc2()
            {
                Console.WriteLine("myfunc2");
            }

  


    }


        static void Main(string[] args)
        {
        



	{

	}

            //MemberInfo[] memberInfos = type.GetMembers();
            //MethodInfo[] methodInfos = type.GetMethods();
            //ConstructorInfo[] constructorInfos = type.GetConstructors();
            //foreach (var item in propertyInfos)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //test.mydel();
            //test.mydel =test.myfunc2;
            //test.mydel();
            FontStyle c = FontStyle.Bold ^ FontStyle.ABC^ FontStyle.ABC;
            FontStyle c2 = c ^ FontStyle.Bold;
            //Console.WriteLine(c);

        }
        [Flags]
          public  enum FontStyle
        {
            Bold = 1,
            Italic = 1 << 1,
            Underline=1<<2,
            ABC=1<<3
        

    } 
    }



            //using (var enumerator = "beer".GetEnumerator())
            //{
            //    while (enumerator.MoveNext())
            //    {
            //        var element = enumerator.Current;
            //        Console.WriteLine(element);
            //    }
            //}

            //int? x = null;
            //int y = x ?? 5; // y is 5
            //int? a = null, b = 1, c = 2;
            //Console.WriteLine(a ?? b ?? c); // 1 (first non-null value)

            //IEnumerable<int>facts(int factcont)
            //{
            //    int prev = 1;
            //    int curr = 1;
            //    for (int i = 0; i < factcont; i++)
            //    {

            //        yield return prev;

            //        int newCount = prev + curr;
            //        prev = curr;
            //        curr = newCount;


            //    }

            //}

            //IEnumerable<int> Evenet(IEnumerable<int>Sequenceeven)
            //{
            //    foreach (var item in Sequenceeven)
            //    {
            //        if (item % 2 == 0)
            //            yield return item;
            //    }

            //}

            //foreach (var item in Evenet(facts(6)) )
            //{
            //    Console.Write(  item+" ");
            //}


            //           string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            //           var intermedate = from n in names
            //                           select new
            //                           {
            //                               original = n,
            //                               volumness = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
            //                           }
            //           into temp
            //where temp.volumness.Length > 2
            //select temp.original;

            //           foreach (var item in intermedate)
            //           {
            //               Console.WriteLine(item);
            //           }
            //IEnumerable<char> query = "Not what you might expect";
            //string vowels = "aeiou";
            //foreach (char vowel in vowels)
            //    query = query.Where(c => c != vowel);


            //foreach (char item in query)
            //{
            //    Console.WriteLine(item);
            //}

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

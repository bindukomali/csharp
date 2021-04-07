using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    // define a delegate  - step 1
    public delegate void MessageDelegate();
    public delegate string EmailDelegate(string eMail);
    class Email
    {
        public static string GetEmail(string strEmail)
        {
            return "Your Email Id is " + strEmail;
        }
        public static void DisplayMessage()
        {
            Console.WriteLine("Welcome to CSharp Delegates");
        }
    }
    class TestEmail
    {
        public static void Main()
        {
            // Instantiating the delegate -- step 2
            EmailDelegate email = new EmailDelegate(Email.GetEmail);
            MessageDelegate msg = new MessageDelegate(Email.DisplayMessage);

            //Invoking delegate -- step3

            string strEmail = email.Invoke("komali@gmail.com");
            Console.WriteLine(strEmail);

            msg.Invoke();
            Console.ReadKey();
        }

    }
}

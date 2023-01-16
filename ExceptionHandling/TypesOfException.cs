using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class TypesOfException
    {
        public static void TestIndexOutOfBoundException()
        {
            try
            {
                int[] arr = { 10, 20, 30 };
                Console.WriteLine(arr[3]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void TestNullReferenceException()
        {
            try
            {
                Contact contact = null;//new Contact();
                //contact.FirstName = "abc";
                Console.WriteLine(contact.FirstName);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void TestInvalidOperationException(string firstName)
        {
            try
            {
                List<Contact> listOfContact = new List<Contact>()
                {
                    new Contact(){FirstName = "Shivani" ,LastName = "Patel"},
                    new Contact(){FirstName = "Yash" ,LastName = "Patel"}
                }; 
                foreach(Contact contact in listOfContact)
                {
                    if (firstName == contact.FirstName)
                        listOfContact.Remove(contact);
                   // break;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void TestArgumentNullException()
        {
            try
            {
                string name = "shivani";
                string s = null;//"vani";
                Console.WriteLine("Index of this given word :" + name.IndexOf(s));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void TestArgumentOutOfRangeException()
        {
            try
            {
                string name = "shivani";
                Console.WriteLine("Word on this given index :" + name.Substring(8));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

}

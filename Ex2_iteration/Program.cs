using System;
using System.IO;
using System.Net;
using System.Text;

namespace Ex2_iteration
{
    class Program
    {

        static private void lineNotify(string msg)
        {
            string token = "gt5w4McV6glIdAQmVcxJhzXw1xfrFRr0Lz2PXy09VoP";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://notify-api.line.me/api/notify");
                var postData = string.Format("message={0}", msg);
                var data = Encoding.UTF8.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.Headers.Add("Authorization", "Bearer " + token);

                using (var stream = request.GetRequestStream()) stream.Write(data, 0, data.Length);
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void Main(string[] args)
        {
            string exit;

            do
            {
                Console.Write("FisrtName : ");
                string firstName = Console.ReadLine();
                Console.Write("BirthYear : ");
                string birthYear = Console.ReadLine();

                Console.WriteLine("--------------------");

                Console.WriteLine("Your name is " + firstName);


                int birthYearInt = int.Parse(birthYear);

                bool checkBirthYear = (birthYearInt <= DateTime.Now.Year && birthYear.Length == 4) ? true : false;

                if (checkBirthYear)
                {
                    Console.WriteLine(String.Format("Your birthyear is {0}", birthYear));

                    int age = DateTime.Now.Year - int.Parse(birthYear);

                    Console.WriteLine("Your age is (age)" + age);

                    lineNotify(String.Format("Hello!!, {0}, Your age is {1}", firstName, age));

                }
                else
                {
                    Console.WriteLine("BirthYear is incorrect");
                }

                Console.WriteLine("\n\n");

                Console.Write("Do you want to continue (y = yes/ n = no)? : ");
                exit = Console.ReadLine();

                Console.Clear();


            } while (exit == "y");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;



// AttributeUsage specifies the usage
// of InformationAttribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor |
                        AttributeTargets.Method, AllowMultiple = true)]

// InformationAttribute is a custom attribute class
// that is derived from Attribute class
class InformationAttribute : Attribute
{
    public string InformationString { get; set; }
}

namespace EventsAndDelegates
{


    // Attributes
    [Information(InformationString = "Class")]
    public class student
    {

        private int rollno;
        private string name;

        [Information(InformationString = "Constructor")]
        public student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

        [Information(InformationString = "Method")]
        public void display()
        {
            Console.WriteLine("Roll Number: {0}", rollno);
            Console.WriteLine("Name: {0}", name);
        }
    }

    internal class Program
    {
        //Anonymous Methods
        delegate int PointtoAddFunction(int num1, int num2);

        static void Main(string[] args)
        {
            //var video = new Video() { Title = "Video 1" };
            //var videoEncoder = new VideoEncoder();     //publisher
            //var mailService = new MailService();       //subscriber
            //var messageService = new MessageService(); //subscriber

            //videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            //videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            //videoEncoder.Encode(video);


            // Attributes
            //student s = new student(1001, "Lily Adams");
            //s.display();


            //Anonymous Methods-->Increases Performance that making another delegate class
            PointtoAddFunction pobjAdd = delegate (int num1, int mun2)
            {
                return num1 + mun2;
            };
            Console.WriteLine(pobjAdd.Invoke(2,2).ToString());

            Console.ReadLine();

        }
    }

    
}

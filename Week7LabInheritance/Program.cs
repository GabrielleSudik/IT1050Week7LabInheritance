using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7LabInheritance
{
    /*Create an application that does the following. Submit the complete application:

Create a base class of your choosing with two methods and two properties. You cannot use Animal. Both methods must write data to the console. DONE
Create two classes that inherit from that base class. DONE
In one of the two classes, override both methods and override both properties.  DONE
Both overridden methods must write data to the console that differs from the implementation of those methods in the base class. DONE
In your Main() method, declare instances of each of the two classes that inherit from the base class.  DONE
Call both methods and use both properties on each instance. DONE
*/

    class Books
    {
        //FIELDS

        protected string title;
        protected int fine;

        //PROPERTIES

        public virtual string Title
        {
            get { return title; }
            set { title = value; }
        }

        public virtual int Fine
        {
            get { return fine; }
            set { fine = value; }
        }

        //METHODS

        public virtual void Overdue()
        {
            Console.WriteLine($"{title} is overdue.");
        }

        public virtual void Recommendation()
        {
            Console.WriteLine($"Fines are {fine} cents per day.");
        }

        //CONSTRUCTORS
    }

    class Fiction : Books
    {

    }

    class Nonfiction : Books
    {
        //PROPERTIES

        public override string Title
        {
            get { return title ; }
            set { title = value + " (nonfiction)"; } //my notes from class say to add the "nonfiction" to the get line,
                                                    //but it didn't work, so I tried it in the set line and it worked.
                                                    //were my notes wrong?
        }

        public override int Fine
        {
            get { return fine; }
            set { fine = value + 15; } //ditto re "+ 15"
        }

        //METHODS

        public override void Overdue()
        {
            Console.WriteLine($"{title} is overdue. No fines if you write a paper on your research.");
        }

        public override void Recommendation()
        {
            Console.WriteLine($"Otherwise, fines are {fine} cents per day.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library, Great Reader.\n");

            Fiction myFiction = new Fiction();
            
            myFiction.Title = "The Hobbit";
            myFiction.Fine = 10;

            Nonfiction myNonfiction = new Nonfiction();

            myNonfiction.Title = "The Guns of August";
            myNonfiction.Fine = 10;

            myFiction.Overdue();
            myFiction.Recommendation();

            myNonfiction.Overdue();
            myNonfiction.Recommendation();

            Console.ReadLine();
        }
    }
}

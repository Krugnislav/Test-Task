using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing.Drawing2D;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Список
            List<String> list1 = new List<String>();
            list1.Add("string 1");
            list1.Add("string 2");
            list1.Sort();
            PrintValues(list1);

            // Очередь
            Queue qu = new Queue();
            qu.Enqueue("First");
            qu.Enqueue("Second");
            PrintValues(qu);

            //Стек
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");
            PrintValues(myStack);

            //Мартица
            Matrix myMatrix = new Matrix();
            myMatrix.Rotate(30);
            myMatrix.Scale(1, 2, MatrixOrder.Append);
            myMatrix.Translate(5, 0, MatrixOrder.Append);

            //Массив
            int[] array;



            Console.WriteLine("Hello, world!");
            Console.ReadKey(); 
            ViewBag.Title = "Home Page";
            return View();
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    
    }
}

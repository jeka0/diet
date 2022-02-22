using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using ServiceLayer;

namespace Лаба_4_ЯП
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new Form1();
            new Presenter(view, new NewProduct(), new NewCategory(), new Db("Products.xml"));
            Application.Run(view);
        }
    }
}

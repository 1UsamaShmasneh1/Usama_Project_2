using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkGenerecs
{
    static class Program<T>
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static T[] Combine(T[] array1, T[] array2)
        {
            T[] array3 = new T[array1.Length + array2.Length];
            int count = 0;
            foreach(T array in array1)
            {
                array3[count++] = array;
            }
            foreach (T array in array2)
            {
                array3[count++] = array;
            }
            return array3;
        }
    }
}

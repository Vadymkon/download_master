using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace download
{
    class Program
    {
        static void Main(string[] args)
        {
                string path = @"https://mail.univ.net.ua/syssoft/Base-IO.txt";
                string pdesktop = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
                if (File.Exists($"{pdesktop}/Base.txt")) File.Delete($"{pdesktop}/Base.txt");
                if (File.Exists($"{pdesktop}/Base-light.txt")) File.Delete($"{pdesktop}/Base-light.txt");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(new Uri(path), $"{pdesktop}/Base.txt");
            }
                if (File.Exists($"{pdesktop}/Base.txt"))
                {
                File.WriteAllText($"{pdesktop}/Base-light.txt", File.ReadAllText($"{pdesktop}/Base.txt").Replace(args[0], args[1]));
                MessageBox.Show("Done");    
            }
                
            
        }
    }
}

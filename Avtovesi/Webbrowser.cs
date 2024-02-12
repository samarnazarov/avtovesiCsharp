using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Avtovesi
{
    public partial class Webbrowser : Form
    {
        public Webbrowser()
        {
            InitializeComponent();
        }

        private void Webbrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://192.168.1.64");
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void documentText_button_Click(object sender, EventArgs e)
        {
            label1.Text= webBrowser1.Url.ToString();

            //File.WriteAllText("htmldoc.html",webBrowser1.DocumentText);
            string htmlFilePath = "htmldoc.html";

            // Создание нового объекта HtmlDocument
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            try
            {
                // Загрузка HTML из файла
                doc.Load(htmlFilePath);

                // Получение всего текста из HTML файла
                string htmlText = doc.DocumentNode.InnerText;
                File.WriteAllText("htmlfile.txt",htmlText);
                MessageBox.Show("all right");
                
            }
            catch
            {
                MessageBox.Show("sdsddd");
                return;
            }
        }

        
    }
}

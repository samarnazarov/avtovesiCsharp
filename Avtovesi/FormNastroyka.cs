using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace Avtovesi
{
    public partial class FormNastroyka : Form
    {
        string iniFilePath = "config.ini";
        public FormNastroyka()
        {
            InitializeComponent();
        }

        private void Button_ConfigFileStorage_Click(object sender, EventArgs e)
        {
            try
            {
                
                string ip = textBox_NastroyliIpAddress.Text;
                string log = textBox_NastroykiLogin.Text;
                string pass = textBox_NastroykiPassword.Text;
                string maskedIp = maskedTextBox1.Text;
                if (ip.Length!= 0 && log.Length!=0 && pass.Length!= 0)
                {
                    FileIniDataParser parser = new FileIniDataParser();
                    IniData data = new IniData();
                    data.Sections.AddSection("Autorization");
                    data["Autorization"]["ip"] =ip; 
                    data["Autorization"]["login"] = log;
                    data["Autorization"]["pass"] = pass;

                    // Сохранение в файл
                    parser.WriteFile(iniFilePath, data);

                    
                    MessageBox.Show($"Данные сохранены! {maskedTextBox1.Text}");

                }
                else 
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);    
            }
        }

        private void FormNastroyka_Load(object sender, EventArgs e)
        {
            FileIniDataParser parser = new FileIniDataParser();
            // Загрузка из файла
            IniData loadedData = parser.ReadFile(iniFilePath);

            // Получение значения
            string ip = loadedData["Autorization"]["ip"];
            string log = loadedData["Autorization"]["login"];
            string pass = loadedData["Autorization"]["pass"];

            textBox_NastroyliIpAddress.Text = ip;
            textBox_NastroykiLogin.Text = log;
            textBox_NastroykiPassword.Text = pass;
            
            
        }
    }
}

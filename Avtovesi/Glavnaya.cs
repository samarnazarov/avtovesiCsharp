﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Avtovesi
{
    public partial class Glavnaya : Form
    {
        private Int32 m_lUserID = -1;
        private uint iLastErr = 0;
        public struct NET_DVR_CLIENTINFO
        {
            public Int32 lChannel;//НЁµАєЕ
            public Int32 lLinkMode;//ЧоёЯО»(31)ОЄ0±нКѕЦчВлБчЈ¬ОЄ1±нКѕЧУВлБчЈ¬0Ј­30О»±нКѕВлБчБ¬ЅУ·ЅКЅ: 0ЈєTCP·ЅКЅ,1ЈєUDP·ЅКЅ,2Јє¶аІҐ·ЅКЅ,3 - RTP·ЅКЅЈ¬4-ТфКУЖµ·ЦїЄ(TCP)
            public IntPtr hPlayWnd;//ІҐ·Еґ°їЪµДѕд±ъ,ОЄNULL±нКѕІ»ІҐ·ЕНјПу
            public string sMultiCastIP;//¶аІҐЧйµШЦ·
        }
        public Glavnaya()
        {
            InitializeComponent();
            
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Size = new Size(panel3.Width, panel3.Height);
            pictureBox_CameraPreview.Location = new Point(0, 0);
            pictureBox_CameraPreview.Size = new Size(panel1.Width, panel1.Height);
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNastroyka form2= new FormNastroyka();
            form2.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spravka spravka = new Spravka();
            spravka.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           // if (m_lUserID < 0)
            //{
                /*string DVRIPAddress = "192.168.1.64"; //Йи±ёIPµШЦ·»тХЯУтГы
                Int16 DVRPortNumber = Int16.Parse("8000");//Йи±ё·юОс¶ЛїЪєЕ
                string DVRUserName = "admin";//Йи±ёµЗВјУГ»§Гы
                string DVRPassword = "2001asdx**";//Йи±ёµЗВјГЬВл

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                if (m_lUserID < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    string str = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //µЗВјК§°ЬЈ¬КдіцґнОуєЕ
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    //µЗВјіЙ№¦
                    MessageBox.Show("Login Success!");                    
                }*/
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SendAuthenticatedGetRequest();
        }
        static async Task SendAuthenticatedGetRequest()
        {
            string url = "http://192.168.1.64/ISAPI/System/deviceInfo"; // Замените на ваш URL
            string username = "admin"; // Замените на ваше имя пользователя
            string password = "2001asdx**"; // Замените на ваш пароль

            using (HttpClient client = new HttpClient())
            {
                // Добавляем заголовок Authorization с использованием базовой аутентификации
                var base64Credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64Credentials);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"GET запрос с аутентификацией выполнен успешно. Ответ:\n{result}");
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка при выполнении GET запроса. Код ответа: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
        }

        private void записьВБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Строка подключения к базе данных Access
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\repo\Avtovesi\AvtovesiDataBase.accdb;Persist Security Info=False;";

            // SQL-запрос для вставки данных
            string insertQuery = "INSERT INTO [avtoData] ([date], [licencePlate], [tara], [netto], [brutto]) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)";

            // Создание подключения
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Создание команды с параметрами
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    // Определение параметров и их значений
                    //command.Parameters.AddWithValue("@Value0", 3);
                    command.Parameters.AddWithValue("@Value1", "02-02-2024");
                    command.Parameters.AddWithValue("@Value2", "85Q123AA");
                    command.Parameters.AddWithValue("@Value3", "22.5");
                    command.Parameters.AddWithValue("@Value4", "65.5");
                    command.Parameters.AddWithValue("@Value5", "88.0");

                    // Открытие подключения
                    connection.Open();

                    try
                    {
                        // Выполнение команды
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"Добавлено {rowsAffected} строк.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}");
                    }         
                        
                }
            }
        }

        private void веббраузерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Webbrowser webbrowser = new Webbrowser();
            webbrowser.Show();
        }
    }
}

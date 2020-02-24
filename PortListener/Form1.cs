using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;
using DevExpress.XtraCharts;
using Timer = System.Threading.Timer;


namespace PortListener
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private SerialPort _serialPort;
        private string temizData;
        private DataTable mainDataTable;
        private int kalanSure = 0;
        private int ID = 0;


        public Form1()
        {
            InitializeComponent();
            PortConfiguration();
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            mainDataTable=new DataTable();
            mainDataTable.Columns.Add("ID",typeof(int));
            mainDataTable.Columns.Add("Tarih",typeof(DateTime));
            mainDataTable.Columns.Add("Sicaklik",typeof(float));
        }

        public void PortConfiguration()
        {
            try
            {
                string _portName = ConfigurationManager.AppSettings["PortName"];
                string _baudRate = ConfigurationManager.AppSettings["BaudRate"];
                string _StopBits = ConfigurationManager.AppSettings["StopBits"];
                string _DataBits = ConfigurationManager.AppSettings["DataBits"];
                string _Handshake = ConfigurationManager.AppSettings["Handshake"];
                string _RtsEnable = ConfigurationManager.AppSettings["RtsEnable"];
                string _Parity = ConfigurationManager.AppSettings["Parity"];

                _serialPort = new SerialPort();


                _serialPort.BaudRate = Convert.ToInt32(_baudRate);
                _serialPort.PortName = _portName;
                _serialPort.StopBits = (StopBits) Enum.Parse(typeof(StopBits), _StopBits);
                _serialPort.DataBits = Convert.ToInt32(_DataBits);
                _serialPort.Handshake = (Handshake) Enum.Parse(typeof(Handshake), _Handshake);
                _serialPort.RtsEnable = Boolean.Parse(_RtsEnable);
                _serialPort.DtrEnable = true;
                _serialPort.Parity = (Parity) Enum.Parse(typeof(Parity), _Parity);
                _serialPort.ReadTimeout = 1000;
                _serialPort.WriteTimeout = 1000;
                

                _serialPort.Open();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine+ _serialPort.DataBits);
            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                sp.NewLine = "C";
                temizData = sp.ReadLine();
                string[] metinler = temizData.Split(' ');
                temizData = metinler[metinler.Length - 2];
                if(!string.IsNullOrWhiteSpace(temizData))
                {
                   temizData= Regex.Match(temizData, @"\d+.+\d").Value;
                }

            }
            catch (Exception exception)
            {
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // PortConfiguration();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {


            int calismaSuresi = int.Parse(seCalismaSuresi.Value.ToString());
            int calismaAraligi = int.Parse(seCalismaAraligi.Value.ToString());

            if(calismaSuresi==0)
                MessageBox.Show("Çalışma süresi 0 olamaz!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else if(calismaAraligi==0)
                MessageBox.Show("Çalışma aralığı 0 olamaz!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                kalanSure = calismaSuresi * 60;
                timer1=new System.Windows.Forms.Timer();
                timer1.Interval = calismaAraligi * 1000;
                timer1.Enabled = true;
                timer1.Start();
                timer1.Tick += Timer1_Tick;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (kalanSure>0)
                {
                    _serialPort.WriteLine($"test");
                    Thread.Sleep(250);
                    ID++;
                    DataRow row = mainDataTable.NewRow();
                    row[0] = ID;
                    row[1] = DateTime.Now.ToString();
                    row[2] = !string.IsNullOrWhiteSpace(temizData) ? double.Parse(temizData, System.Globalization.CultureInfo.InvariantCulture):0;
                    mainDataTable.Rows.Add(row);
                    kalanSure -= timer1.Interval / 1000;
                    chartControl1.Series.Clear();

                    gridControl1.DataSource = mainDataTable;

                    Series series = new Series("Sicaklik", ViewType.Line );
                    chartControl1.Series.Add(series);

                    gridControl1.DataSource = mainDataTable;
                    series.DataSource = mainDataTable;

                    series.ArgumentScaleType = ScaleType.Numerical;
                    series.ArgumentDataMember = "ID";

                    series.ValueScaleType = ScaleType.Numerical;
                    series.ValueDataMembers.AddRange(new string[] { "Sicaklik" });
                }
                else if (kalanSure <= 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Çalışma süresi tamamlandı.");
                    kalanSure = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message+ "Timer1_Tick");
                timer1.Stop();
            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnExceleAktar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr =
                    MessageBox.Show("Kontrol çalışıyor ise durdurularak veriler dışarı aktarılacaktır. Onaylıyor musunuz?",
                        "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    timer1.Stop();
                   
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gridControl1.ExportToXlsx(dialog.FileName + ".xlsx");
                        MessageBox.Show("Kayıtlar başarıyla dışarı aktarıldı.");
                    }
                }

                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Istatistik dışarı aktarılacaktır. Onaylıyor musunuz?", "BİLGİ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    timer1.Stop();

                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter= "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        chartControl1.ExportToImage(dialog.FileName+".jpeg", ImageFormat.Jpeg);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            _serialPort.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
               DialogResult dr =  MessageBox.Show("Tüm datalar temizlenecektir. Onaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
               if (dr == DialogResult.Yes)
               {
                   timer1.Stop();
                   mainDataTable.Clear();
                   kalanSure = 0;
                   gridControl1.DataSource = null;
                   chartControl1.DataSource = null;
               }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialPort.Close();
        }
    }
}

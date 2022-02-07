using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ZXing;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace qrCodeApp
{
    

    public partial class Form1 : Form
    {
        private qrCodeData qrCode;
        private PrepareData database;
        private string defaultDataFile = "";
        private string fullFilePath = "";
        private string fileTemplate = "template.html";
        private string filePrint = "print.html";
        private string fullFilePathData = "";

        public Form1()
        {
            InitializeComponent();

            //LoadDefaultData("7705401340", "590343001", @"УФК по Пермскому краю (филиал ФГБУ «ФКП Росреестра» по Пермскому краю л/с 20566У86680)", "015773997", "00000000000000000000", "Отделение Пермь", "40102810145370000048", "00000000000000000510", "57701000");

            qrCode = new qrCodeData();

            defaultDataFile=ConfigData.ReadData();

            //fullFilePath = (AppDomain.CurrentDomain.BaseDirectory + $"\\{filePrint}");

            fullFilePath = (AppDomain.CurrentDomain.BaseDirectory + $"{filePrint}");

            fullFilePathData = (AppDomain.CurrentDomain.BaseDirectory + $"{defaultDataFile}");

           LoadDataFromXML($"{fullFilePathData}");
        }

        private void ReadDataFromForm()
        {
            qrCode.INN = this.tbINN.Text;
            qrCode.KPP = this.tbKPP.Text;
            qrCode.NameOrganizatiom = this.tbNameOrganizatiom.Text;
            qrCode.BIK = this.tbBIK.Text;
            qrCode.KorScore = this.tbKorScore.Text;
            qrCode.NameBank = this.tbNameBank.Text;
            qrCode.CheckingAccount = this.tbCheckingAccount.Text;
            qrCode.KBK = this.tbKBK.Text;
            qrCode.OKTMO = this.tbOKTMO.Text;

            qrCode.LastName = this.tbFIO.Text;
            qrCode.Purpose = this.tbPurposePayment.Text;
            qrCode.ADDRESS = this.tbAddress.Text;
            qrCode.PASSPORT = this.tbPassport.Text;
            qrCode.Sum = this.tbSum.Text;
        }

        private void LoadDefaultData(string inn, string kpp, string nameOrganizatiom, string bik, string korScore, string nameBank, string checkingAccount, string kbk, string oktmo, string lastname, string purpose, string address,  string passport, string sum)
        {
            this.tbINN.Text = inn;
            this.tbKPP.Text = kpp;
            tbNameOrganizatiom.Text = nameOrganizatiom;
            tbBIK.Text = bik;
            tbKorScore.Text = korScore;
            tbNameBank.Text = nameBank;
            tbCheckingAccount.Text = checkingAccount;
            tbKBK.Text = kbk;
            tbOKTMO.Text = oktmo;

            tbFIO.Text = lastname;
            tbPurposePayment.Text = purpose;
            tbAddress.Text = address;
            tbPassport.Text = passport;
            tbSum.Text = sum;
            
        }

        private void LoadDefaultData(qrCodeData dataLoad)
        {
            this.tbINN.Text = dataLoad.INN;
            this.tbKPP.Text = dataLoad.KPP;
            tbNameOrganizatiom.Text = dataLoad.NameOrganizatiom;
            tbBIK.Text = dataLoad.BIK;
            tbKorScore.Text = dataLoad.KorScore;
            tbNameBank.Text = dataLoad.NameBank;
            tbCheckingAccount.Text = dataLoad.CheckingAccount;
            tbKBK.Text = dataLoad.KBK;
            tbOKTMO.Text = dataLoad.OKTMO;

            tbFIO.Text = dataLoad.LastName;
            tbPurposePayment.Text = dataLoad.Purpose;
            tbAddress.Text = dataLoad.ADDRESS;
            tbPassport.Text = dataLoad.PASSPORT;
            tbSum.Text = dataLoad.Sum;
        }


        private void btnGeneration_Click(object sender, EventArgs e)
        {
            ReadDataFromForm();
            //pbQrCode.Image = WriteQR2(250, qrCode.CreateData());

            pbQrCode.Image = WriteQR2(250, qrCode.CreateData());

            pbQrCode.Image.Save("qrImg.png");

            CreateHTML2();

        }

        private static Bitmap WriteQR(int qrSize, string qrText)
        {
            var qr = new BarcodeWriter()
            {
                Renderer = new BitmapRenderer(),
                Format = BarcodeFormat.QR_CODE,
                Options =
                        {
                            Width = qrSize,
                            Height = qrSize,
                            PureBarcode = true
                        }
            };
            qr.Options.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            qr.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "utf-8");
            qr.Options.Hints.Add(EncodeHintType.MARGIN, 0);
            return qr.Write(qrText.Trim());
        }


        private static Bitmap WriteQR2(int qrSize, string qrText)
        {

            QrCodeEncodingOptions options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = qrSize,
                Height = qrSize,
            };

            var qr = new BarcodeWriter();
            qr.Format = BarcodeFormat.QR_CODE;
            qr.Options = options;

            string CodeText = @"ST00012|
Name=УФК по Пермскому краю (филиал ФГБУ «ФКП Росреестра» по Пермскому краю л/с 20566У86680)| 
PersonalAcc=03214643000000015600|
BankName=Отделение Пермь|
BIC=015773997|
CorrespAcc=40102810145370000048|
PayeeINN=7705401340|
KPP=590343001|
CBC=00000000000000000130|
OKTMO=57701000|
LastName=ИВАНОВ|
Purpose=Консультации, в том числе НДС. По договору ДОГОВОР|
PayerAddress=АДРЕС|
PayerIdType=ПАСПОРТ РФ|
PayerIdNum=ПАСПОРТ|
Sum=0";
            

            //CodeText = CodeText.Replace("[DOGOVOR]", " г.");
            //CodeText = CodeText.Replace("[PLAT]", "last_name");
            //CodeText = CodeText.Replace("[ADDRESS]", "");
            //CodeText = CodeText.Replace("[SUMMA]", "0");
            //CodeText = CodeText.Replace("[PASPORT]", "");

            return qr.Write(qrText.Trim());
           // return qr.Write(CodeText.Trim());
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Разработчик: Зеленин А.П.\nПрограмма: Генерация Qr-кода\nZeleninAP@59.kadastr.ru\nIP Phone: 8 59 2205\nДата разработки: 01.2021 \nВсе права защищены, {DateTime.Now.Year}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предусматривает сохранение информации в файл формата XML [В меню Файл-Сохранить].\n Также возможна загрузка ранее сохраненной конфигурации из файла.","Инструкция", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                string fileName = openFile.FileName;

                LoadDataFromXML(fileName);
            }
        }

        private void LoadDataFromXML(string fileName)
        {
            database = new PrepareData(fileName);
            database.Load();

            if (database != null)
            {
                LoadDefaultData(database[0].INN, database[0].KPP, database[0].NameOrganizatiom, database[0].BIK, database[0].KorScore, database[0].NameBank, database[0].CheckingAccount, database[0].KBK, database[0].OKTMO, database[0].LastName, database[0].Purpose, database[0].ADDRESS, database[0].PASSPORT, database[0].Sum);
            }
            else
            {
                MessageBox.Show("Данные из файла не загружены! Файл пустой или некорректный.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            //string result = "Строка 1\n\n";

            //result += "Строка 2\nСтрока 3";

            // объект для печати
            //PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            //printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            //PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            //printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            //if (printDialog.ShowDialog() == DialogResult.OK)
            //printDialog.Document.Print(); // печатаем


            //D:\\projects\\WindowsApp\\Zelenand\\qrCodeApp\\bin\\Debug\\print.html

            string printPath = @"D:\projects\WindowsApp\Zelenand\qrCodeApp\bin\Debug\print.html";

            using (var pd = new PrintDialog())
            {
                pd.ShowDialog();
                var info = new ProcessStartInfo()
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    FileName = printPath, //@"D:\Desktop\00762.pdf",
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                Process.Start(info);
            }

        }
        // обработчик события печати
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString("test", new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void CreateHTML()
        {
            string filepath = "print.html";
            FileStream source = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            webBrowser1.DocumentStream = source;
        }

        private void CreateHTML2()
        {
            //string fileTemplate = "../../template.html";
            //string filePrint = "../../print.html";

            string[] bufData = new string[200];
            int i = 0;
            string[] arrayS = File.ReadAllLines(fileTemplate);

            foreach (string s in arrayS)
            {

                bufData[i] = s.Replace("[INN]", database[0].INN)
                    .Replace("[KPP]", database[0].KPP)
                    .Replace("[NameOrganizatiom]", database[0].NameOrganizatiom)
                    .Replace("[BIK]", database[0].BIK)
                    .Replace("[KorScore]", database[0].KorScore)
                    .Replace("[NameBank]", database[0].NameBank)
                    .Replace("[CheckingAccount]", database[0].CheckingAccount)
                    .Replace("[KBK]", database[0].KBK)
                    .Replace("[OKTMO]", database[0].OKTMO)
                    .Replace("[LastName]", database[0].LastName)
                    .Replace("[Purpose]", database[0].Purpose)
                    .Replace("[ADDRESS]", database[0].ADDRESS)
                    .Replace("[PASSPORT]", database[0].PASSPORT)
                    .Replace("[Sum]", database[0].Sum)
                    .Replace("[IMG]", $"<img src='qrImg.png'>"); 
                i++;
            }

            File.WriteAllLines(filePrint, bufData);


            //fullFilePath = (AppDomain.CurrentDomain.BaseDirectory + $"\\{filePrint}");

            webBrowser1.Url = new Uri(fullFilePath);

        }

        private void печатьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string fileName = defaultDataFile;
            database = new PrepareData(fileName);
            ReadDataFromForm();
            database.Add(qrCode);
            database.Save();
            MessageBox.Show($"Данные успешно сохранены в XML файле: {fileName}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFile.FileName;
                database = new PrepareData(fileName);
                ReadDataFromForm();
                database.Add(qrCode);
                database.Save();
                MessageBox.Show($"Данные успешно сохранены в XML файле: {fileName}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    [Serializable]
    public class qrCodeData
    {
        public string INN { get; set; }
        public string KPP { get; set; }
        public string NameOrganizatiom { get; set; }
        public string BIK { get; set; }
        public string KorScore { get; set; }
        public string NameBank { get; set; }
        public string CheckingAccount { get; set; }
        public string KBK { get; set; }
        public string OKTMO { get; set; }

        public string LastName { get; set; }
        public string Purpose { get; set; }
        public string ADDRESS { get; set; }
        public string PASSPORT { get; set; }
        public string Sum { get; set; }

        public qrCodeData() { }

        public qrCodeData(string inn, string kpp, string nameOrganizatiom, string bik, string korScore, string nameBank, string checkingAccount, string kbk, string oktmo, string lastName, string purpose, string address, string passport, string sum) 
        {
            INN = inn; 
            KPP = kpp; 
            NameOrganizatiom = nameOrganizatiom; 
            BIK = bik; 
            KorScore = korScore; 
            NameBank = nameBank; 
            CheckingAccount = checkingAccount; 
            KBK = kbk; 
            OKTMO = oktmo;
            LastName = lastName;
            Purpose = purpose;
            ADDRESS = address;
            PASSPORT = passport;
            Sum = sum;
        }

        public string CreateData ()
        {
            //string CodeText = "ST00012|Name=УФК по Пермскому краю (филиал ФГБУ «ФКП Росреестра» по Пермскому краю л/с 20566У86680)| PersonalAcc=40102810145370000048|BankName=Отделение Пермь|BIC=015773997|CorrespAcc=00000000000000000000|" +
            //"PayeeINN=7705401340|KPP=590343001|CBC=00000000000000000510|OKTMO=57701000|LastName=[PLAT]|Purpose=Консультации, в том числе НДС. По договору [DOGOVOR]|PayerAddress=[ADDRESS]|PayerIdType=ПАСПОРТ РФ|PayerIdNum=[PASPORT]|Sum=[SUMMA]";

            //"ST00012|Name=УФК по Пермскому краю (филиал ФГБУ «ФКП Росреестра» по Пермскому краю л/с 20566У86680)|
            //PersonalAcc=03214643000000015600|
            // BankName=Отделение Пермь|
            // BIC=015773997|
            // CorrespAcc=40102810145370000048|
            //PayeeINN=7705401340|
            //  KPP=590343001|
            //  CBC=00000000000000000130|
            //  OKTMO=57701000|
            //   LastName =123|
            //   Purpose = Выезд к заявителю, в т.ч. НДС|
            // PayerAddress = |PayerIdType = ПАСПОРТ РФ|PayerIdNum =|Sum = "

//            string CodeText = @"ST00012|Name=УФК по Пермскому краю (филиал ФГБУ «ФКП Росреестра» по Пермскому краю л/с 20566У86680)| 
//PersonalAcc=03214643000000015600|
//BankName=Отделение Пермь|
//BIC=015773997|
//CorrespAcc=40102810145370000048|
//PayeeINN=7705401340|
//KPP=590343001|
//CBC=00000000000000000130|
//OKTMO=57701000|
//LastName=ИВАНОВ|
//Purpose=Консультации, в том числе НДС. По договору ДОГОВОР|
//PayerAddress=АДРЕС|
//PayerIdType=ПАСПОРТ РФ|
//PayerIdNum=ПАСПОРТ|
//Sum=0";




            string CodeText = String.Join("|", "ST00012", $"Name={NameOrganizatiom}", $"PersonalAcc={CheckingAccount}", $"BankName={NameBank}", $"BIC={BIK}", $"CorrespAcc={KorScore}", $"PayeeINN={INN}", $"KPP={KPP}", $"CBC={KBK}", $"OKTMO={OKTMO}", $"LastName={LastName}", $"Purpose={Purpose}", $"PayerAddress={ADDRESS}", $"PayerIdType=ПАСПОРТ РФ", $"PayerIdNum={PASSPORT}", $"Sum = {Sum}");

            return CodeText;
        }
    }

    class PrepareData
    {
        private List<qrCodeData> pdata;

        public string FileName { get; set; }

        public PrepareData() { }

        public PrepareData(string fileName)
        {
            FileName = fileName;
            pdata = new List<qrCodeData>();
        }

        public void Add(string inn, string kpp, string nameOrganizatiom, string bik, string korScore, string nameBank, string checkingAccount, string kbk, string oktmo, string lastname, string purpose, string address, string passport, string sum)
        {
            pdata.Add(new qrCodeData (inn, kpp, nameOrganizatiom, bik, korScore, nameBank, checkingAccount, kbk, oktmo, lastname, purpose, address, passport, sum));
        }

        public void Add(qrCodeData DataInput)
        {
            pdata.Add(DataInput);
        }

        public qrCodeData this[int index]
        {
            get { return pdata[index]; }
        }

        public void Save()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<qrCodeData>));

            using (FileStream file = new FileStream(FileName, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(file, pdata);
            }                
        }

        public void Load()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<qrCodeData>));

            try
            {
                using (FileStream file = new FileStream(FileName, FileMode.Open, FileAccess.Read))
                {
                    pdata = (List<qrCodeData>)xml.Deserialize(file);
                }
            }
            catch
            {
                MessageBox.Show($"Ошибка загрузки файла данных. Файл {FileName} не найден!", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    class ConfigData
    {
        static public string ReadData()
        {
            string[] data;
            using (StreamReader file = new StreamReader("config.txt"))
            {
                while (!file.EndOfStream)
                {
                    data = file.ReadLine().Split();
                    if (data[0].IndexOf("defaultFileDataName")!=-1)
                    {
                        return data[1];
                    }
                }
            }

            return String.Empty;
        }
    }
    

}
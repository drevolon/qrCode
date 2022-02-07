
namespace qrCodeApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnGeneration = new System.Windows.Forms.Button();
            this.groupBoxCenter = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOKTMO = new System.Windows.Forms.TextBox();
            this.tbNameBank = new System.Windows.Forms.TextBox();
            this.tbKBK = new System.Windows.Forms.TextBox();
            this.tbCheckingAccount = new System.Windows.Forms.TextBox();
            this.tbKorScore = new System.Windows.Forms.TextBox();
            this.tbBIK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameOrganizatiom = new System.Windows.Forms.TextBox();
            this.tbKPP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbINN = new System.Windows.Forms.TextBox();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPurposePayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbQrCode = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.groupBoxCenter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem1,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Загрузить";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструкцияToolStripMenuItem,
            this.разработчикToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.инструкцияToolStripMenuItem.Text = "Инструкция";
            this.инструкцияToolStripMenuItem.Click += new System.EventHandler(this.инструкцияToolStripMenuItem_Click);
            // 
            // разработчикToolStripMenuItem
            // 
            this.разработчикToolStripMenuItem.Name = "разработчикToolStripMenuItem";
            this.разработчикToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.разработчикToolStripMenuItem.Text = "Разработчик";
            this.разработчикToolStripMenuItem.Click += new System.EventHandler(this.разработчикToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1037, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnGeneration);
            this.panelBottom.Location = new System.Drawing.Point(12, 309);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1013, 44);
            this.panelBottom.TabIndex = 3;
            // 
            // btnGeneration
            // 
            this.btnGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGeneration.Location = new System.Drawing.Point(12, 3);
            this.btnGeneration.Name = "btnGeneration";
            this.btnGeneration.Size = new System.Drawing.Size(137, 38);
            this.btnGeneration.TabIndex = 24;
            this.btnGeneration.Text = "Генерировать";
            this.btnGeneration.UseVisualStyleBackColor = true;
            this.btnGeneration.Click += new System.EventHandler(this.btnGeneration_Click);
            // 
            // groupBoxCenter
            // 
            this.groupBoxCenter.Controls.Add(this.label12);
            this.groupBoxCenter.Controls.Add(this.label11);
            this.groupBoxCenter.Controls.Add(this.label10);
            this.groupBoxCenter.Controls.Add(this.label9);
            this.groupBoxCenter.Controls.Add(this.label6);
            this.groupBoxCenter.Controls.Add(this.tbOKTMO);
            this.groupBoxCenter.Controls.Add(this.tbNameBank);
            this.groupBoxCenter.Controls.Add(this.tbKBK);
            this.groupBoxCenter.Controls.Add(this.tbCheckingAccount);
            this.groupBoxCenter.Controls.Add(this.tbKorScore);
            this.groupBoxCenter.Controls.Add(this.tbBIK);
            this.groupBoxCenter.Controls.Add(this.label4);
            this.groupBoxCenter.Controls.Add(this.label3);
            this.groupBoxCenter.Controls.Add(this.label2);
            this.groupBoxCenter.Controls.Add(this.tbNameOrganizatiom);
            this.groupBoxCenter.Controls.Add(this.tbKPP);
            this.groupBoxCenter.Controls.Add(this.label1);
            this.groupBoxCenter.Controls.Add(this.tbINN);
            this.groupBoxCenter.Location = new System.Drawing.Point(12, 39);
            this.groupBoxCenter.Name = "groupBoxCenter";
            this.groupBoxCenter.Size = new System.Drawing.Size(490, 261);
            this.groupBoxCenter.TabIndex = 5;
            this.groupBoxCenter.TabStop = false;
            this.groupBoxCenter.Text = "Реквизиты организации, получателя платежа";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "ОКТМО";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "КБК";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Кор. счет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Наименование банка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Расчетный счет";
            // 
            // tbOKTMO
            // 
            this.tbOKTMO.Location = new System.Drawing.Point(263, 192);
            this.tbOKTMO.Name = "tbOKTMO";
            this.tbOKTMO.Size = new System.Drawing.Size(205, 20);
            this.tbOKTMO.TabIndex = 15;
            // 
            // tbNameBank
            // 
            this.tbNameBank.Location = new System.Drawing.Point(263, 75);
            this.tbNameBank.Name = "tbNameBank";
            this.tbNameBank.Size = new System.Drawing.Size(205, 20);
            this.tbNameBank.TabIndex = 14;
            // 
            // tbKBK
            // 
            this.tbKBK.Location = new System.Drawing.Point(263, 151);
            this.tbKBK.Name = "tbKBK";
            this.tbKBK.Size = new System.Drawing.Size(205, 20);
            this.tbKBK.TabIndex = 13;
            // 
            // tbCheckingAccount
            // 
            this.tbCheckingAccount.Location = new System.Drawing.Point(263, 112);
            this.tbCheckingAccount.Name = "tbCheckingAccount";
            this.tbCheckingAccount.Size = new System.Drawing.Size(205, 20);
            this.tbCheckingAccount.TabIndex = 12;
            // 
            // tbKorScore
            // 
            this.tbKorScore.Location = new System.Drawing.Point(263, 36);
            this.tbKorScore.Name = "tbKorScore";
            this.tbKorScore.Size = new System.Drawing.Size(205, 20);
            this.tbKorScore.TabIndex = 11;
            // 
            // tbBIK
            // 
            this.tbBIK.Location = new System.Drawing.Point(12, 192);
            this.tbBIK.Name = "tbBIK";
            this.tbBIK.Size = new System.Drawing.Size(205, 20);
            this.tbBIK.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "БИК";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Наим. получателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "КПП";
            // 
            // tbNameOrganizatiom
            // 
            this.tbNameOrganizatiom.Location = new System.Drawing.Point(12, 112);
            this.tbNameOrganizatiom.Multiline = true;
            this.tbNameOrganizatiom.Name = "tbNameOrganizatiom";
            this.tbNameOrganizatiom.Size = new System.Drawing.Size(205, 59);
            this.tbNameOrganizatiom.TabIndex = 3;
            // 
            // tbKPP
            // 
            this.tbKPP.Location = new System.Drawing.Point(12, 75);
            this.tbKPP.Name = "tbKPP";
            this.tbKPP.Size = new System.Drawing.Size(205, 20);
            this.tbKPP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ИНН";
            // 
            // tbINN
            // 
            this.tbINN.Location = new System.Drawing.Point(12, 36);
            this.tbINN.Name = "tbINN";
            this.tbINN.Size = new System.Drawing.Size(205, 20);
            this.tbINN.TabIndex = 0;
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(16, 36);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(205, 20);
            this.tbFIO.TabIndex = 7;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(16, 112);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(205, 20);
            this.tbAddress.TabIndex = 8;
            // 
            // tbPurposePayment
            // 
            this.tbPurposePayment.Location = new System.Drawing.Point(16, 151);
            this.tbPurposePayment.Name = "tbPurposePayment";
            this.tbPurposePayment.Size = new System.Drawing.Size(205, 20);
            this.tbPurposePayment.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ФИО";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Назначение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Адрес";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbPassport);
            this.groupBox1.Controls.Add(this.tbSum);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbFIO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbPurposePayment);
            this.groupBox1.Location = new System.Drawing.Point(509, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 261);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Реквизиты плательщика";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Паспорт";
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(16, 75);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(205, 20);
            this.tbPassport.TabIndex = 22;
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(16, 192);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(101, 20);
            this.tbSum.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Сумма";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbQrCode);
            this.groupBox2.Location = new System.Drawing.Point(746, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 264);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QrCode";
            // 
            // pbQrCode
            // 
            this.pbQrCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQrCode.Location = new System.Drawing.Point(3, 16);
            this.pbQrCode.Name = "pbQrCode";
            this.pbQrCode.Size = new System.Drawing.Size(273, 245);
            this.pbQrCode.TabIndex = 0;
            this.pbQrCode.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webBrowser1);
            this.groupBox3.Location = new System.Drawing.Point(13, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1012, 277);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Предварительный просмотр";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1006, 258);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Qr code генератор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.groupBoxCenter.ResumeLayout(false);
            this.groupBoxCenter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.GroupBox groupBoxCenter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOKTMO;
        private System.Windows.Forms.TextBox tbNameBank;
        private System.Windows.Forms.TextBox tbKBK;
        private System.Windows.Forms.TextBox tbCheckingAccount;
        private System.Windows.Forms.TextBox tbKorScore;
        private System.Windows.Forms.TextBox tbBIK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameOrganizatiom;
        private System.Windows.Forms.TextBox tbKPP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbINN;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPurposePayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGeneration;
        private System.Windows.Forms.PictureBox pbQrCode;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработчикToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
    }
}


namespace kiyafet_otomasyon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSatisIslem = new System.Windows.Forms.Button();
            this.btnStokIslem = new System.Windows.Forms.Button();
            this.btnUrunIslem = new System.Windows.Forms.Button();
            this.btnMusIslem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnKasiyerIslem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cikis.png");
            this.ımageList1.Images.SetKeyName(1, "list.png");
            this.ımageList1.Images.SetKeyName(2, "musteri.png");
            this.ımageList1.Images.SetKeyName(3, "person.png");
            this.ımageList1.Images.SetKeyName(4, "satış.png");
            this.ımageList1.Images.SetKeyName(5, "stok.png");
            this.ımageList1.Images.SetKeyName(6, "urun.png");
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "(none)";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(19, 38);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(83, 54);
            this.btnCikis.TabIndex = 140;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSatisIslem
            // 
            this.btnSatisIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatisIslem.ImageKey = "(none)";
            this.btnSatisIslem.ImageList = this.ımageList1;
            this.btnSatisIslem.Location = new System.Drawing.Point(352, 38);
            this.btnSatisIslem.Name = "btnSatisIslem";
            this.btnSatisIslem.Size = new System.Drawing.Size(83, 54);
            this.btnSatisIslem.TabIndex = 9;
            this.btnSatisIslem.Text = "Satış İşlemleri";
            this.btnSatisIslem.UseVisualStyleBackColor = true;
            this.btnSatisIslem.Click += new System.EventHandler(this.btnSatisIslem_Click);
            // 
            // btnStokIslem
            // 
            this.btnStokIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStokIslem.ImageKey = "(none)";
            this.btnStokIslem.ImageList = this.ımageList1;
            this.btnStokIslem.Location = new System.Drawing.Point(245, 38);
            this.btnStokIslem.Name = "btnStokIslem";
            this.btnStokIslem.Size = new System.Drawing.Size(83, 54);
            this.btnStokIslem.TabIndex = 8;
            this.btnStokIslem.Text = "Stok İşlemleri";
            this.btnStokIslem.UseVisualStyleBackColor = true;
            this.btnStokIslem.Click += new System.EventHandler(this.btnStokIslem_Click);
            // 
            // btnUrunIslem
            // 
            this.btnUrunIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUrunIslem.ImageList = this.ımageList1;
            this.btnUrunIslem.Location = new System.Drawing.Point(132, 38);
            this.btnUrunIslem.Name = "btnUrunIslem";
            this.btnUrunIslem.Size = new System.Drawing.Size(83, 54);
            this.btnUrunIslem.TabIndex = 6;
            this.btnUrunIslem.Text = "Ürün İşlemleri";
            this.btnUrunIslem.UseVisualStyleBackColor = true;
            this.btnUrunIslem.Click += new System.EventHandler(this.btnUrunIslem_Click);
            // 
            // btnMusIslem
            // 
            this.btnMusIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusIslem.ImageKey = "(none)";
            this.btnMusIslem.ImageList = this.ımageList1;
            this.btnMusIslem.Location = new System.Drawing.Point(16, 38);
            this.btnMusIslem.Name = "btnMusIslem";
            this.btnMusIslem.Size = new System.Drawing.Size(90, 54);
            this.btnMusIslem.TabIndex = 5;
            this.btnMusIslem.Text = "Müşteri İşlemleri";
            this.btnMusIslem.UseVisualStyleBackColor = true;
            this.btnMusIslem.Click += new System.EventHandler(this.btnMusIslem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUrunIslem);
            this.groupBox1.Controls.Add(this.btnMusIslem);
            this.groupBox1.Controls.Add(this.btnSatisIslem);
            this.groupBox1.Controls.Add(this.btnStokIslem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 127);
            this.groupBox1.TabIndex = 142;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Yönetim Paneli";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCikis);
            this.groupBox3.Location = new System.Drawing.Point(470, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 126);
            this.groupBox3.TabIndex = 144;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Çıkış";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(474, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 160);
            this.groupBox4.TabIndex = 145;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İnfo";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(15, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "İnfo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKasiyerIslem
            // 
            this.btnKasiyerIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasiyerIslem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKasiyerIslem.ImageKey = "(none)";
            this.btnKasiyerIslem.ImageList = this.ımageList1;
            this.btnKasiyerIslem.Location = new System.Drawing.Point(159, 34);
            this.btnKasiyerIslem.Name = "btnKasiyerIslem";
            this.btnKasiyerIslem.Size = new System.Drawing.Size(139, 50);
            this.btnKasiyerIslem.TabIndex = 7;
            this.btnKasiyerIslem.Text = "Kasiyer İşlemleri";
            this.btnKasiyerIslem.UseVisualStyleBackColor = true;
            this.btnKasiyerIslem.Click += new System.EventHandler(this.btnKasiyerIslem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(16, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 141;
            this.button1.Text = "Satışları Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(314, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 51);
            this.button3.TabIndex = 142;
            this.button3.Text = "Kullanıcı Kayıt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnKasiyerIslem);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 160);
            this.groupBox2.TabIndex = 143;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yönetici Paneli";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(16, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 45);
            this.button4.TabIndex = 146;
            this.button4.Text = "Silinmis Kasiyer Bilgileri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(159, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 45);
            this.button5.TabIndex = 147;
            this.button5.Text = "Silinmis Müsteri Bilgileri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(314, 105);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 45);
            this.button6.TabIndex = 148;
            this.button6.Text = "Silinmiş Ürün Bilgisi";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 325);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "KSY Kıyafet Mağaza Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusIslem;
        private System.Windows.Forms.Button btnStokIslem;
        private System.Windows.Forms.Button btnSatisIslem;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnUrunIslem;
        public System.Windows.Forms.Button btnKasiyerIslem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;

    }
}


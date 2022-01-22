
namespace Dashboard
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.btnRobot = new System.Windows.Forms.Button();
            this.btnHeaters = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCyan = new System.Windows.Forms.Button();
            this.btnMagenta = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnRobot);
            this.panel1.Controls.Add(this.btnHeaters);
            this.panel1.Controls.Add(this.btnBlack);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnCyan);
            this.panel1.Controls.Add(this.btnMagenta);
            this.panel1.Controls.Add(this.btnYellow);
            this.panel1.Controls.Add(this.btnMain);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(41, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(200, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Main";
            this.lblTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(522, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 19);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "  Arama  Yap";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(874, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormLoader.Location = new System.Drawing.Point(186, 100);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(765, 477);
            this.pnlFormLoader.TabIndex = 4;
            // 
            // btnRobot
            // 
            this.btnRobot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRobot.FlatAppearance.BorderSize = 0;
            this.btnRobot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRobot.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRobot.Image = global::Dashboard.Properties.Resources.robotic_arm;
            this.btnRobot.Location = new System.Drawing.Point(0, 396);
            this.btnRobot.Name = "btnRobot";
            this.btnRobot.Size = new System.Drawing.Size(186, 42);
            this.btnRobot.TabIndex = 8;
            this.btnRobot.Text = "Robot";
            this.btnRobot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRobot.UseVisualStyleBackColor = true;
            this.btnRobot.Click += new System.EventHandler(this.btnRobot_Click);
            this.btnRobot.Leave += new System.EventHandler(this.btnRobot_Leave);
            // 
            // btnHeaters
            // 
            this.btnHeaters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeaters.FlatAppearance.BorderSize = 0;
            this.btnHeaters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaters.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeaters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHeaters.Image = global::Dashboard.Properties.Resources.celsius__1_;
            this.btnHeaters.Location = new System.Drawing.Point(0, 354);
            this.btnHeaters.Name = "btnHeaters";
            this.btnHeaters.Size = new System.Drawing.Size(186, 42);
            this.btnHeaters.TabIndex = 7;
            this.btnHeaters.Text = "Heaters";
            this.btnHeaters.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHeaters.UseVisualStyleBackColor = true;
            this.btnHeaters.Click += new System.EventHandler(this.button5_Click);
            this.btnHeaters.Leave += new System.EventHandler(this.btnHeaters_Leave);
            // 
            // btnBlack
            // 
            this.btnBlack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBlack.FlatAppearance.BorderSize = 0;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBlack.Image = global::Dashboard.Properties.Resources.cmyk;
            this.btnBlack.Location = new System.Drawing.Point(0, 312);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(186, 42);
            this.btnBlack.TabIndex = 6;
            this.btnBlack.Text = "Black ";
            this.btnBlack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            this.btnBlack.Leave += new System.EventHandler(this.btnBlack_Leave);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::Dashboard.Properties.Resources.settings__1_;
            this.btnSettings.Location = new System.Drawing.Point(-3, 535);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 42);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnCyan
            // 
            this.btnCyan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCyan.FlatAppearance.BorderSize = 0;
            this.btnCyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCyan.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCyan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCyan.Image = global::Dashboard.Properties.Resources.cmyk;
            this.btnCyan.Location = new System.Drawing.Point(0, 270);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(186, 42);
            this.btnCyan.TabIndex = 4;
            this.btnCyan.Text = "Cyan";
            this.btnCyan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCyan.UseVisualStyleBackColor = true;
            this.btnCyan.Click += new System.EventHandler(this.button3_Click);
            this.btnCyan.Leave += new System.EventHandler(this.btnCyan_Leave);
            // 
            // btnMagenta
            // 
            this.btnMagenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMagenta.FlatAppearance.BorderSize = 0;
            this.btnMagenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagenta.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMagenta.Image = global::Dashboard.Properties.Resources.cmyk;
            this.btnMagenta.Location = new System.Drawing.Point(0, 228);
            this.btnMagenta.Name = "btnMagenta";
            this.btnMagenta.Size = new System.Drawing.Size(186, 42);
            this.btnMagenta.TabIndex = 3;
            this.btnMagenta.Text = "Magenta";
            this.btnMagenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMagenta.UseVisualStyleBackColor = true;
            this.btnMagenta.Click += new System.EventHandler(this.btnMagenta_Click);
            this.btnMagenta.Leave += new System.EventHandler(this.btnMagenta_Leave);
            // 
            // btnYellow
            // 
            this.btnYellow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYellow.FlatAppearance.BorderSize = 0;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYellow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnYellow.Image = global::Dashboard.Properties.Resources.cmyk;
            this.btnYellow.Location = new System.Drawing.Point(0, 186);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(186, 42);
            this.btnYellow.TabIndex = 2;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            this.btnYellow.Leave += new System.EventHandler(this.btnYellow_Leave);
            // 
            // btnMain
            // 
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMain.Image = global::Dashboard.Properties.Resources.home__2_;
            this.btnMain.Location = new System.Drawing.Point(0, 144);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(186, 42);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Main";
            this.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnMain.Leave += new System.EventHandler(this.btnMain_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.jetron_logo_mavi;
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHeaters;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCyan;
        private System.Windows.Forms.Button btnMagenta;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnRobot;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlFormLoader;
    }
}


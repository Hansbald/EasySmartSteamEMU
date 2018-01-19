namespace EasySmartSteamEMU
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb64Bit = new System.Windows.Forms.CheckBox();
            this.cbChangeName = new System.Windows.Forms.CheckBox();
            this.cbExeIcon = new System.Windows.Forms.CheckBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to .exe:";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(15, 25);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(200, 20);
            this.tbPath.TabIndex = 1;
            this.tbPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbPath_DragDrop);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(221, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 20);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb64Bit);
            this.groupBox1.Controls.Add(this.cbChangeName);
            this.groupBox1.Controls.Add(this.cbExeIcon);
            this.groupBox1.Location = new System.Drawing.Point(15, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // cb64Bit
            // 
            this.cb64Bit.AutoSize = true;
            this.cb64Bit.Location = new System.Drawing.Point(6, 42);
            this.cb64Bit.Name = "cb64Bit";
            this.cb64Bit.Size = new System.Drawing.Size(75, 17);
            this.cb64Bit.TabIndex = 2;
            this.cb64Bit.Text = "Use 64 Bit";
            this.cb64Bit.UseVisualStyleBackColor = true;
            // 
            // cbChangeName
            // 
            this.cbChangeName.AutoSize = true;
            this.cbChangeName.Enabled = false;
            this.cbChangeName.Location = new System.Drawing.Point(6, 65);
            this.cbChangeName.Name = "cbChangeName";
            this.cbChangeName.Size = new System.Drawing.Size(142, 17);
            this.cbChangeName.TabIndex = 1;
            this.cbChangeName.Text = "Rename launcher to exe";
            this.cbChangeName.UseVisualStyleBackColor = true;
            // 
            // cbExeIcon
            // 
            this.cbExeIcon.AutoSize = true;
            this.cbExeIcon.Location = new System.Drawing.Point(6, 19);
            this.cbExeIcon.Name = "cbExeIcon";
            this.cbExeIcon.Size = new System.Drawing.Size(92, 17);
            this.cbExeIcon.TabIndex = 0;
            this.cbExeIcon.Text = "Use .exe Icon";
            this.cbExeIcon.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(15, 51);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(230, 20);
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgIcon);
            this.groupBox2.Location = new System.Drawing.Point(15, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(79, 91);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icon";
            // 
            // imgIcon
            // 
            this.imgIcon.Location = new System.Drawing.Point(6, 19);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(64, 64);
            this.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIcon.TabIndex = 0;
            this.imgIcon.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(131, 219);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made by Hansbald";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 278);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Easy SSE Linker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbChangeName;
        private System.Windows.Forms.CheckBox cbExeIcon;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imgIcon;
        private System.Windows.Forms.CheckBox cb64Bit;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


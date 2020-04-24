using System.Drawing;
namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dllName = new System.Windows.Forms.TextBox();
            this.searchBttn = new System.Windows.Forms.Button();
            this.dllLabel = new System.Windows.Forms.Label();
            this.processLabel = new System.Windows.Forms.Label();
            this.processName = new System.Windows.Forms.TextBox();
            this.searchBttn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsBttn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.bk = new System.Windows.Forms.Label();
            this.tx = new System.Windows.Forms.Label();
            this.bt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(63, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inject";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dllName
            // 
            this.dllName.Location = new System.Drawing.Point(63, 9);
            this.dllName.Name = "dllName";
            this.dllName.Size = new System.Drawing.Size(131, 20);
            this.dllName.TabIndex = 1;
            // 
            // searchBttn
            // 
            this.searchBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBttn.Location = new System.Drawing.Point(200, 9);
            this.searchBttn.Name = "searchBttn";
            this.searchBttn.Size = new System.Drawing.Size(60, 20);
            this.searchBttn.TabIndex = 2;
            this.searchBttn.Text = "Search";
            this.searchBttn.UseVisualStyleBackColor = true;
            this.searchBttn.Click += new System.EventHandler(this.SearchBttn_Click);
            // 
            // dllLabel
            // 
            this.dllLabel.AutoSize = true;
            this.dllLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.dllLabel.Location = new System.Drawing.Point(21, 12);
            this.dllLabel.Name = "dllLabel";
            this.dllLabel.Size = new System.Drawing.Size(27, 13);
            this.dllLabel.TabIndex = 3;
            this.dllLabel.Text = "DLL";
            this.dllLabel.Click += new System.EventHandler(this.DllLabel_Click);
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.processLabel.Location = new System.Drawing.Point(12, 40);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(45, 13);
            this.processLabel.TabIndex = 4;
            this.processLabel.Text = "Process";
            this.processLabel.Click += new System.EventHandler(this.ProcessLabel_Click);
            // 
            // processName
            // 
            this.processName.Location = new System.Drawing.Point(63, 37);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(131, 20);
            this.processName.TabIndex = 5;
            // 
            // searchBttn2
            // 
            this.searchBttn2.BackColor = System.Drawing.Color.SteelBlue;
            this.searchBttn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBttn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBttn2.Location = new System.Drawing.Point(200, 37);
            this.searchBttn2.Name = "searchBttn2";
            this.searchBttn2.Size = new System.Drawing.Size(60, 20);
            this.searchBttn2.TabIndex = 6;
            this.searchBttn2.Text = "Search";
            this.searchBttn2.UseVisualStyleBackColor = false;
            this.searchBttn2.Click += new System.EventHandler(this.SearchBttn2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label1";
            // 
            // settingsBttn
            // 
            this.settingsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settingsBttn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBttn.Location = new System.Drawing.Point(12, 57);
            this.settingsBttn.Name = "settingsBttn";
            this.settingsBttn.Size = new System.Drawing.Size(40, 30);
            this.settingsBttn.TabIndex = 8;
            this.settingsBttn.Text = "⚙️";
            this.settingsBttn.UseVisualStyleBackColor = true;
            this.settingsBttn.Click += new System.EventHandler(this.SettingsBttn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(54, 130);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(35, 13);
            this.timerLabel.TabIndex = 9;
            this.timerLabel.Text = "label1";
            // 
            // bk
            // 
            this.bk.AutoSize = true;
            this.bk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bk.Location = new System.Drawing.Point(123, 106);
            this.bk.Name = "bk";
            this.bk.Size = new System.Drawing.Size(19, 13);
            this.bk.TabIndex = 10;
            this.bk.Text = "bk";
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tx.Location = new System.Drawing.Point(123, 130);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(15, 13);
            this.tx.TabIndex = 11;
            this.tx.Text = "tx";
            // 
            // bt
            // 
            this.bt.AutoSize = true;
            this.bt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt.Location = new System.Drawing.Point(123, 153);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(16, 13);
            this.bt.TabIndex = 12;
            this.bt.Text = "bt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(271, 93);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.bk);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.settingsBttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBttn2);
            this.Controls.Add(this.processName);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.dllLabel);
            this.Controls.Add(this.searchBttn);
            this.Controls.Add(this.dllName);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(287, 132);
            this.Name = "Form1";
            this.Text = "Blu Injector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dllName;
        private System.Windows.Forms.Button searchBttn;
        private System.Windows.Forms.Label dllLabel;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.TextBox processName;
        private System.Windows.Forms.Button searchBttn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button settingsBttn;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label bk;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.Label bt;
    }
}


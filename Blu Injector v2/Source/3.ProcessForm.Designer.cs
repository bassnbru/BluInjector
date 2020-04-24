namespace BluInjector
{
    partial class ProcessForm
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
            this.selectBttn = new System.Windows.Forms.Button();
            this.processBttn = new System.Windows.Forms.Button();
            this.windowBttn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListBox();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // selectBttn
            // 
            this.selectBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBttn.Location = new System.Drawing.Point(12, 150);
            this.selectBttn.Name = "selectBttn";
            this.selectBttn.Size = new System.Drawing.Size(181, 23);
            this.selectBttn.TabIndex = 3;
            this.selectBttn.Text = "Select";
            this.selectBttn.UseVisualStyleBackColor = true;
            this.selectBttn.Click += new System.EventHandler(this.SelectBttn_Click);
            // 
            // processBttn
            // 
            this.processBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.processBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processBttn.Location = new System.Drawing.Point(12, 179);
            this.processBttn.Name = "processBttn";
            this.processBttn.Size = new System.Drawing.Size(87, 23);
            this.processBttn.TabIndex = 4;
            this.processBttn.Text = "Process List";
            this.processBttn.UseVisualStyleBackColor = true;
            this.processBttn.Click += new System.EventHandler(this.ProcessBttn_Click);
            // 
            // windowBttn
            // 
            this.windowBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.windowBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowBttn.Location = new System.Drawing.Point(106, 179);
            this.windowBttn.Name = "windowBttn";
            this.windowBttn.Size = new System.Drawing.Size(87, 23);
            this.windowBttn.TabIndex = 5;
            this.windowBttn.Text = "Window List";
            this.windowBttn.UseVisualStyleBackColor = true;
            this.windowBttn.Click += new System.EventHandler(this.WindowBttn_Click);
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FormattingEnabled = true;
            this.listView.ItemHeight = 16;
            this.listView.Location = new System.Drawing.Point(12, 13);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(181, 132);
            this.listView.Sorted = true;
            this.listView.TabIndex = 6;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 5000;
            this.refreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(207, 214);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.windowBttn);
            this.Controls.Add(this.processBttn);
            this.Controls.Add(this.selectBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(223, 253);
            this.Name = "ProcessForm";
            this.Text = "Process List";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button selectBttn;
        private System.Windows.Forms.Button processBttn;
        private System.Windows.Forms.Button windowBttn;
        private System.Windows.Forms.ListBox listView;
        private System.Windows.Forms.Timer refreshTimer;
    }
}
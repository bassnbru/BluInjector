namespace BluInjector
{
    partial class SettingsForm
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
            this.closeInjectBox = new System.Windows.Forms.CheckBox();
            this.color1bttn = new System.Windows.Forms.Button();
            this.color2bttn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.color3bttn = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.GroupBox();
            this.bttnLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.bkLabel = new System.Windows.Forms.Label();
            this.applyBttn = new System.Windows.Forms.Button();
            this.injectSound = new System.Windows.Forms.CheckBox();
            this.injMethodCombo = new System.Windows.Forms.ComboBox();
            this.injMethodLabel = new System.Windows.Forms.Label();
            this.injectionBox = new System.Windows.Forms.GroupBox();
            this.delayLabel = new System.Windows.Forms.Label();
            this.delaySlider = new System.Windows.Forms.TrackBar();
            this.delayInject = new System.Windows.Forms.CheckBox();
            this.colorBox.SuspendLayout();
            this.injectionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaySlider)).BeginInit();
            this.SuspendLayout();
            // 
            // closeInjectBox
            // 
            this.closeInjectBox.AutoSize = true;
            this.closeInjectBox.BackColor = System.Drawing.Color.Transparent;
            this.closeInjectBox.Location = new System.Drawing.Point(7, 19);
            this.closeInjectBox.Name = "closeInjectBox";
            this.closeInjectBox.Size = new System.Drawing.Size(96, 17);
            this.closeInjectBox.TabIndex = 0;
            this.closeInjectBox.Text = "Close on Inject";
            this.closeInjectBox.UseVisualStyleBackColor = false;
            // 
            // color1bttn
            // 
            this.color1bttn.BackColor = System.Drawing.Color.Transparent;
            this.color1bttn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.color1bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color1bttn.Location = new System.Drawing.Point(6, 19);
            this.color1bttn.Name = "color1bttn";
            this.color1bttn.Size = new System.Drawing.Size(111, 25);
            this.color1bttn.TabIndex = 1;
            this.color1bttn.UseVisualStyleBackColor = false;
            this.color1bttn.Click += new System.EventHandler(this.Color1bttn_Click);
            // 
            // color2bttn
            // 
            this.color2bttn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.color2bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color2bttn.Location = new System.Drawing.Point(7, 50);
            this.color2bttn.Name = "color2bttn";
            this.color2bttn.Size = new System.Drawing.Size(110, 23);
            this.color2bttn.TabIndex = 2;
            this.color2bttn.UseVisualStyleBackColor = true;
            this.color2bttn.Click += new System.EventHandler(this.Color2bttn_Click);
            // 
            // color3bttn
            // 
            this.color3bttn.Cursor = System.Windows.Forms.Cursors.Cross;
            this.color3bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.color3bttn.Location = new System.Drawing.Point(7, 79);
            this.color3bttn.Name = "color3bttn";
            this.color3bttn.Size = new System.Drawing.Size(110, 23);
            this.color3bttn.TabIndex = 3;
            this.color3bttn.UseVisualStyleBackColor = true;
            this.color3bttn.Click += new System.EventHandler(this.Color3bttn_Click);
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Transparent;
            this.colorBox.Controls.Add(this.bttnLabel);
            this.colorBox.Controls.Add(this.textLabel);
            this.colorBox.Controls.Add(this.bkLabel);
            this.colorBox.Controls.Add(this.color1bttn);
            this.colorBox.Controls.Add(this.color3bttn);
            this.colorBox.Controls.Add(this.color2bttn);
            this.colorBox.Location = new System.Drawing.Point(189, 12);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(185, 111);
            this.colorBox.TabIndex = 4;
            this.colorBox.TabStop = false;
            this.colorBox.Text = "Colors";
            // 
            // bttnLabel
            // 
            this.bttnLabel.AutoSize = true;
            this.bttnLabel.Location = new System.Drawing.Point(123, 84);
            this.bttnLabel.Name = "bttnLabel";
            this.bttnLabel.Size = new System.Drawing.Size(38, 13);
            this.bttnLabel.TabIndex = 6;
            this.bttnLabel.Text = "Button";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(123, 55);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(28, 13);
            this.textLabel.TabIndex = 5;
            this.textLabel.Text = "Text";
            // 
            // bkLabel
            // 
            this.bkLabel.AutoSize = true;
            this.bkLabel.Location = new System.Drawing.Point(123, 25);
            this.bkLabel.Name = "bkLabel";
            this.bkLabel.Size = new System.Drawing.Size(59, 13);
            this.bkLabel.TabIndex = 4;
            this.bkLabel.Text = "Backgrond";
            // 
            // applyBttn
            // 
            this.applyBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applyBttn.Location = new System.Drawing.Point(189, 147);
            this.applyBttn.Name = "applyBttn";
            this.applyBttn.Size = new System.Drawing.Size(182, 24);
            this.applyBttn.TabIndex = 7;
            this.applyBttn.Text = "Save Settings";
            this.applyBttn.UseVisualStyleBackColor = true;
            this.applyBttn.Click += new System.EventHandler(this.ApplyBttn_Click);
            // 
            // injectSound
            // 
            this.injectSound.AutoSize = true;
            this.injectSound.Location = new System.Drawing.Point(7, 42);
            this.injectSound.Name = "injectSound";
            this.injectSound.Size = new System.Drawing.Size(101, 17);
            this.injectSound.TabIndex = 8;
            this.injectSound.Text = "Sound on Inject";
            this.injectSound.UseVisualStyleBackColor = true;
            // 
            // injMethodCombo
            // 
            this.injMethodCombo.FormattingEnabled = true;
            this.injMethodCombo.Items.AddRange(new object[] {
            "Standard",
            "Manual Mapping"});
            this.injMethodCombo.Location = new System.Drawing.Point(7, 144);
            this.injMethodCombo.Name = "injMethodCombo";
            this.injMethodCombo.Size = new System.Drawing.Size(148, 21);
            this.injMethodCombo.TabIndex = 9;
            this.injMethodCombo.Text = "Standard";
            // 
            // injMethodLabel
            // 
            this.injMethodLabel.AutoSize = true;
            this.injMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injMethodLabel.Location = new System.Drawing.Point(6, 126);
            this.injMethodLabel.Name = "injMethodLabel";
            this.injMethodLabel.Size = new System.Drawing.Size(104, 15);
            this.injMethodLabel.TabIndex = 10;
            this.injMethodLabel.Text = "Injection Methods";
            // 
            // injectionBox
            // 
            this.injectionBox.Controls.Add(this.delayLabel);
            this.injectionBox.Controls.Add(this.delaySlider);
            this.injectionBox.Controls.Add(this.delayInject);
            this.injectionBox.Controls.Add(this.closeInjectBox);
            this.injectionBox.Controls.Add(this.injMethodLabel);
            this.injectionBox.Controls.Add(this.injMethodCombo);
            this.injectionBox.Controls.Add(this.injectSound);
            this.injectionBox.Location = new System.Drawing.Point(9, 12);
            this.injectionBox.Name = "injectionBox";
            this.injectionBox.Size = new System.Drawing.Size(166, 177);
            this.injectionBox.TabIndex = 11;
            this.injectionBox.TabStop = false;
            this.injectionBox.Text = "Injection";
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.BackColor = System.Drawing.Color.Transparent;
            this.delayLabel.Location = new System.Drawing.Point(137, 87);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(18, 13);
            this.delayLabel.TabIndex = 12;
            this.delayLabel.Text = "1s";
            // 
            // delaySlider
            // 
            this.delaySlider.LargeChange = 10;
            this.delaySlider.Location = new System.Drawing.Point(3, 84);
            this.delaySlider.Maximum = 15;
            this.delaySlider.Minimum = 1;
            this.delaySlider.Name = "delaySlider";
            this.delaySlider.Size = new System.Drawing.Size(141, 45);
            this.delaySlider.TabIndex = 0;
            this.delaySlider.Value = 1;
            this.delaySlider.Scroll += new System.EventHandler(this.DelaySlider_Scroll);
            // 
            // delayInject
            // 
            this.delayInject.AutoSize = true;
            this.delayInject.Location = new System.Drawing.Point(7, 65);
            this.delayInject.Name = "delayInject";
            this.delayInject.Size = new System.Drawing.Size(82, 17);
            this.delayInject.TabIndex = 11;
            this.delayInject.Text = "Delay Inject";
            this.delayInject.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(382, 198);
            this.Controls.Add(this.injectionBox);
            this.Controls.Add(this.applyBttn);
            this.Controls.Add(this.colorBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(398, 237);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.colorBox.ResumeLayout(false);
            this.colorBox.PerformLayout();
            this.injectionBox.ResumeLayout(false);
            this.injectionBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaySlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox closeInjectBox;
        private System.Windows.Forms.Button color1bttn;
        private System.Windows.Forms.Button color2bttn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button color3bttn;
        private System.Windows.Forms.GroupBox colorBox;
        private System.Windows.Forms.Label bttnLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label bkLabel;
        private System.Windows.Forms.Button applyBttn;
        private System.Windows.Forms.CheckBox injectSound;
        private System.Windows.Forms.ComboBox injMethodCombo;
        private System.Windows.Forms.Label injMethodLabel;
        private System.Windows.Forms.GroupBox injectionBox;
        private System.Windows.Forms.TrackBar delaySlider;
        private System.Windows.Forms.CheckBox delayInject;
        private System.Windows.Forms.Label delayLabel;
    }
}
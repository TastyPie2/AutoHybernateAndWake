namespace AutoHybernateAndWake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordSaveButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SleepAndWakeTab = new System.Windows.Forms.TabPage();
            this.SundayCheckbox = new System.Windows.Forms.CheckBox();
            this.SaturedayCheckbox = new System.Windows.Forms.CheckBox();
            this.FridayCheckbox = new System.Windows.Forms.CheckBox();
            this.ThursdayCheckbox = new System.Windows.Forms.CheckBox();
            this.WednesdayCheckbox = new System.Windows.Forms.CheckBox();
            this.TuesdayCheckbox = new System.Windows.Forms.CheckBox();
            this.MondayCheckbox = new System.Windows.Forms.CheckBox();
            this.SleepAndWakeDisableButton = new System.Windows.Forms.Button();
            this.SleepAndWakeEnableButton = new System.Windows.Forms.Button();
            this.SaveSleepWakeTime = new System.Windows.Forms.Button();
            this.WakeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SleepTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.AutoLogonTab = new System.Windows.Forms.TabPage();
            this.EnableAutoLogon = new System.Windows.Forms.Button();
            this.DisableAutoLogon = new System.Windows.Forms.Button();
            this.TestTab = new System.Windows.Forms.TabPage();
            this.TestProgressbar = new System.Windows.Forms.ProgressBar();
            this.TestRestartButton = new System.Windows.Forms.Button();
            this.TestSleepButton = new System.Windows.Forms.Button();
            this.TestWakeButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SleepAndWakeTab.SuspendLayout();
            this.AutoLogonTab.SuspendLayout();
            this.TestTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(6, 21);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(100, 23);
            this.PasswordTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // PasswordSaveButton
            // 
            this.PasswordSaveButton.Location = new System.Drawing.Point(6, 50);
            this.PasswordSaveButton.Name = "PasswordSaveButton";
            this.PasswordSaveButton.Size = new System.Drawing.Size(75, 23);
            this.PasswordSaveButton.TabIndex = 2;
            this.PasswordSaveButton.Text = "Save";
            this.PasswordSaveButton.UseVisualStyleBackColor = true;
            this.PasswordSaveButton.Click += new System.EventHandler(this.SaveAutoLogonPassword_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SleepAndWakeTab);
            this.tabControl1.Controls.Add(this.AutoLogonTab);
            this.tabControl1.Controls.Add(this.TestTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 3;
            // 
            // SleepAndWakeTab
            // 
            this.SleepAndWakeTab.Controls.Add(this.SundayCheckbox);
            this.SleepAndWakeTab.Controls.Add(this.SaturedayCheckbox);
            this.SleepAndWakeTab.Controls.Add(this.FridayCheckbox);
            this.SleepAndWakeTab.Controls.Add(this.ThursdayCheckbox);
            this.SleepAndWakeTab.Controls.Add(this.WednesdayCheckbox);
            this.SleepAndWakeTab.Controls.Add(this.TuesdayCheckbox);
            this.SleepAndWakeTab.Controls.Add(this.MondayCheckbox);
            this.SleepAndWakeTab.Controls.Add(this.SleepAndWakeDisableButton);
            this.SleepAndWakeTab.Controls.Add(this.SleepAndWakeEnableButton);
            this.SleepAndWakeTab.Controls.Add(this.SaveSleepWakeTime);
            this.SleepAndWakeTab.Controls.Add(this.WakeTimePicker);
            this.SleepAndWakeTab.Controls.Add(this.label2);
            this.SleepAndWakeTab.Controls.Add(this.SleepTimePicker);
            this.SleepAndWakeTab.Controls.Add(this.label3);
            this.SleepAndWakeTab.Location = new System.Drawing.Point(4, 24);
            this.SleepAndWakeTab.Name = "SleepAndWakeTab";
            this.SleepAndWakeTab.Padding = new System.Windows.Forms.Padding(3);
            this.SleepAndWakeTab.Size = new System.Drawing.Size(768, 398);
            this.SleepAndWakeTab.TabIndex = 0;
            this.SleepAndWakeTab.Text = "SleepAndWake";
            this.SleepAndWakeTab.UseVisualStyleBackColor = true;
            // 
            // SundayCheckbox
            // 
            this.SundayCheckbox.AutoSize = true;
            this.SundayCheckbox.Location = new System.Drawing.Point(477, 94);
            this.SundayCheckbox.Name = "SundayCheckbox";
            this.SundayCheckbox.Size = new System.Drawing.Size(65, 19);
            this.SundayCheckbox.TabIndex = 21;
            this.SundayCheckbox.Text = "Sunday";
            this.SundayCheckbox.UseVisualStyleBackColor = true;
            // 
            // SaturedayCheckbox
            // 
            this.SaturedayCheckbox.AutoSize = true;
            this.SaturedayCheckbox.Checked = true;
            this.SaturedayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaturedayCheckbox.Location = new System.Drawing.Point(399, 94);
            this.SaturedayCheckbox.Name = "SaturedayCheckbox";
            this.SaturedayCheckbox.Size = new System.Drawing.Size(72, 19);
            this.SaturedayCheckbox.TabIndex = 20;
            this.SaturedayCheckbox.Text = "Saturday";
            this.SaturedayCheckbox.UseVisualStyleBackColor = true;
            // 
            // FridayCheckbox
            // 
            this.FridayCheckbox.AutoSize = true;
            this.FridayCheckbox.Checked = true;
            this.FridayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FridayCheckbox.Location = new System.Drawing.Point(335, 94);
            this.FridayCheckbox.Name = "FridayCheckbox";
            this.FridayCheckbox.Size = new System.Drawing.Size(58, 19);
            this.FridayCheckbox.TabIndex = 19;
            this.FridayCheckbox.Text = "Friday";
            this.FridayCheckbox.UseVisualStyleBackColor = true;
            // 
            // ThursdayCheckbox
            // 
            this.ThursdayCheckbox.AutoSize = true;
            this.ThursdayCheckbox.Checked = true;
            this.ThursdayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ThursdayCheckbox.Location = new System.Drawing.Point(255, 94);
            this.ThursdayCheckbox.Name = "ThursdayCheckbox";
            this.ThursdayCheckbox.Size = new System.Drawing.Size(74, 19);
            this.ThursdayCheckbox.TabIndex = 18;
            this.ThursdayCheckbox.Text = "Thursday";
            this.ThursdayCheckbox.UseVisualStyleBackColor = true;
            // 
            // WednesdayCheckbox
            // 
            this.WednesdayCheckbox.AutoSize = true;
            this.WednesdayCheckbox.Checked = true;
            this.WednesdayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WednesdayCheckbox.Location = new System.Drawing.Point(162, 94);
            this.WednesdayCheckbox.Name = "WednesdayCheckbox";
            this.WednesdayCheckbox.Size = new System.Drawing.Size(87, 19);
            this.WednesdayCheckbox.TabIndex = 17;
            this.WednesdayCheckbox.Text = "Wednesday";
            this.WednesdayCheckbox.UseVisualStyleBackColor = true;
            // 
            // TuesdayCheckbox
            // 
            this.TuesdayCheckbox.AutoSize = true;
            this.TuesdayCheckbox.Checked = true;
            this.TuesdayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TuesdayCheckbox.Location = new System.Drawing.Point(87, 94);
            this.TuesdayCheckbox.Name = "TuesdayCheckbox";
            this.TuesdayCheckbox.Size = new System.Drawing.Size(69, 19);
            this.TuesdayCheckbox.TabIndex = 16;
            this.TuesdayCheckbox.Text = "Tuesday";
            this.TuesdayCheckbox.UseVisualStyleBackColor = true;
            // 
            // MondayCheckbox
            // 
            this.MondayCheckbox.AutoSize = true;
            this.MondayCheckbox.Checked = true;
            this.MondayCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MondayCheckbox.Location = new System.Drawing.Point(11, 94);
            this.MondayCheckbox.Name = "MondayCheckbox";
            this.MondayCheckbox.Size = new System.Drawing.Size(70, 19);
            this.MondayCheckbox.TabIndex = 15;
            this.MondayCheckbox.Text = "Monday";
            this.MondayCheckbox.UseVisualStyleBackColor = true;
            // 
            // SleepAndWakeDisableButton
            // 
            this.SleepAndWakeDisableButton.Location = new System.Drawing.Point(6, 177);
            this.SleepAndWakeDisableButton.Name = "SleepAndWakeDisableButton";
            this.SleepAndWakeDisableButton.Size = new System.Drawing.Size(75, 23);
            this.SleepAndWakeDisableButton.TabIndex = 7;
            this.SleepAndWakeDisableButton.Text = "Disable";
            this.SleepAndWakeDisableButton.UseVisualStyleBackColor = true;
            this.SleepAndWakeDisableButton.Click += new System.EventHandler(this.SleepAndWakeDisableButton_Click);
            // 
            // SleepAndWakeEnableButton
            // 
            this.SleepAndWakeEnableButton.Location = new System.Drawing.Point(6, 148);
            this.SleepAndWakeEnableButton.Name = "SleepAndWakeEnableButton";
            this.SleepAndWakeEnableButton.Size = new System.Drawing.Size(75, 23);
            this.SleepAndWakeEnableButton.TabIndex = 6;
            this.SleepAndWakeEnableButton.Text = "Enable";
            this.SleepAndWakeEnableButton.UseVisualStyleBackColor = true;
            this.SleepAndWakeEnableButton.Click += new System.EventHandler(this.SleepAndWakeEnableButton_Click);
            // 
            // SaveSleepWakeTime
            // 
            this.SaveSleepWakeTime.Location = new System.Drawing.Point(6, 119);
            this.SaveSleepWakeTime.Name = "SaveSleepWakeTime";
            this.SaveSleepWakeTime.Size = new System.Drawing.Size(75, 23);
            this.SaveSleepWakeTime.TabIndex = 5;
            this.SaveSleepWakeTime.Text = "Save";
            this.SaveSleepWakeTime.UseVisualStyleBackColor = true;
            this.SaveSleepWakeTime.Click += new System.EventHandler(this.SaveSleepWakeTime_Click);
            // 
            // WakeTimePicker
            // 
            this.WakeTimePicker.Location = new System.Drawing.Point(6, 65);
            this.WakeTimePicker.Name = "WakeTimePicker";
            this.WakeTimePicker.Size = new System.Drawing.Size(200, 23);
            this.WakeTimePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "WakeTime";
            // 
            // SleepTimePicker
            // 
            this.SleepTimePicker.Location = new System.Drawing.Point(6, 21);
            this.SleepTimePicker.Name = "SleepTimePicker";
            this.SleepTimePicker.Size = new System.Drawing.Size(200, 23);
            this.SleepTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "SleepTime";
            // 
            // AutoLogonTab
            // 
            this.AutoLogonTab.Controls.Add(this.EnableAutoLogon);
            this.AutoLogonTab.Controls.Add(this.DisableAutoLogon);
            this.AutoLogonTab.Controls.Add(this.PasswordTextbox);
            this.AutoLogonTab.Controls.Add(this.label1);
            this.AutoLogonTab.Controls.Add(this.PasswordSaveButton);
            this.AutoLogonTab.Location = new System.Drawing.Point(4, 24);
            this.AutoLogonTab.Name = "AutoLogonTab";
            this.AutoLogonTab.Padding = new System.Windows.Forms.Padding(3);
            this.AutoLogonTab.Size = new System.Drawing.Size(768, 398);
            this.AutoLogonTab.TabIndex = 1;
            this.AutoLogonTab.Text = "Autologon";
            this.AutoLogonTab.UseVisualStyleBackColor = true;
            // 
            // EnableAutoLogon
            // 
            this.EnableAutoLogon.Location = new System.Drawing.Point(6, 79);
            this.EnableAutoLogon.Name = "EnableAutoLogon";
            this.EnableAutoLogon.Size = new System.Drawing.Size(75, 23);
            this.EnableAutoLogon.TabIndex = 4;
            this.EnableAutoLogon.Text = "Enable";
            this.EnableAutoLogon.UseVisualStyleBackColor = true;
            this.EnableAutoLogon.Click += new System.EventHandler(this.EnableAutoLogon_Click);
            // 
            // DisableAutoLogon
            // 
            this.DisableAutoLogon.Location = new System.Drawing.Point(6, 108);
            this.DisableAutoLogon.Name = "DisableAutoLogon";
            this.DisableAutoLogon.Size = new System.Drawing.Size(75, 23);
            this.DisableAutoLogon.TabIndex = 3;
            this.DisableAutoLogon.Text = "Disable";
            this.DisableAutoLogon.UseVisualStyleBackColor = true;
            this.DisableAutoLogon.Click += new System.EventHandler(this.DisableAutoLogon_Click);
            // 
            // TestTab
            // 
            this.TestTab.Controls.Add(this.TestProgressbar);
            this.TestTab.Controls.Add(this.TestRestartButton);
            this.TestTab.Controls.Add(this.TestSleepButton);
            this.TestTab.Controls.Add(this.TestWakeButton);
            this.TestTab.Location = new System.Drawing.Point(4, 24);
            this.TestTab.Name = "TestTab";
            this.TestTab.Size = new System.Drawing.Size(768, 398);
            this.TestTab.TabIndex = 0;
            this.TestTab.Text = "Test";
            this.TestTab.UseVisualStyleBackColor = true;
            // 
            // TestProgressbar
            // 
            this.TestProgressbar.Location = new System.Drawing.Point(3, 90);
            this.TestProgressbar.Maximum = 120;
            this.TestProgressbar.Name = "TestProgressbar";
            this.TestProgressbar.Size = new System.Drawing.Size(100, 23);
            this.TestProgressbar.Step = 1;
            this.TestProgressbar.TabIndex = 3;
            // 
            // TestRestartButton
            // 
            this.TestRestartButton.Location = new System.Drawing.Point(3, 61);
            this.TestRestartButton.Name = "TestRestartButton";
            this.TestRestartButton.Size = new System.Drawing.Size(75, 23);
            this.TestRestartButton.TabIndex = 2;
            this.TestRestartButton.Text = "TestRestart";
            this.TestRestartButton.UseVisualStyleBackColor = true;
            this.TestRestartButton.Click += new System.EventHandler(this.TestRestartButton_Click);
            // 
            // TestSleepButton
            // 
            this.TestSleepButton.Location = new System.Drawing.Point(3, 32);
            this.TestSleepButton.Name = "TestSleepButton";
            this.TestSleepButton.Size = new System.Drawing.Size(75, 23);
            this.TestSleepButton.TabIndex = 1;
            this.TestSleepButton.Text = "TestSleep";
            this.TestSleepButton.UseVisualStyleBackColor = true;
            this.TestSleepButton.Click += new System.EventHandler(this.TestSleepButton_Click);
            // 
            // TestWakeButton
            // 
            this.TestWakeButton.Location = new System.Drawing.Point(3, 3);
            this.TestWakeButton.Name = "TestWakeButton";
            this.TestWakeButton.Size = new System.Drawing.Size(75, 23);
            this.TestWakeButton.TabIndex = 0;
            this.TestWakeButton.Text = "TestWake";
            this.TestWakeButton.UseVisualStyleBackColor = true;
            this.TestWakeButton.Click += new System.EventHandler(this.TestWakeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 254);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "AutoHybernateAndWake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.SleepAndWakeTab.ResumeLayout(false);
            this.SleepAndWakeTab.PerformLayout();
            this.AutoLogonTab.ResumeLayout(false);
            this.AutoLogonTab.PerformLayout();
            this.TestTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox PasswordTextbox;
        private Label label1;
        private Button PasswordSaveButton;
        private TabControl tabControl1;
        private TabPage SleepAndWakeTab;
        private DateTimePicker SleepTimePicker;
        private Label label3;
        private TabPage AutoLogonTab;
        private DateTimePicker WakeTimePicker;
        private Label label2;
        private Button SaveSleepWakeTime;
        private Button EnableAutoLogon;
        private Button DisableAutoLogon;
        private Button SleepAndWakeDisableButton;
        private Button SleepAndWakeEnableButton;
        private CheckBox SundayCheckbox;
        private CheckBox SaturedayCheckbox;
        private CheckBox FridayCheckbox;
        private CheckBox ThursdayCheckbox;
        private CheckBox WednesdayCheckbox;
        private CheckBox TuesdayCheckbox;
        private CheckBox MondayCheckbox;
        private TabPage TestTab;
        private Button TestRestartButton;
        private Button TestSleepButton;
        private Button TestWakeButton;
        private ProgressBar TestProgressbar;
    }
}
namespace FirstWindowsFormsApp
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.loginButton = new System.Windows.Forms.Button();
            this.userName_label = new System.Windows.Forms.Label();
            this.userName_Input = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_Input = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.dateTime_Picker = new System.Windows.Forms.DateTimePicker();
            this.loginday_Combobox = new System.Windows.Forms.ComboBox();
            this.loginday_label = new System.Windows.Forms.Label();
            this.termsCheck = new System.Windows.Forms.CheckBox();
            this.phoneNumer_radio = new System.Windows.Forms.RadioButton();
            this.userName_radio = new System.Windows.Forms.RadioButton();
            this.loginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.BackColor = System.Drawing.Color.Blue;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Image = global::FirstWindowsFormsApp.Properties.Resources.log_in__1_;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(176, 382);
            this.loginButton.Name = "loginButton";
            this.loginButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.loginButton.Size = new System.Drawing.Size(524, 88);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "   Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.login_Button);
            // 
            // userName_label
            // 
            this.userName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.Location = new System.Drawing.Point(244, 163);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(252, 20);
            this.userName_label.TabIndex = 1;
            this.userName_label.Text = "Enter user name or Phone number";
            // 
            // userName_Input
            // 
            this.userName_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userName_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName_Input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_Input.Location = new System.Drawing.Point(249, 202);
            this.userName_Input.Name = "userName_Input";
            this.userName_Input.Size = new System.Drawing.Size(392, 41);
            this.userName_Input.TabIndex = 2;
            this.userName_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_number_Key_press);
            // 
            // password_label
            // 
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(244, 263);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(162, 31);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Enter password";
            // 
            // password_Input
            // 
            this.password_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_Input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Input.Location = new System.Drawing.Point(249, 297);
            this.password_Input.Name = "password_Input";
            this.password_Input.PasswordChar = '*';
            this.password_Input.Size = new System.Drawing.Size(392, 41);
            this.password_Input.TabIndex = 4;
            // 
            // loginBox
            // 
            this.loginBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBox.BackgroundImage")));
            this.loginBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBox.Controls.Add(this.dateTime_Picker);
            this.loginBox.Controls.Add(this.loginday_Combobox);
            this.loginBox.Controls.Add(this.loginday_label);
            this.loginBox.Controls.Add(this.termsCheck);
            this.loginBox.Controls.Add(this.phoneNumer_radio);
            this.loginBox.Controls.Add(this.userName_radio);
            this.loginBox.Controls.Add(this.userName_label);
            this.loginBox.Controls.Add(this.loginButton);
            this.loginBox.Controls.Add(this.password_label);
            this.loginBox.Controls.Add(this.password_Input);
            this.loginBox.Controls.Add(this.userName_Input);
            this.loginBox.Location = new System.Drawing.Point(44, 42);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(964, 492);
            this.loginBox.TabIndex = 5;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "login";
            // 
            // dateTime_Picker
            // 
            this.dateTime_Picker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTime_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_Picker.Location = new System.Drawing.Point(636, 45);
            this.dateTime_Picker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTime_Picker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTime_Picker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTime_Picker.Name = "dateTime_Picker";
            this.dateTime_Picker.Size = new System.Drawing.Size(298, 26);
            this.dateTime_Picker.TabIndex = 10;
            this.dateTime_Picker.CloseUp += new System.EventHandler(this.calculate_Dob);
            // 
            // loginday_Combobox
            // 
            this.loginday_Combobox.FormattingEnabled = true;
            this.loginday_Combobox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.loginday_Combobox.Location = new System.Drawing.Point(422, 45);
            this.loginday_Combobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginday_Combobox.Name = "loginday_Combobox";
            this.loginday_Combobox.Size = new System.Drawing.Size(180, 28);
            this.loginday_Combobox.TabIndex = 9;
            this.loginday_Combobox.Text = "Choose your day";
            this.loginday_Combobox.TextChanged += new System.EventHandler(this.day_choose);
            // 
            // loginday_label
            // 
            this.loginday_label.AutoSize = true;
            this.loginday_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginday_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loginday_label.Location = new System.Drawing.Point(249, 57);
            this.loginday_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginday_label.Name = "loginday_label";
            this.loginday_label.Size = new System.Drawing.Size(151, 20);
            this.loginday_label.TabIndex = 8;
            this.loginday_label.Text = "select your login day";
            // 
            // termsCheck
            // 
            this.termsCheck.AutoSize = true;
            this.termsCheck.Location = new System.Drawing.Point(249, 348);
            this.termsCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.termsCheck.Name = "termsCheck";
            this.termsCheck.Size = new System.Drawing.Size(243, 24);
            this.termsCheck.TabIndex = 7;
            this.termsCheck.Text = "I accept the terms & conditions";
            this.termsCheck.UseVisualStyleBackColor = true;
            // 
            // phoneNumer_radio
            // 
            this.phoneNumer_radio.AutoSize = true;
            this.phoneNumer_radio.BackColor = System.Drawing.Color.White;
            this.phoneNumer_radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.phoneNumer_radio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.phoneNumer_radio.FlatAppearance.BorderSize = 0;
            this.phoneNumer_radio.Location = new System.Drawing.Point(394, 117);
            this.phoneNumer_radio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneNumer_radio.Name = "phoneNumer_radio";
            this.phoneNumer_radio.Size = new System.Drawing.Size(138, 24);
            this.phoneNumer_radio.TabIndex = 6;
            this.phoneNumer_radio.Text = "Phone number";
            this.phoneNumer_radio.UseVisualStyleBackColor = false;
            this.phoneNumer_radio.Click += new System.EventHandler(this.phoneNumber_check);
            // 
            // userName_radio
            // 
            this.userName_radio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userName_radio.AutoSize = true;
            this.userName_radio.BackColor = System.Drawing.Color.White;
            this.userName_radio.Checked = true;
            this.userName_radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userName_radio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userName_radio.FlatAppearance.BorderSize = 0;
            this.userName_radio.Location = new System.Drawing.Point(254, 117);
            this.userName_radio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userName_radio.Name = "userName_radio";
            this.userName_radio.Size = new System.Drawing.Size(112, 24);
            this.userName_radio.TabIndex = 5;
            this.userName_radio.TabStop = true;
            this.userName_radio.Text = "User name";
            this.userName_radio.UseVisualStyleBackColor = false;
            this.userName_radio.Click += new System.EventHandler(this.username_check);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 555);
            this.Controls.Add(this.loginBox);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.TextBox userName_Input;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_Input;
        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.RadioButton userName_radio;
        private System.Windows.Forms.RadioButton phoneNumer_radio;
        private System.Windows.Forms.CheckBox termsCheck;
        private System.Windows.Forms.Label loginday_label;
        private System.Windows.Forms.ComboBox loginday_Combobox;
        private System.Windows.Forms.DateTimePicker dateTime_Picker;
    }
}


namespace FirstWindowsFormsApp
{
    partial class Home_Form
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.dayGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.single = new System.Windows.Forms.Button();
            this.twodimension = new System.Windows.Forms.Button();
            this.noDayGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dayGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDayGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Location = new System.Drawing.Point(123, 52);
            this.welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(125, 20);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome back ! ";
            this.welcome_label.Click += new System.EventHandler(this.welcome_label_Click);
            // 
            // dayGridView
            // 
            this.dayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dayGridView.Location = new System.Drawing.Point(127, 219);
            this.dayGridView.Name = "dayGridView";
            this.dayGridView.RowHeadersWidth = 62;
            this.dayGridView.RowTemplate.Height = 28;
            this.dayGridView.Size = new System.Drawing.Size(252, 303);
            this.dayGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "days";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // single
            // 
            this.single.Location = new System.Drawing.Point(127, 126);
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(112, 59);
            this.single.TabIndex = 2;
            this.single.Text = "single";
            this.single.UseVisualStyleBackColor = true;
            this.single.Click += new System.EventHandler(this.single_Click);
            // 
            // twodimension
            // 
            this.twodimension.Location = new System.Drawing.Point(626, 108);
            this.twodimension.Name = "twodimension";
            this.twodimension.Size = new System.Drawing.Size(112, 59);
            this.twodimension.TabIndex = 4;
            this.twodimension.Text = "2 dimension";
            this.twodimension.UseVisualStyleBackColor = true;
            this.twodimension.Click += new System.EventHandler(this.twodimension_Click);
            // 
            // noDayGridView
            // 
            this.noDayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noDayGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.noDayGridView.Location = new System.Drawing.Point(626, 199);
            this.noDayGridView.Name = "noDayGridView";
            this.noDayGridView.RowHeadersWidth = 62;
            this.noDayGridView.RowTemplate.Height = 28;
            this.noDayGridView.Size = new System.Drawing.Size(493, 378);
            this.noDayGridView.TabIndex = 3;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "no";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "day";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.Location = new System.Drawing.Point(776, 108);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(73, 20);
            this.count_lbl.TabIndex = 5;
            this.count_lbl.Text = "count_lbl";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(776, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "count_lbl";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count_lbl);
            this.Controls.Add(this.twodimension);
            this.Controls.Add(this.noDayGridView);
            this.Controls.Add(this.single);
            this.Controls.Add(this.dayGridView);
            this.Controls.Add(this.welcome_label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dayGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDayGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.DataGridView dayGridView;
        private System.Windows.Forms.Button single;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button twodimension;
        private System.Windows.Forms.DataGridView noDayGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label count_lbl;
        private System.Windows.Forms.Label label1;
    }
}
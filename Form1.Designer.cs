namespace DenLaba5
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            fromCSV = new Button();
            viewStat = new Button();
            fromJson = new Button();
            copyToJson = new Button();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(12, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(440, 425);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.FillWeight = 194.923859F;
            Column1.HeaderText = "ФИО участника";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column1.Width = 300;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 5.07614136F;
            Column2.HeaderText = "Баллы";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(130, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 195);
            panel1.TabIndex = 1;
            // 
            // fromCSV
            // 
            fromCSV.BackColor = Color.FromArgb(49, 49, 49);
            fromCSV.BackgroundImageLayout = ImageLayout.None;
            fromCSV.FlatAppearance.BorderSize = 0;
            fromCSV.FlatStyle = FlatStyle.Flat;
            fromCSV.Font = new Font("Eras Medium ITC", 40F, FontStyle.Regular, GraphicsUnit.Point);
            fromCSV.ForeColor = Color.FromArgb(162, 162, 162);
            fromCSV.Location = new Point(12, 644);
            fromCSV.Name = "fromCSV";
            fromCSV.Size = new Size(316, 82);
            fromCSV.TabIndex = 3;
            fromCSV.Text = "Use CSV";
            fromCSV.UseVisualStyleBackColor = false;
            fromCSV.Click += FromCSV_Obtane_Click;
            // 
            // viewStat
            // 
            viewStat.BackColor = Color.FromArgb(124, 124, 124);
            viewStat.Enabled = false;
            viewStat.FlatAppearance.BorderSize = 0;
            viewStat.FlatStyle = FlatStyle.Flat;
            viewStat.Font = new Font("Eras Medium ITC", 30F, FontStyle.Regular, GraphicsUnit.Point);
            viewStat.ForeColor = Color.FromArgb(252, 252, 252);
            viewStat.Location = new Point(236, 739);
            viewStat.Name = "viewStat";
            viewStat.Size = new Size(439, 57);
            viewStat.TabIndex = 4;
            viewStat.Text = "View statistics";
            viewStat.UseVisualStyleBackColor = false;
            viewStat.Click += ViewStat_Click;
            // 
            // fromJson
            // 
            fromJson.BackColor = Color.LightGray;
            fromJson.FlatAppearance.BorderSize = 0;
            fromJson.FlatStyle = FlatStyle.Flat;
            fromJson.Font = new Font("Eras Medium ITC", 40F, FontStyle.Regular, GraphicsUnit.Point);
            fromJson.ForeColor = Color.FromArgb(49, 49, 49);
            fromJson.Location = new Point(334, 644);
            fromJson.Name = "fromJson";
            fromJson.Size = new Size(252, 82);
            fromJson.TabIndex = 5;
            fromJson.Text = "Use Json";
            fromJson.UseVisualStyleBackColor = false;
            fromJson.Click += FromJson_Obtane_Click;
            // 
            // copyToJson
            // 
            copyToJson.BackColor = Color.FromArgb(86, 86, 86);
            copyToJson.FlatAppearance.BorderSize = 0;
            copyToJson.FlatStyle = FlatStyle.Flat;
            copyToJson.Font = new Font("Eras Medium ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            copyToJson.ForeColor = Color.FromArgb(252, 252, 252);
            copyToJson.Location = new Point(592, 644);
            copyToJson.Name = "copyToJson";
            copyToJson.Size = new Size(310, 82);
            copyToJson.TabIndex = 6;
            copyToJson.Text = "Copy to Json";
            copyToJson.UseVisualStyleBackColor = false;
            copyToJson.Click += CopyToJson_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.Location = new Point(458, 434);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(444, 204);
            dataGridView2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTextBoxColumn1.FillWeight = 194.923859F;
            dataGridViewTextBoxColumn1.HeaderText = "ФИО участника";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.FillWeight = 5.07614136F;
            dataGridViewTextBoxColumn2.HeaderText = "Баллы";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(49, 49, 49);
            label1.Location = new Point(601, 210);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 8;
            label1.Text = "S  t  a  t  i  s  t  i  c  s";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(49, 49, 49);
            label2.Location = new Point(458, 229);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(49, 49, 49);
            label3.Location = new Point(458, 250);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(49, 49, 49);
            label4.Location = new Point(458, 271);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(458, 306);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(458, 331);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(458, 356);
            label7.Name = "label7";
            label7.Size = new Size(149, 50);
            label7.TabIndex = 14;
            label7.Text = "\r\nwdadawdwadad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(49, 49, 49);
            label8.Location = new Point(487, 406);
            label8.Name = "label8";
            label8.Size = new Size(373, 25);
            label8.TabIndex = 15;
            label8.Text = "Участники прошедшие во второй этап";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 252);
            ClientSize = new Size(914, 810);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(copyToJson);
            Controls.Add(fromJson);
            Controls.Add(viewStat);
            Controls.Add(fromCSV);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button fromCSV;
        private Button viewStat;
        private Button fromJson;
        private Button copyToJson;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
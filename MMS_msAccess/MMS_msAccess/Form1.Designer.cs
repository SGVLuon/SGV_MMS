
namespace MMS_msAccess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Checkinout = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new MMS_msAccess.DataSet1();
            this.checkInOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkInOutTableAdapter = new MMS_msAccess.DataSet1TableAdapters.CheckInOutTableAdapter();
            this.Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.retry = new System.Windows.Forms.Button();
            this.Today = new System.Windows.Forms.Button();
            this.RawData = new System.Windows.Forms.CheckBox();
            this.Excel = new System.Windows.Forms.Button();
            this.To = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Checkinout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInOutBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Checkinout
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Checkinout.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Checkinout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Checkinout.DefaultCellStyle = dataGridViewCellStyle2;
            this.Checkinout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Checkinout.Location = new System.Drawing.Point(0, 73);
            this.Checkinout.Name = "Checkinout";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Checkinout.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Checkinout.Size = new System.Drawing.Size(1011, 619);
            this.Checkinout.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkInOutBindingSource
            // 
            this.checkInOutBindingSource.DataMember = "CheckInOut";
            this.checkInOutBindingSource.DataSource = this.dataSet1;
            // 
            // checkInOutTableAdapter
            // 
            this.checkInOutTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(680, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(125, 49);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.retry);
            this.panel1.Controls.Add(this.Today);
            this.panel1.Controls.Add(this.RawData);
            this.panel1.Controls.Add(this.Excel);
            this.panel1.Controls.Add(this.To);
            this.panel1.Controls.Add(this.From);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 73);
            this.panel1.TabIndex = 2;
            // 
            // retry
            // 
            this.retry.Location = new System.Drawing.Point(955, 12);
            this.retry.Name = "retry";
            this.retry.Size = new System.Drawing.Size(43, 43);
            this.retry.TabIndex = 3;
            this.retry.UseVisualStyleBackColor = true;
            this.retry.Visible = false;
            this.retry.Click += new System.EventHandler(this.retry_Click);
            // 
            // Today
            // 
            this.Today.Location = new System.Drawing.Point(571, 38);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(75, 23);
            this.Today.TabIndex = 8;
            this.Today.Text = "Today";
            this.Today.UseVisualStyleBackColor = true;
            this.Today.Visible = false;
            // 
            // RawData
            // 
            this.RawData.AutoSize = true;
            this.RawData.ForeColor = System.Drawing.Color.White;
            this.RawData.Location = new System.Drawing.Point(821, 36);
            this.RawData.Name = "RawData";
            this.RawData.Size = new System.Drawing.Size(71, 17);
            this.RawData.TabIndex = 7;
            this.RawData.Text = "RawData";
            this.RawData.UseVisualStyleBackColor = true;
            this.RawData.Visible = false;
            // 
            // Excel
            // 
            this.Excel.Image = global::MMS_msAccess.Properties.Resources.excel_67;
            this.Excel.Location = new System.Drawing.Point(898, 11);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(42, 42);
            this.Excel.TabIndex = 3;
            this.Excel.UseVisualStyleBackColor = true;
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.ForeColor = System.Drawing.Color.White;
            this.To.Location = new System.Drawing.Point(525, 15);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(21, 15);
            this.To.TabIndex = 6;
            this.To.Text = "To";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.ForeColor = System.Drawing.Color.White;
            this.From.Location = new System.Drawing.Point(347, 14);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(36, 15);
            this.From.TabIndex = 5;
            this.From.Text = "From";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Image = global::MMS_msAccess.Properties.Resources.s;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 73);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(551, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 692);
            this.Controls.Add(this.Checkinout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SGVQV-MMS V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.Checkinout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInOutBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Checkinout;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource checkInOutBindingSource;
        private DataSet1TableAdapters.CheckInOutTableAdapter checkInOutTableAdapter;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.CheckBox RawData;
        private System.Windows.Forms.Button Today;
        private System.Windows.Forms.Button retry;
    }
}


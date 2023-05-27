namespace WindowsFormsApp9
{
    partial class AVG5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVG5));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.отдел_кадровDataSet1 = new WindowsFormsApp9.Отдел_кадровDataSet1();
            this.зарплатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.зарплатыTableAdapter = new WindowsFormsApp9.Отдел_кадровDataSet1TableAdapters.ЗарплатыTableAdapter();
            this.кодЗарплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДоплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерЗарплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерПремииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКадраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зарплатыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗарплатыDataGridViewTextBoxColumn,
            this.кодДоплатыDataGridViewTextBoxColumn,
            this.размерЗарплатыDataGridViewTextBoxColumn,
            this.размерПремииDataGridViewTextBoxColumn,
            this.кодКадраDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.зарплатыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 232);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // отдел_кадровDataSet1
            // 
            this.отдел_кадровDataSet1.DataSetName = "Отдел_кадровDataSet1";
            this.отдел_кадровDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // зарплатыBindingSource
            // 
            this.зарплатыBindingSource.DataMember = "Зарплаты";
            this.зарплатыBindingSource.DataSource = this.отдел_кадровDataSet1;
            // 
            // зарплатыTableAdapter
            // 
            this.зарплатыTableAdapter.ClearBeforeFill = true;
            // 
            // кодЗарплатыDataGridViewTextBoxColumn
            // 
            this.кодЗарплатыDataGridViewTextBoxColumn.DataPropertyName = "Код_Зарплаты";
            this.кодЗарплатыDataGridViewTextBoxColumn.HeaderText = "Код_Зарплаты";
            this.кодЗарплатыDataGridViewTextBoxColumn.Name = "кодЗарплатыDataGridViewTextBoxColumn";
            // 
            // кодДоплатыDataGridViewTextBoxColumn
            // 
            this.кодДоплатыDataGridViewTextBoxColumn.DataPropertyName = "Код_Доплаты";
            this.кодДоплатыDataGridViewTextBoxColumn.HeaderText = "Код_Доплаты";
            this.кодДоплатыDataGridViewTextBoxColumn.Name = "кодДоплатыDataGridViewTextBoxColumn";
            // 
            // размерЗарплатыDataGridViewTextBoxColumn
            // 
            this.размерЗарплатыDataGridViewTextBoxColumn.DataPropertyName = "Размер_Зарплаты";
            this.размерЗарплатыDataGridViewTextBoxColumn.HeaderText = "Размер_Зарплаты";
            this.размерЗарплатыDataGridViewTextBoxColumn.Name = "размерЗарплатыDataGridViewTextBoxColumn";
            // 
            // размерПремииDataGridViewTextBoxColumn
            // 
            this.размерПремииDataGridViewTextBoxColumn.DataPropertyName = "Размер_Премии";
            this.размерПремииDataGridViewTextBoxColumn.HeaderText = "Размер_Премии";
            this.размерПремииDataGridViewTextBoxColumn.Name = "размерПремииDataGridViewTextBoxColumn";
            // 
            // кодКадраDataGridViewTextBoxColumn
            // 
            this.кодКадраDataGridViewTextBoxColumn.DataPropertyName = "Код_Кадра";
            this.кодКадраDataGridViewTextBoxColumn.HeaderText = "Код_Кадра";
            this.кодКадраDataGridViewTextBoxColumn.Name = "кодКадраDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выгрузка из таблицы \"Зарплаты\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AVG5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AVG5";
            this.Text = "Зарплаты";
            this.Load += new System.EventHandler(this.AVG5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зарплатыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Отдел_кадровDataSet1 отдел_кадровDataSet1;
        private System.Windows.Forms.BindingSource зарплатыBindingSource;
        private Отдел_кадровDataSet1TableAdapters.ЗарплатыTableAdapter зарплатыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗарплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДоплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерЗарплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерПремииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКадраDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
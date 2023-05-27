namespace WindowsFormsApp9
{
    partial class AVG4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVG4));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.отдел_кадровDataSet2 = new WindowsFormsApp9.Отдел_кадровDataSet2();
            this.претендентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.претендентыTableAdapter = new WindowsFormsApp9.Отдел_кадровDataSet2TableAdapters.ПретендентыTableAdapter();
            this.кодпретендентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.образованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодВакансииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.претендентыBindingSource)).BeginInit();
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
            this.кодпретендентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.образованиеDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn,
            this.кодВакансииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.претендентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 269);
            this.dataGridView1.TabIndex = 1;
            // 
            // отдел_кадровDataSet2
            // 
            this.отдел_кадровDataSet2.DataSetName = "Отдел_кадровDataSet2";
            this.отдел_кадровDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // претендентыBindingSource
            // 
            this.претендентыBindingSource.DataMember = "Претенденты";
            this.претендентыBindingSource.DataSource = this.отдел_кадровDataSet2;
            // 
            // претендентыTableAdapter
            // 
            this.претендентыTableAdapter.ClearBeforeFill = true;
            // 
            // кодпретендентаDataGridViewTextBoxColumn
            // 
            this.кодпретендентаDataGridViewTextBoxColumn.DataPropertyName = "Код_претендента";
            this.кодпретендентаDataGridViewTextBoxColumn.HeaderText = "Код_претендента";
            this.кодпретендентаDataGridViewTextBoxColumn.Name = "кодпретендентаDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // образованиеDataGridViewTextBoxColumn
            // 
            this.образованиеDataGridViewTextBoxColumn.DataPropertyName = "Образование";
            this.образованиеDataGridViewTextBoxColumn.HeaderText = "Образование";
            this.образованиеDataGridViewTextBoxColumn.Name = "образованиеDataGridViewTextBoxColumn";
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // номертелефонаDataGridViewTextBoxColumn
            // 
            this.номертелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.HeaderText = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.Name = "номертелефонаDataGridViewTextBoxColumn";
            // 
            // кодВакансииDataGridViewTextBoxColumn
            // 
            this.кодВакансииDataGridViewTextBoxColumn.DataPropertyName = "Код_Вакансии";
            this.кодВакансииDataGridViewTextBoxColumn.HeaderText = "Код_Вакансии";
            this.кодВакансииDataGridViewTextBoxColumn.Name = "кодВакансииDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(125, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выгрузка из таблицы \"Претенденты\"";
            this.label1.UseWaitCursor = true;
            // 
            // AVG4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AVG4";
            this.Text = "Претенденты";
            this.Load += new System.EventHandler(this.AVG4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.претендентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Отдел_кадровDataSet2 отдел_кадровDataSet2;
        private System.Windows.Forms.BindingSource претендентыBindingSource;
        private Отдел_кадровDataSet2TableAdapters.ПретендентыTableAdapter претендентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпретендентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn образованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВакансииDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
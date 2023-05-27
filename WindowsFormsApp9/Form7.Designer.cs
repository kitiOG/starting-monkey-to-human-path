namespace WindowsFormsApp9
{
    partial class AVG6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVG6));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодДоплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.классификациядоплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размердоплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.надбавкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКадраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доплатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отдел_кадровDataSet = new WindowsFormsApp9.Отдел_кадровDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.доплатыTableAdapter = new WindowsFormsApp9.Отдел_кадровDataSetTableAdapters.ДоплатыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доплатыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодДоплатыDataGridViewTextBoxColumn,
            this.классификациядоплатыDataGridViewTextBoxColumn,
            this.размердоплатыDataGridViewTextBoxColumn,
            this.надбавкиDataGridViewTextBoxColumn,
            this.кодКадраDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.доплатыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 248);
            this.dataGridView1.TabIndex = 1;
            // 
            // кодДоплатыDataGridViewTextBoxColumn
            // 
            this.кодДоплатыDataGridViewTextBoxColumn.DataPropertyName = "Код_Доплаты";
            this.кодДоплатыDataGridViewTextBoxColumn.HeaderText = "Код_Доплаты";
            this.кодДоплатыDataGridViewTextBoxColumn.Name = "кодДоплатыDataGridViewTextBoxColumn";
            // 
            // классификациядоплатыDataGridViewTextBoxColumn
            // 
            this.классификациядоплатыDataGridViewTextBoxColumn.DataPropertyName = "Классификация_доплаты";
            this.классификациядоплатыDataGridViewTextBoxColumn.HeaderText = "Классификация_доплаты";
            this.классификациядоплатыDataGridViewTextBoxColumn.Name = "классификациядоплатыDataGridViewTextBoxColumn";
            // 
            // размердоплатыDataGridViewTextBoxColumn
            // 
            this.размердоплатыDataGridViewTextBoxColumn.DataPropertyName = "Размер_доплаты";
            this.размердоплатыDataGridViewTextBoxColumn.HeaderText = "Размер_доплаты";
            this.размердоплатыDataGridViewTextBoxColumn.Name = "размердоплатыDataGridViewTextBoxColumn";
            // 
            // надбавкиDataGridViewTextBoxColumn
            // 
            this.надбавкиDataGridViewTextBoxColumn.DataPropertyName = "Надбавки";
            this.надбавкиDataGridViewTextBoxColumn.HeaderText = "Надбавки";
            this.надбавкиDataGridViewTextBoxColumn.Name = "надбавкиDataGridViewTextBoxColumn";
            // 
            // кодКадраDataGridViewTextBoxColumn
            // 
            this.кодКадраDataGridViewTextBoxColumn.DataPropertyName = "Код_Кадра";
            this.кодКадраDataGridViewTextBoxColumn.HeaderText = "Код_Кадра";
            this.кодКадраDataGridViewTextBoxColumn.Name = "кодКадраDataGridViewTextBoxColumn";
            // 
            // доплатыBindingSource
            // 
            this.доплатыBindingSource.DataMember = "Доплаты";
            this.доплатыBindingSource.DataSource = this.отдел_кадровDataSet;
            // 
            // отдел_кадровDataSet
            // 
            this.отдел_кадровDataSet.DataSetName = "Отдел_кадровDataSet";
            this.отдел_кадровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(122, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выгрузка из таблицы \"Доплаты\"";
            // 
            // доплатыTableAdapter
            // 
            this.доплатыTableAdapter.ClearBeforeFill = true;
            // 
            // AVG6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AVG6";
            this.Text = "Доплаты";
            this.Load += new System.EventHandler(this.AVG6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доплатыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Отдел_кадровDataSet отдел_кадровDataSet;
        private System.Windows.Forms.BindingSource доплатыBindingSource;
        private Отдел_кадровDataSetTableAdapters.ДоплатыTableAdapter доплатыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДоплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn классификациядоплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размердоплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn надбавкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКадраDataGridViewTextBoxColumn;
    }
}
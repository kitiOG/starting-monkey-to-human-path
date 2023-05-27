namespace WindowsFormsApp9
{
    partial class AVG2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVG2));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.отдел_кадровDataSet4 = new WindowsFormsApp9.Отдел_кадровDataSet4();
            this.вакансииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вакансииTableAdapter = new WindowsFormsApp9.Отдел_кадровDataSet4TableAdapters.ВакансииTableAdapter();
            this.кодВакансииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.требованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вакансииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
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
            this.кодВакансииDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.требованияDataGridViewTextBoxColumn,
            this.кодДолжностиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.вакансииBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 273);
            this.dataGridView1.TabIndex = 1;
            // 
            // отдел_кадровDataSet4
            // 
            this.отдел_кадровDataSet4.DataSetName = "Отдел_кадровDataSet4";
            this.отдел_кадровDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // вакансииBindingSource
            // 
            this.вакансииBindingSource.DataMember = "Вакансии";
            this.вакансииBindingSource.DataSource = this.отдел_кадровDataSet4;
            // 
            // вакансииTableAdapter
            // 
            this.вакансииTableAdapter.ClearBeforeFill = true;
            // 
            // кодВакансииDataGridViewTextBoxColumn
            // 
            this.кодВакансииDataGridViewTextBoxColumn.DataPropertyName = "Код_Вакансии";
            this.кодВакансииDataGridViewTextBoxColumn.HeaderText = "Код_Вакансии";
            this.кодВакансииDataGridViewTextBoxColumn.Name = "кодВакансииDataGridViewTextBoxColumn";
            this.кодВакансииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // требованияDataGridViewTextBoxColumn
            // 
            this.требованияDataGridViewTextBoxColumn.DataPropertyName = "Требования";
            this.требованияDataGridViewTextBoxColumn.HeaderText = "Требования";
            this.требованияDataGridViewTextBoxColumn.Name = "требованияDataGridViewTextBoxColumn";
            // 
            // кодДолжностиDataGridViewTextBoxColumn
            // 
            this.кодДолжностиDataGridViewTextBoxColumn.DataPropertyName = "Код_Должности";
            this.кодДолжностиDataGridViewTextBoxColumn.HeaderText = "Код_Должности";
            this.кодДолжностиDataGridViewTextBoxColumn.Name = "кодДолжностиDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(125, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выгрузка из таблицы \"Вакансии\"";
            // 
            // AVG2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(574, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AVG2";
            this.Text = "Вакансии";
            this.Load += new System.EventHandler(this.AVG2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вакансииBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Отдел_кадровDataSet4 отдел_кадровDataSet4;
        private System.Windows.Forms.BindingSource вакансииBindingSource;
        private Отдел_кадровDataSet4TableAdapters.ВакансииTableAdapter вакансииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВакансииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn требованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
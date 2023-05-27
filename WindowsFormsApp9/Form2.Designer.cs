namespace WindowsFormsApp9
{
    partial class AVG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVG));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.отдел_кадровDataSet5 = new WindowsFormsApp9.Отдел_кадровDataSet5();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиTableAdapter = new WindowsFormsApp9.Отдел_кадровDataSet5TableAdapters.ДолжностиTableAdapter();
            this.кодДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиксированныйокладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 12);
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
            this.кодДолжностиDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.фиксированныйокладDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.должностиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(117, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 264);
            this.dataGridView1.TabIndex = 1;
            // 
            // отдел_кадровDataSet5
            // 
            this.отдел_кадровDataSet5.DataSetName = "Отдел_кадровDataSet5";
            this.отдел_кадровDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.отдел_кадровDataSet5;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // кодДолжностиDataGridViewTextBoxColumn
            // 
            this.кодДолжностиDataGridViewTextBoxColumn.DataPropertyName = "Код_Должности";
            this.кодДолжностиDataGridViewTextBoxColumn.HeaderText = "Код_Должности";
            this.кодДолжностиDataGridViewTextBoxColumn.Name = "кодДолжностиDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // фиксированныйокладDataGridViewTextBoxColumn
            // 
            this.фиксированныйокладDataGridViewTextBoxColumn.DataPropertyName = "Фиксированный_оклад";
            this.фиксированныйокладDataGridViewTextBoxColumn.HeaderText = "Фиксированный_оклад";
            this.фиксированныйокладDataGridViewTextBoxColumn.Name = "фиксированныйокладDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(125, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выгрузка из таблицы \"Должности\"";
            // 
            // AVG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AVG";
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.AVG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Отдел_кадровDataSet5 отдел_кадровDataSet5;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private Отдел_кадровDataSet5TableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиксированныйокладDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
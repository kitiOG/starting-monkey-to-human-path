namespace WindowsFormsApp9
{
    partial class AVG3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVG3));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.отдел_кадровDataSet3 = new WindowsFormsApp9.Отдел_кадровDataSet3();
            this.кадрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кадрыTableAdapter = new WindowsFormsApp9.Отдел_кадровDataSet3TableAdapters.КадрыTableAdapter();
            this.кодкадраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортныеданныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.образованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапринятиянаработуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кадрыBindingSource)).BeginInit();
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
            this.кодкадраDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.паспортныеданныеDataGridViewTextBoxColumn,
            this.образованиеDataGridViewTextBoxColumn,
            this.датапринятиянаработуDataGridViewTextBoxColumn,
            this.кодДолжностиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.кадрыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 316);
            this.dataGridView1.TabIndex = 1;
            // 
            // отдел_кадровDataSet3
            // 
            this.отдел_кадровDataSet3.DataSetName = "Отдел_кадровDataSet3";
            this.отдел_кадровDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кадрыBindingSource
            // 
            this.кадрыBindingSource.DataMember = "Кадры";
            this.кадрыBindingSource.DataSource = this.отдел_кадровDataSet3;
            // 
            // кадрыTableAdapter
            // 
            this.кадрыTableAdapter.ClearBeforeFill = true;
            // 
            // кодкадраDataGridViewTextBoxColumn
            // 
            this.кодкадраDataGridViewTextBoxColumn.DataPropertyName = "Код_кадра";
            this.кодкадраDataGridViewTextBoxColumn.HeaderText = "Код_кадра";
            this.кодкадраDataGridViewTextBoxColumn.Name = "кодкадраDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_Рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата_Рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // паспортныеданныеDataGridViewTextBoxColumn
            // 
            this.паспортныеданныеDataGridViewTextBoxColumn.DataPropertyName = "Паспортные_данные";
            this.паспортныеданныеDataGridViewTextBoxColumn.HeaderText = "Паспортные_данные";
            this.паспортныеданныеDataGridViewTextBoxColumn.Name = "паспортныеданныеDataGridViewTextBoxColumn";
            // 
            // образованиеDataGridViewTextBoxColumn
            // 
            this.образованиеDataGridViewTextBoxColumn.DataPropertyName = "Образование";
            this.образованиеDataGridViewTextBoxColumn.HeaderText = "Образование";
            this.образованиеDataGridViewTextBoxColumn.Name = "образованиеDataGridViewTextBoxColumn";
            // 
            // датапринятиянаработуDataGridViewTextBoxColumn
            // 
            this.датапринятиянаработуDataGridViewTextBoxColumn.DataPropertyName = "Дата_принятия_на_работу";
            this.датапринятиянаработуDataGridViewTextBoxColumn.HeaderText = "Дата_принятия_на_работу";
            this.датапринятиянаработуDataGridViewTextBoxColumn.Name = "датапринятиянаработуDataGridViewTextBoxColumn";
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
            this.label1.Location = new System.Drawing.Point(138, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выгрузка из таблицы \"Кадры\"";
            // 
            // AVG3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AVG3";
            this.Text = "Кадры";
            this.Load += new System.EventHandler(this.AVG3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отдел_кадровDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кадрыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Отдел_кадровDataSet3 отдел_кадровDataSet3;
        private System.Windows.Forms.BindingSource кадрыBindingSource;
        private Отдел_кадровDataSet3TableAdapters.КадрыTableAdapter кадрыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодкадраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеданныеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn образованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапринятиянаработуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
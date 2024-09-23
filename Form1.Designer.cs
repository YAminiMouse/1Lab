namespace _1Lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.buttonSaveDoctor = new System.Windows.Forms.Button();
            this.buttonSaveSpecialization = new System.Windows.Forms.Button();
            this.dataGridViewSpecialization = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sertificate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialization)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSaveDoctor);
            this.tabPage1.Controls.Add(this.dataGridViewDoctor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Врач";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewSpecialization);
            this.tabPage2.Controls.Add(this.buttonSaveSpecialization);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Специальность";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(747, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчет1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(747, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Отчет2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Category,
            this.Sertificate,
            this.FIO,
            this.specialization_id});
            this.dataGridViewDoctor.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.Size = new System.Drawing.Size(747, 360);
            this.dataGridViewDoctor.TabIndex = 0;
            // 
            // buttonSaveDoctor
            // 
            this.buttonSaveDoctor.Location = new System.Drawing.Point(6, 6);
            this.buttonSaveDoctor.Name = "buttonSaveDoctor";
            this.buttonSaveDoctor.Size = new System.Drawing.Size(136, 32);
            this.buttonSaveDoctor.TabIndex = 1;
            this.buttonSaveDoctor.Text = "Сохранить изменения";
            this.buttonSaveDoctor.UseVisualStyleBackColor = true;
            this.buttonSaveDoctor.Click += new System.EventHandler(this.buttonSaveDoctor_Click);
            // 
            // buttonSaveSpecialization
            // 
            this.buttonSaveSpecialization.Location = new System.Drawing.Point(30, 7);
            this.buttonSaveSpecialization.Name = "buttonSaveSpecialization";
            this.buttonSaveSpecialization.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSpecialization.TabIndex = 0;
            this.buttonSaveSpecialization.Text = "Сохранить";
            this.buttonSaveSpecialization.UseVisualStyleBackColor = true;
            this.buttonSaveSpecialization.Click += new System.EventHandler(this.buttonSaveSpecialization_Click);
            // 
            // dataGridViewSpecialization
            // 
            this.dataGridViewSpecialization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSpecialization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecialization.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewSpecialization.Name = "dataGridViewSpecialization";
            this.dataGridViewSpecialization.Size = new System.Drawing.Size(747, 364);
            this.dataGridViewSpecialization.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Sertificate
            // 
            this.Sertificate.DataPropertyName = "Certificate";
            this.Sertificate.HeaderText = "Certificate";
            this.Sertificate.Name = "Sertificate";
            this.Sertificate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "Name";
            this.FIO.HeaderText = "FIO";
            this.FIO.Name = "FIO";
            // 
            // specialization_id
            // 
            this.specialization_id.DataPropertyName = "specialization_id";
            this.specialization_id.HeaderText = "SpecializationId";
            this.specialization_id.Name = "specialization_id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecialization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSaveDoctor;
        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.DataGridView dataGridViewSpecialization;
        private System.Windows.Forms.Button buttonSaveSpecialization;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sertificate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewComboBoxColumn specialization_id;
    }
}


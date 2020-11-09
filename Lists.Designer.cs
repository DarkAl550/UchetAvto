namespace UchetAvto
{
    partial class Lists
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uchetAvtoDataSet2 = new UchetAvto.UchetAvtoDataSet2();
            this.uchetAvtoDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetAvtoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetAvtoDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // uchetAvtoDataSet2
            // 
            this.uchetAvtoDataSet2.DataSetName = "UchetAvtoDataSet2";
            this.uchetAvtoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uchetAvtoDataSet2BindingSource
            // 
            this.uchetAvtoDataSet2BindingSource.DataSource = this.uchetAvtoDataSet2;
            this.uchetAvtoDataSet2BindingSource.Position = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(355, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Вернуться";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lists";
            this.Text = "Путевые листы";
            this.Load += new System.EventHandler(this.Lists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetAvtoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchetAvtoDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private UchetAvtoDataSet2 uchetAvtoDataSet2;
        private System.Windows.Forms.BindingSource uchetAvtoDataSet2BindingSource;
        private System.Windows.Forms.Button btnBack;
    }
}


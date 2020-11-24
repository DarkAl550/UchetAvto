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
            this.dataGridView1.Size = new System.Drawing.Size(902, 426);
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
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Путевые листы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lists_FormClosed);
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
    }
}


namespace SegmentList
{
    partial class SegmentForm
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
            this.SegmentDataGrid = new System.Windows.Forms.DataGridView();
            this.FullQuarter = new System.Windows.Forms.CheckBox();
            this.NumberQuarter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SegmentDataGrid
            // 
            this.SegmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SegmentDataGrid.Location = new System.Drawing.Point(12, 12);
            this.SegmentDataGrid.Name = "SegmentDataGrid";
            this.SegmentDataGrid.Size = new System.Drawing.Size(287, 426);
            this.SegmentDataGrid.TabIndex = 0;
            // 
            // FullQuarter
            // 
            this.FullQuarter.AutoSize = true;
            this.FullQuarter.Location = new System.Drawing.Point(427, 45);
            this.FullQuarter.Name = "FullQuarter";
            this.FullQuarter.Size = new System.Drawing.Size(83, 17);
            this.FullQuarter.TabIndex = 1;
            this.FullQuarter.Text = "Полностью";
            this.FullQuarter.UseVisualStyleBackColor = true;
            this.FullQuarter.CheckedChanged += new System.EventHandler(this.FullQuarter_CheckedChanged);
            // 
            // NumberQuarter
            // 
            this.NumberQuarter.FormattingEnabled = true;
            this.NumberQuarter.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "All"});
            this.NumberQuarter.Location = new System.Drawing.Point(337, 43);
            this.NumberQuarter.Name = "NumberQuarter";
            this.NumberQuarter.Size = new System.Drawing.Size(84, 21);
            this.NumberQuarter.TabIndex = 2;
            this.NumberQuarter.Text = "Четверть";
            this.NumberQuarter.SelectedIndexChanged += new System.EventHandler(this.NumberQuarter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Расположение отрезка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Генерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SegmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberQuarter);
            this.Controls.Add(this.FullQuarter);
            this.Controls.Add(this.SegmentDataGrid);
            this.Name = "SegmentForm";
            this.Text = "Список сегментов";
            ((System.ComponentModel.ISupportInitialize)(this.SegmentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SegmentDataGrid;
        private System.Windows.Forms.CheckBox FullQuarter;
        private System.Windows.Forms.ComboBox NumberQuarter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


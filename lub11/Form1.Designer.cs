namespace lub11
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
            this.tbcarinfo = new System.Windows.Forms.TextBox();
            this.addcar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbcarinfo
            // 
            this.tbcarinfo.Location = new System.Drawing.Point(12, 12);
            this.tbcarinfo.Multiline = true;
            this.tbcarinfo.Name = "tbcarinfo";
            this.tbcarinfo.ReadOnly = true;
            this.tbcarinfo.Size = new System.Drawing.Size(689, 439);
            this.tbcarinfo.TabIndex = 4;
            // 
            // addcar
            // 
            this.addcar.Location = new System.Drawing.Point(717, 12);
            this.addcar.Name = "addcar";
            this.addcar.Size = new System.Drawing.Size(105, 54);
            this.addcar.TabIndex = 5;
            this.addcar.Text = "Додати";
            this.addcar.UseVisualStyleBackColor = true;
            this.addcar.Click += new System.EventHandler(this.addcar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Скасувати";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 495);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addcar);
            this.Controls.Add(this.tbcarinfo);
            this.Name = "fmain";
            this.Text = "Лабораторна робота №11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbcarinfo;
        private System.Windows.Forms.Button addcar;
        private System.Windows.Forms.Button button2;
    }
}


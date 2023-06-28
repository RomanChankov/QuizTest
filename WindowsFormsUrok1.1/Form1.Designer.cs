namespace WindowsFormsUrok1._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstBtn = new System.Windows.Forms.Button();
            this.openWindowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstBtn
            // 
            this.firstBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.firstBtn.Location = new System.Drawing.Point(213, 79);
            this.firstBtn.Margin = new System.Windows.Forms.Padding(30);
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Padding = new System.Windows.Forms.Padding(10);
            this.firstBtn.Size = new System.Drawing.Size(484, 107);
            this.firstBtn.TabIndex = 0;
            this.firstBtn.Text = "Click me";
            this.firstBtn.UseVisualStyleBackColor = true;
            this.firstBtn.Click += new System.EventHandler(this.firstBtn_Click);
            // 
            // openWindowBtn
            // 
            this.openWindowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openWindowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openWindowBtn.Location = new System.Drawing.Point(697, 569);
            this.openWindowBtn.Name = "openWindowBtn";
            this.openWindowBtn.Size = new System.Drawing.Size(233, 91);
            this.openWindowBtn.TabIndex = 1;
            this.openWindowBtn.Text = "Open Window";
            this.openWindowBtn.UseVisualStyleBackColor = true;
            this.openWindowBtn.Click += new System.EventHandler(this.openWindowBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 736);
            this.Controls.Add(this.openWindowBtn);
            this.Controls.Add(this.firstBtn);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstBtn;
        private System.Windows.Forms.Button openWindowBtn;
    }
}


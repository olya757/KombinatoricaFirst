namespace _11с
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
            this.tbInputLength = new System.Windows.Forms.TextBox();
            this.lbInputLengths = new System.Windows.Forms.Label();
            this.tBInputM = new System.Windows.Forms.TextBox();
            this.tBInputP = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbInputM = new System.Windows.Forms.Label();
            this.lbInputP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInputLength
            // 
            this.tbInputLength.Location = new System.Drawing.Point(12, 51);
            this.tbInputLength.Name = "tbInputLength";
            this.tbInputLength.Size = new System.Drawing.Size(297, 20);
            this.tbInputLength.TabIndex = 0;
            // 
            // lbInputLengths
            // 
            this.lbInputLengths.AutoSize = true;
            this.lbInputLengths.Location = new System.Drawing.Point(13, 32);
            this.lbInputLengths.Name = "lbInputLengths";
            this.lbInputLengths.Size = new System.Drawing.Size(205, 13);
            this.lbInputLengths.TabIndex = 1;
            this.lbInputLengths.Text = "Введите длины отрезков через пробел";
            // 
            // tBInputM
            // 
            this.tBInputM.Location = new System.Drawing.Point(12, 103);
            this.tBInputM.Name = "tBInputM";
            this.tBInputM.Size = new System.Drawing.Size(100, 20);
            this.tBInputM.TabIndex = 2;
            // 
            // tBInputP
            // 
            this.tBInputP.Location = new System.Drawing.Point(12, 153);
            this.tBInputP.Name = "tBInputP";
            this.tBInputP.Size = new System.Drawing.Size(100, 20);
            this.tBInputP.TabIndex = 3;
            this.tBInputP.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(12, 212);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbInputM
            // 
            this.lbInputM.AutoSize = true;
            this.lbInputM.Location = new System.Drawing.Point(12, 84);
            this.lbInputM.Name = "lbInputM";
            this.lbInputM.Size = new System.Drawing.Size(234, 13);
            this.lbInputM.TabIndex = 5;
            this.lbInputM.Text = "Введите количество сторон многоугольника";
            // 
            // lbInputP
            // 
            this.lbInputP.AutoSize = true;
            this.lbInputP.Location = new System.Drawing.Point(12, 134);
            this.lbInputP.Name = "lbInputP";
            this.lbInputP.Size = new System.Drawing.Size(316, 13);
            this.lbInputP.TabIndex = 6;
            this.lbInputP.Text = "Введите максимальное количество используемых отрезков";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 247);
            this.Controls.Add(this.lbInputP);
            this.Controls.Add(this.lbInputM);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tBInputP);
            this.Controls.Add(this.tBInputM);
            this.Controls.Add(this.lbInputLengths);
            this.Controls.Add(this.tbInputLength);
            this.Name = "Form1";
            this.Text = "11с Проверить существование многоугольника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputLength;
        private System.Windows.Forms.Label lbInputLengths;
        private System.Windows.Forms.TextBox tBInputM;
        private System.Windows.Forms.TextBox tBInputP;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbInputM;
        private System.Windows.Forms.Label lbInputP;
    }
}


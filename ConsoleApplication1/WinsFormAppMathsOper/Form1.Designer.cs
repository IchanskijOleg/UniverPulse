namespace WinsFormAppMathsOper
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
            this.tBoxA = new System.Windows.Forms.TextBox();
            this.tBoxB = new System.Windows.Forms.TextBox();
            this.tBoxResult = new System.Windows.Forms.TextBox();
            this.rButtPlus = new System.Windows.Forms.RadioButton();
            this.rButtMinus = new System.Windows.Forms.RadioButton();
            this.rButtMult = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rButtDiv = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tBoxA
            // 
            this.tBoxA.Location = new System.Drawing.Point(27, 41);
            this.tBoxA.Name = "tBoxA";
            this.tBoxA.Size = new System.Drawing.Size(100, 20);
            this.tBoxA.TabIndex = 0;
            // 
            // tBoxB
            // 
            this.tBoxB.Location = new System.Drawing.Point(172, 41);
            this.tBoxB.Name = "tBoxB";
            this.tBoxB.Size = new System.Drawing.Size(100, 20);
            this.tBoxB.TabIndex = 1;
            // 
            // tBoxResult
            // 
            this.tBoxResult.Location = new System.Drawing.Point(97, 67);
            this.tBoxResult.Name = "tBoxResult";
            this.tBoxResult.Size = new System.Drawing.Size(100, 20);
            this.tBoxResult.TabIndex = 2;
            // 
            // rButtPlus
            // 
            this.rButtPlus.AutoSize = true;
            this.rButtPlus.Location = new System.Drawing.Point(27, 97);
            this.rButtPlus.Name = "rButtPlus";
            this.rButtPlus.Size = new System.Drawing.Size(31, 17);
            this.rButtPlus.TabIndex = 3;
            this.rButtPlus.TabStop = true;
            this.rButtPlus.Text = "+";
            this.rButtPlus.UseVisualStyleBackColor = true;
            // 
            // rButtMinus
            // 
            this.rButtMinus.AutoSize = true;
            this.rButtMinus.Location = new System.Drawing.Point(27, 121);
            this.rButtMinus.Name = "rButtMinus";
            this.rButtMinus.Size = new System.Drawing.Size(28, 17);
            this.rButtMinus.TabIndex = 4;
            this.rButtMinus.TabStop = true;
            this.rButtMinus.Text = "-";
            this.rButtMinus.UseVisualStyleBackColor = true;
            // 
            // rButtMult
            // 
            this.rButtMult.AutoSize = true;
            this.rButtMult.Location = new System.Drawing.Point(27, 145);
            this.rButtMult.Name = "rButtMult";
            this.rButtMult.Size = new System.Drawing.Size(29, 17);
            this.rButtMult.TabIndex = 5;
            this.rButtMult.TabStop = true;
            this.rButtMult.Text = "*";
            this.rButtMult.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rButtDiv
            // 
            this.rButtDiv.AutoSize = true;
            this.rButtDiv.Location = new System.Drawing.Point(27, 168);
            this.rButtDiv.Name = "rButtDiv";
            this.rButtDiv.Size = new System.Drawing.Size(30, 17);
            this.rButtDiv.TabIndex = 7;
            this.rButtDiv.TabStop = true;
            this.rButtDiv.Text = "/";
            this.rButtDiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 200);
            this.Controls.Add(this.rButtDiv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rButtMult);
            this.Controls.Add(this.rButtMinus);
            this.Controls.Add(this.rButtPlus);
            this.Controls.Add(this.tBoxResult);
            this.Controls.Add(this.tBoxB);
            this.Controls.Add(this.tBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxA;
        private System.Windows.Forms.TextBox tBoxB;
        private System.Windows.Forms.TextBox tBoxResult;
        private System.Windows.Forms.RadioButton rButtPlus;
        private System.Windows.Forms.RadioButton rButtMinus;
        private System.Windows.Forms.RadioButton rButtMult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rButtDiv;
    }
}


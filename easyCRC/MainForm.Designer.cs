namespace EasyCRC
{
    partial class MainForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.tbSecondPolynom = new System.Windows.Forms.TextBox();
            this.tbFirstPolynom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSecondPolynom = new System.Windows.Forms.Label();
            this.lbFirstPolynom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbResultPolynom = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(236, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "easyCRC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Коэффициенты второго полинома";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Коэффициенты первого полинома";
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(51, 141);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(178, 23);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "Рассчитать";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // tbSecondPolynom
            // 
            this.tbSecondPolynom.Location = new System.Drawing.Point(51, 115);
            this.tbSecondPolynom.Name = "tbSecondPolynom";
            this.tbSecondPolynom.Size = new System.Drawing.Size(178, 20);
            this.tbSecondPolynom.TabIndex = 15;
            this.tbSecondPolynom.Text = "100011011";
            this.tbSecondPolynom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstPolynom_KeyPress);
            // 
            // tbFirstPolynom
            // 
            this.tbFirstPolynom.Location = new System.Drawing.Point(51, 72);
            this.tbFirstPolynom.Name = "tbFirstPolynom";
            this.tbFirstPolynom.Size = new System.Drawing.Size(178, 20);
            this.tbFirstPolynom.TabIndex = 14;
            this.tbFirstPolynom.Text = "1000010000100";
            this.tbFirstPolynom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstPolynom_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Результат";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(51, 296);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(178, 20);
            this.tbResult.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Второй полином";
            // 
            // lbSecondPolynom
            // 
            this.lbSecondPolynom.AutoSize = true;
            this.lbSecondPolynom.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.lbSecondPolynom.Location = new System.Drawing.Point(46, 246);
            this.lbSecondPolynom.Name = "lbSecondPolynom";
            this.lbSecondPolynom.Size = new System.Drawing.Size(0, 25);
            this.lbSecondPolynom.TabIndex = 23;
            this.lbSecondPolynom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFirstPolynom
            // 
            this.lbFirstPolynom.AutoSize = true;
            this.lbFirstPolynom.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.lbFirstPolynom.Location = new System.Drawing.Point(46, 194);
            this.lbFirstPolynom.Name = "lbFirstPolynom";
            this.lbFirstPolynom.Size = new System.Drawing.Size(0, 25);
            this.lbFirstPolynom.TabIndex = 25;
            this.lbFirstPolynom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Первый полином";
            // 
            // lbResultPolynom
            // 
            this.lbResultPolynom.AutoSize = true;
            this.lbResultPolynom.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.lbResultPolynom.Location = new System.Drawing.Point(46, 339);
            this.lbResultPolynom.Name = "lbResultPolynom";
            this.lbResultPolynom.Size = new System.Drawing.Size(0, 25);
            this.lbResultPolynom.TabIndex = 27;
            this.lbResultPolynom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Полученный полином";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 392);
            this.Controls.Add(this.lbResultPolynom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbFirstPolynom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbSecondPolynom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.tbSecondPolynom);
            this.Controls.Add(this.tbFirstPolynom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контрольная сумма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox tbSecondPolynom;
        private System.Windows.Forms.TextBox tbFirstPolynom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSecondPolynom;
        private System.Windows.Forms.Label lbFirstPolynom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbResultPolynom;
        private System.Windows.Forms.Label label9;
    }
}


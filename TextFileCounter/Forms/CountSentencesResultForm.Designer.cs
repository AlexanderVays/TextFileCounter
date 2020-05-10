namespace TextFileCounter.Forms
{
    partial class CountSentencesResultForm
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
            this.buttonOkResult = new System.Windows.Forms.Button();
            this.result3 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Label();
            this.mainText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOkResult
            // 
            this.buttonOkResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOkResult.Location = new System.Drawing.Point(676, 612);
            this.buttonOkResult.Name = "buttonOkResult";
            this.buttonOkResult.Size = new System.Drawing.Size(77, 53);
            this.buttonOkResult.TabIndex = 27;
            this.buttonOkResult.Text = "OK";
            this.buttonOkResult.UseVisualStyleBackColor = true;
            this.buttonOkResult.Click += new System.EventHandler(this.buttonOkResult_Click_1);
            // 
            // result3
            // 
            this.result3.AutoSize = true;
            this.result3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result3.Location = new System.Drawing.Point(659, 459);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(94, 29);
            this.result3.TabIndex = 23;
            this.result3.Text = "Result3";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result2.Location = new System.Drawing.Point(659, 288);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(94, 29);
            this.result2.TabIndex = 22;
            this.result2.Text = "Result2";
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1.Location = new System.Drawing.Point(659, 107);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(94, 29);
            this.result1.TabIndex = 21;
            this.result1.Text = "Result1";
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainText.Location = new System.Drawing.Point(78, 44);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(589, 29);
            this.mainText.TabIndex = 15;
            this.mainText.Text = "Please find a result for counting quotes and sentences";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(83, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 124);
            this.textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(83, 285);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(524, 124);
            this.textBox2.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(83, 459);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(524, 132);
            this.textBox3.TabIndex = 30;
            // 
            // CountSentencesResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 690);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOkResult);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.mainText);
            this.Name = "CountSentencesResultForm";
            this.Text = "Count quotes and sentences result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOkResult;
        private System.Windows.Forms.Label result3;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.Label result1;
        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}
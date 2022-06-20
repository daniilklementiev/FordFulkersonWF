namespace FordFulkersonWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMaxGraphFlow = new System.Windows.Forms.Button();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelJson = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Алгоритм Форда-Фалкерсона";
            // 
            // buttonMaxGraphFlow
            // 
            this.buttonMaxGraphFlow.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMaxGraphFlow.Location = new System.Drawing.Point(393, 209);
            this.buttonMaxGraphFlow.Name = "buttonMaxGraphFlow";
            this.buttonMaxGraphFlow.Size = new System.Drawing.Size(240, 46);
            this.buttonMaxGraphFlow.TabIndex = 1;
            this.buttonMaxGraphFlow.Text = "Рассчитать";
            this.buttonMaxGraphFlow.UseVisualStyleBackColor = true;
            this.buttonMaxGraphFlow.Click += new System.EventHandler(this.buttonMaxGraphFlow_Click);
            // 
            // textBoxSource
            // 
            this.textBoxSource.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSource.Location = new System.Drawing.Point(342, 147);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(83, 46);
            this.textBoxSource.TabIndex = 2;
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTarget.Location = new System.Drawing.Point(598, 147);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(83, 46);
            this.textBoxTarget.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 881);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статус json:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(328, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Исток";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(598, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сток";
            // 
            // labelJson
            // 
            this.labelJson.AutoSize = true;
            this.labelJson.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJson.Location = new System.Drawing.Point(243, 881);
            this.labelJson.Name = "labelJson";
            this.labelJson.Size = new System.Drawing.Size(197, 38);
            this.labelJson.TabIndex = 7;
            this.labelJson.Text = "Not correct";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(12, 280);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1061, 505);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 928);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelJson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.buttonMaxGraphFlow);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonMaxGraphFlow;
        private TextBox textBoxSource;
        private TextBox textBoxTarget;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelJson;
        private RichTextBox richTextBox1;
    }
}
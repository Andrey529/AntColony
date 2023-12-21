namespace AntColony
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCountCities = new System.Windows.Forms.TextBox();
            this.textBoxcountAnts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.Alpha = new System.Windows.Forms.Label();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.textBoxRho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCurrentBestLen = new System.Windows.Forms.Label();
            this.richTextBoxResAlg = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGraph = new System.Windows.Forms.Label();
            this.textBoxIterationsCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество городов";
            // 
            // textBoxNumCities
            // 
            this.textBoxCountCities.Location = new System.Drawing.Point(236, 36);
            this.textBoxCountCities.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCountCities.Name = "textBoxNumCities";
            this.textBoxCountCities.Size = new System.Drawing.Size(132, 22);
            this.textBoxCountCities.TabIndex = 1;
            this.textBoxCountCities.Text = "5";
            // 
            // textBoxNumAnts
            // 
            this.textBoxcountAnts.Location = new System.Drawing.Point(236, 68);
            this.textBoxcountAnts.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxcountAnts.Name = "textBoxNumAnts";
            this.textBoxcountAnts.Size = new System.Drawing.Size(132, 22);
            this.textBoxcountAnts.TabIndex = 3;
            this.textBoxcountAnts.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество муравьев";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(236, 106);
            this.textBoxAlpha.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(132, 22);
            this.textBoxAlpha.TabIndex = 5;
            this.textBoxAlpha.Text = "3";
            // 
            // Alpha
            // 
            this.Alpha.AutoSize = true;
            this.Alpha.Location = new System.Drawing.Point(32, 106);
            this.Alpha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Alpha.Name = "Alpha";
            this.Alpha.Size = new System.Drawing.Size(42, 16);
            this.Alpha.TabIndex = 4;
            this.Alpha.Text = "Alpha";
            // 
            // textBoxBeta
            // 
            this.textBoxBeta.Location = new System.Drawing.Point(236, 138);
            this.textBoxBeta.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(132, 22);
            this.textBoxBeta.TabIndex = 7;
            this.textBoxBeta.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Beta";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(236, 172);
            this.textBoxQ.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(132, 22);
            this.textBoxQ.TabIndex = 9;
            this.textBoxQ.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Q";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(120, 324);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(154, 59);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Старт алгоритма";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(467, 228);
            this.Answer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 16);
            this.Answer.TabIndex = 11;
            // 
            // textBoxRho
            // 
            this.textBoxRho.Location = new System.Drawing.Point(236, 209);
            this.textBoxRho.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRho.Name = "textBoxRho";
            this.textBoxRho.Size = new System.Drawing.Size(132, 22);
            this.textBoxRho.TabIndex = 13;
            this.textBoxRho.Text = "0,01";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Коэф. испарения феромона";
            // 
            // labelCurrentBestLen
            // 
            this.labelCurrentBestLen.AutoSize = true;
            this.labelCurrentBestLen.Location = new System.Drawing.Point(457, 39);
            this.labelCurrentBestLen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentBestLen.Name = "labelCurrentBestLen";
            this.labelCurrentBestLen.Size = new System.Drawing.Size(0, 16);
            this.labelCurrentBestLen.TabIndex = 14;
            // 
            // richTextBoxResAlg
            // 
            this.richTextBoxResAlg.Location = new System.Drawing.Point(428, 324);
            this.richTextBoxResAlg.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxResAlg.Name = "richTextBoxResAlg";
            this.richTextBoxResAlg.Size = new System.Drawing.Size(441, 225);
            this.richTextBoxResAlg.TabIndex = 15;
            this.richTextBoxResAlg.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Матрциа смежности графа:";
            // 
            // labelGraph
            // 
            this.labelGraph.AutoSize = true;
            this.labelGraph.Location = new System.Drawing.Point(500, 70);
            this.labelGraph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGraph.Name = "labelGraph";
            this.labelGraph.Size = new System.Drawing.Size(0, 16);
            this.labelGraph.TabIndex = 17;
            // 
            // textBoxNumIter
            // 
            this.textBoxIterationsCount.Location = new System.Drawing.Point(236, 248);
            this.textBoxIterationsCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIterationsCount.Name = "textBoxNumIter";
            this.textBoxIterationsCount.Size = new System.Drawing.Size(132, 22);
            this.textBoxIterationsCount.TabIndex = 21;
            this.textBoxIterationsCount.Text = "500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Количество итераций";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 633);
            this.Controls.Add(this.textBoxIterationsCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelGraph);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxResAlg);
            this.Controls.Add(this.labelCurrentBestLen);
            this.Controls.Add(this.textBoxRho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAlpha);
            this.Controls.Add(this.Alpha);
            this.Controls.Add(this.textBoxcountAnts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCountCities);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCountCities;
        private System.Windows.Forms.TextBox textBoxcountAnts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Label Alpha;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox textBoxRho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCurrentBestLen;
        private System.Windows.Forms.RichTextBox richTextBoxResAlg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGraph;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIterationsCount;
        private System.Windows.Forms.Label label8;
    }
}


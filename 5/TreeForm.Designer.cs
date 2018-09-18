namespace _5
{
    partial class TreeForm
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.Gen = new System.Windows.Forms.Button();
            this.InputN = new System.Windows.Forms.NumericUpDown();
            this.output = new System.Windows.Forms.PictureBox();
            this.show = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.negativeBtn = new System.Windows.Forms.RadioButton();
            this.positiveBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N = ";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"txt|*.txt|all files|*.*\"";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(345, 16);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 5;
            this.save.Text = "save Ways";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Gen
            // 
            this.Gen.Location = new System.Drawing.Point(117, 16);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(75, 23);
            this.Gen.TabIndex = 6;
            this.Gen.Text = "Generate";
            this.Gen.UseVisualStyleBackColor = true;
            this.Gen.Click += new System.EventHandler(this.Gen_Click);
            // 
            // InputN
            // 
            this.InputN.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.InputN.Location = new System.Drawing.Point(39, 18);
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(71, 20);
            this.InputN.TabIndex = 7;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 44);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(795, 432);
            this.output.TabIndex = 8;
            this.output.TabStop = false;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(426, 16);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 9;
            this.show.Text = "show Ways";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.Show_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.negativeBtn);
            this.groupBox1.Controls.Add(this.positiveBtn);
            this.groupBox1.Location = new System.Drawing.Point(198, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 27);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // negativeBtn
            // 
            this.negativeBtn.AutoSize = true;
            this.negativeBtn.Location = new System.Drawing.Point(75, 8);
            this.negativeBtn.Name = "negativeBtn";
            this.negativeBtn.Size = new System.Drawing.Size(66, 17);
            this.negativeBtn.TabIndex = 1;
            this.negativeBtn.TabStop = true;
            this.negativeBtn.Text = "negative";
            this.negativeBtn.UseVisualStyleBackColor = true;
            // 
            // positiveBtn
            // 
            this.positiveBtn.AutoSize = true;
            this.positiveBtn.Checked = true;
            this.positiveBtn.Location = new System.Drawing.Point(7, 8);
            this.positiveBtn.Name = "positiveBtn";
            this.positiveBtn.Size = new System.Drawing.Size(61, 17);
            this.positiveBtn.TabIndex = 0;
            this.positiveBtn.TabStop = true;
            this.positiveBtn.Text = "positive";
            this.positiveBtn.UseVisualStyleBackColor = true;
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.output);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TreeForm";
            this.Text = "Tree";
            this.Load += new System.EventHandler(this.TreeForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TreeForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.InputN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button Gen;
        private System.Windows.Forms.NumericUpDown InputN;
        private System.Windows.Forms.PictureBox output;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton negativeBtn;
        private System.Windows.Forms.RadioButton positiveBtn;
    }
}


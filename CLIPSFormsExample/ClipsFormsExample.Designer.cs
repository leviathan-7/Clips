namespace ClipsFormsExample
{
    partial class ClipsFormsExample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipsFormsExample));
            this.clipsOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openButtonRules = new System.Windows.Forms.Button();
            this.resButton = new System.Windows.Forms.Button();
            this.openButtonFacts = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // clipsOpenFileDialog
            // 
            this.clipsOpenFileDialog.Filter = "CLIPS files|*.clp|All files|*.*";
            this.clipsOpenFileDialog.Title = "Открыть файл кода CLIPS";
            // 
            // openButtonRules
            // 
            this.openButtonRules.Location = new System.Drawing.Point(171, 417);
            this.openButtonRules.Name = "openButtonRules";
            this.openButtonRules.Size = new System.Drawing.Size(120, 46);
            this.openButtonRules.TabIndex = 18;
            this.openButtonRules.Text = "Добавить рецепты";
            this.openButtonRules.UseVisualStyleBackColor = true;
            this.openButtonRules.Click += new System.EventHandler(this.openButtonRules_Click);
            // 
            // resButton
            // 
            this.resButton.Location = new System.Drawing.Point(553, 417);
            this.resButton.Name = "resButton";
            this.resButton.Size = new System.Drawing.Size(233, 46);
            this.resButton.TabIndex = 26;
            this.resButton.Text = "Вычислить";
            this.resButton.UseVisualStyleBackColor = true;
            this.resButton.Click += new System.EventHandler(this.resButton_Click);
            // 
            // openButtonFacts
            // 
            this.openButtonFacts.Location = new System.Drawing.Point(30, 417);
            this.openButtonFacts.Name = "openButtonFacts";
            this.openButtonFacts.Size = new System.Drawing.Size(120, 46);
            this.openButtonFacts.TabIndex = 15;
            this.openButtonFacts.Text = "Добавить продукты";
            this.openButtonFacts.UseVisualStyleBackColor = true;
            this.openButtonFacts.Click += new System.EventHandler(this.openButtonFacts_Click);
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(527, 31);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(259, 337);
            this.outputBox.TabIndex = 14;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(264, 108);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(233, 46);
            this.AddButton.TabIndex = 27;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(264, 176);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(233, 46);
            this.ClearButton.TabIndex = 26;
            this.ClearButton.Text = "Очистить список";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(264, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Выберете продукт, который хотите получить:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(209, 260);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Выберете продукты которые у вас есть:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // ClipsFormsExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.openButtonRules);
            this.Controls.Add(this.resButton);
            this.Controls.Add(this.openButtonFacts);
            this.Controls.Add(this.outputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(660, 300);
            this.Name = "ClipsFormsExample";
            this.Text = "Экспертная система \"Продукты\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    private System.Windows.Forms.OpenFileDialog clipsOpenFileDialog;
        private System.Windows.Forms.Button openButtonRules;
        private System.Windows.Forms.Button resButton;
        private System.Windows.Forms.Button openButtonFacts;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


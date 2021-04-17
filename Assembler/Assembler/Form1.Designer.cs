namespace Assembler
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.asmText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.executeText = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File name";
            // 
            // btnParse
            // 
            this.btnParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnParse.Location = new System.Drawing.Point(12, 89);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(195, 55);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse asm file";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpen.Location = new System.Drawing.Point(359, 45);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(46, 22);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // asmText
            // 
            this.asmText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.asmText.Location = new System.Drawing.Point(10, 45);
            this.asmText.Name = "asmText";
            this.asmText.Size = new System.Drawing.Size(343, 22);
            this.asmText.TabIndex = 4;
            this.asmText.Text = "Select the asm file";
            this.asmText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputText.Location = new System.Drawing.Point(12, 164);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(393, 414);
            this.outputText.TabIndex = 32;
            // 
            // executeText
            // 
            this.executeText.Location = new System.Drawing.Point(426, 12);
            this.executeText.Multiline = true;
            this.executeText.Name = "executeText";
            this.executeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.executeText.Size = new System.Drawing.Size(490, 566);
            this.executeText.TabIndex = 33;
            this.executeText.TextChanged += new System.EventHandler(this.executeText_TextChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExecute.Location = new System.Drawing.Point(213, 89);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(192, 55);
            this.btnExecute.TabIndex = 34;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 590);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.executeText);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.asmText);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox asmText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.TextBox executeText;
        private System.Windows.Forms.Button btnExecute;
    }
}


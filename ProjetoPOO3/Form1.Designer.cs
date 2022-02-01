namespace ProjetoPOO3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBN1 = new System.Windows.Forms.TextBox();
            this.textBN2 = new System.Windows.Forms.TextBox();
            this.textBN3 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "1ª  Nota:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "2ª Nota:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "3ª Nota:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBN1
            // 
            this.textBN1.Location = new System.Drawing.Point(152, 69);
            this.textBN1.Name = "textBN1";
            this.textBN1.Size = new System.Drawing.Size(100, 30);
            this.textBN1.TabIndex = 0;
            this.textBN1.TextChanged += new System.EventHandler(this.textBN1_TextChanged);
            this.textBN1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBN1_KeyPress);
            // 
            // textBN2
            // 
            this.textBN2.Location = new System.Drawing.Point(152, 123);
            this.textBN2.Name = "textBN2";
            this.textBN2.Size = new System.Drawing.Size(100, 30);
            this.textBN2.TabIndex = 1;
            this.textBN2.TextChanged += new System.EventHandler(this.textBN2_TextChanged);
            this.textBN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBN2_KeyPress);
            // 
            // textBN3
            // 
            this.textBN3.Location = new System.Drawing.Point(152, 172);
            this.textBN3.Name = "textBN3";
            this.textBN3.Size = new System.Drawing.Size(100, 30);
            this.textBN3.TabIndex = 2;
            this.textBN3.TextChanged += new System.EventHandler(this.textBN3_TextChanged);
            this.textBN3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBN3_KeyPress);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCalc.Location = new System.Drawing.Point(35, 248);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(89, 31);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Red;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClean.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(190, 248);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(89, 31);
            this.btnClean.TabIndex = 999;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(111, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resultado:";
            // 
            // textBResult
            // 
            this.textBResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBResult.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBResult.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBResult.Location = new System.Drawing.Point(24, 387);
            this.textBResult.Multiline = true;
            this.textBResult.Name = "textBResult";
            this.textBResult.ReadOnly = true;
            this.textBResult.Size = new System.Drawing.Size(273, 144);
            this.textBResult.TabIndex = 6;
            this.textBResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(35, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cálculadora de Média Aritmética";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(4, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 2);
            this.label6.TabIndex = 8;
            // 
            // lblMedia
            // 
            this.lblMedia.Location = new System.Drawing.Point(114, 343);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(87, 35);
            this.lblMedia.TabIndex = 1000;
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(320, 544);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.textBN3);
            this.Controls.Add(this.textBN2);
            this.Controls.Add(this.textBN1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculadora de Média Aritmética";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBN1;
        private System.Windows.Forms.TextBox textBN2;
        private System.Windows.Forms.TextBox textBN3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMedia;
    }
}

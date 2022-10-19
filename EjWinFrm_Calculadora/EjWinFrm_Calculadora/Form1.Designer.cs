namespace EjWinFrm_Calculadora
{
    partial class FrmCalc
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.nudOp1 = new System.Windows.Forms.NumericUpDown();
            this.nudOp2 = new System.Windows.Forms.NumericUpDown();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudOp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOp2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(44, 218);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(457, 27);
            this.txtResultado.TabIndex = 0;
            // 
            // nudOp1
            // 
            this.nudOp1.Location = new System.Drawing.Point(44, 79);
            this.nudOp1.Name = "nudOp1";
            this.nudOp1.Size = new System.Drawing.Size(212, 27);
            this.nudOp1.TabIndex = 1;
            // 
            // nudOp2
            // 
            this.nudOp2.Location = new System.Drawing.Point(282, 79);
            this.nudOp2.Name = "nudOp2";
            this.nudOp2.Size = new System.Drawing.Size(219, 27);
            this.nudOp2.TabIndex = 2;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(44, 147);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(94, 29);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(162, 147);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(94, 29);
            this.btnResta.TabIndex = 4;
            this.btnResta.TabStop = false;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(282, 147);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(94, 29);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(407, 147);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(94, 29);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(44, 33);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(88, 20);
            this.lbl_1.TabIndex = 7;
            this.lbl_1.Text = "Operando 1";
            this.lbl_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(282, 33);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(88, 20);
            this.lbl_2.TabIndex = 8;
            this.lbl_2.Text = "Operando 2";
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 283);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.nudOp2);
            this.Controls.Add(this.nudOp1);
            this.Controls.Add(this.txtResultado);
            this.Name = "FrmCalc";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.nudOp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResultado;
        private NumericUpDown nudOp1;
        private NumericUpDown nudOp2;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMult;
        private Button btnDiv;
        private Label lbl_1;
        private Label lbl_2;
    }
}

namespace MustandBroncoGUI
{
    partial class mustangBronco
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
            this.lblMustBronc = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInstruct1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDescOutput = new System.Windows.Forms.Label();
            this.lblInstruct2 = new System.Windows.Forms.Label();
            this.lblInstruct3 = new System.Windows.Forms.Label();
            this.lblInstruct4 = new System.Windows.Forms.Label();
            this.lblInstruct5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMustBronc
            // 
            this.lblMustBronc.AutoSize = true;
            this.lblMustBronc.Location = new System.Drawing.Point(64, 112);
            this.lblMustBronc.Name = "lblMustBronc";
            this.lblMustBronc.Size = new System.Drawing.Size(12, 15);
            this.lblMustBronc.TabIndex = 0;
            this.lblMustBronc.Text = "-";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(10, 141);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(156, 23);
            this.txtInput.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(91, 170);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInstruct1
            // 
            this.lblInstruct1.AutoSize = true;
            this.lblInstruct1.Location = new System.Drawing.Point(12, 18);
            this.lblInstruct1.Name = "lblInstruct1";
            this.lblInstruct1.Size = new System.Drawing.Size(580, 15);
            this.lblInstruct1.TabIndex = 3;
            this.lblInstruct1.Text = "Enter your favorite integer. Program will decide if you should get a Mustang, Bro" +
    "nco, both, or maybe neither.";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDescOutput
            // 
            this.lblDescOutput.AutoSize = true;
            this.lblDescOutput.Location = new System.Drawing.Point(10, 112);
            this.lblDescOutput.Name = "lblDescOutput";
            this.lblDescOutput.Size = new System.Drawing.Size(48, 15);
            this.lblDescOutput.TabIndex = 5;
            this.lblDescOutput.Text = "Output:";
            // 
            // lblInstruct2
            // 
            this.lblInstruct2.AutoSize = true;
            this.lblInstruct2.Location = new System.Drawing.Point(27, 42);
            this.lblInstruct2.Name = "lblInstruct2";
            this.lblInstruct2.Size = new System.Drawing.Size(178, 15);
            this.lblInstruct2.TabIndex = 6;
            this.lblInstruct2.Text = "*Mustang - Integer divisible by 3";
            // 
            // lblInstruct3
            // 
            this.lblInstruct3.AutoSize = true;
            this.lblInstruct3.Location = new System.Drawing.Point(27, 57);
            this.lblInstruct3.Name = "lblInstruct3";
            this.lblInstruct3.Size = new System.Drawing.Size(169, 15);
            this.lblInstruct3.TabIndex = 7;
            this.lblInstruct3.Text = "*Bronco - Integer divisible by 5";
            // 
            // lblInstruct4
            // 
            this.lblInstruct4.AutoSize = true;
            this.lblInstruct4.Location = new System.Drawing.Point(27, 72);
            this.lblInstruct4.Name = "lblInstruct4";
            this.lblInstruct4.Size = new System.Drawing.Size(188, 15);
            this.lblInstruct4.TabIndex = 8;
            this.lblInstruct4.Text = "*Both - Integer divisible by 3 and 5";
            // 
            // lblInstruct5
            // 
            this.lblInstruct5.AutoSize = true;
            this.lblInstruct5.Location = new System.Drawing.Point(27, 87);
            this.lblInstruct5.Name = "lblInstruct5";
            this.lblInstruct5.Size = new System.Drawing.Size(323, 15);
            this.lblInstruct5.TabIndex = 9;
            this.lblInstruct5.Text = "*Neither - Integer not divisible by 3 or 5 (input echoed back)";
            // 
            // mustangBronco
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 208);
            this.Controls.Add(this.lblInstruct5);
            this.Controls.Add(this.lblInstruct4);
            this.Controls.Add(this.lblInstruct3);
            this.Controls.Add(this.lblInstruct2);
            this.Controls.Add(this.lblDescOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInstruct1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblMustBronc);
            this.Name = "mustangBronco";
            this.Text = "Mustang or Bronco?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMustBronc;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInstruct1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDescOutput;
        private System.Windows.Forms.Label lblInstruct2;
        private System.Windows.Forms.Label lblInstruct3;
        private System.Windows.Forms.Label lblInstruct4;
        private System.Windows.Forms.Label lblInstruct5;
    }
}


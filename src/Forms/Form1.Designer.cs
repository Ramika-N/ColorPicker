namespace ScreenColorPicker.Forms
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
            this.btnPick = new System.Windows.Forms.Button();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.picMagnifier = new System.Windows.Forms.PictureBox();
            this.lblHex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMagnifier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPick
            // 
            this.btnPick.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPick.Location = new System.Drawing.Point(12, 12);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(120, 35);
            this.btnPick.TabIndex = 0;
            this.btnPick.Text = "Pick Color";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // picMagnifier
            // 
            this.picMagnifier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMagnifier.Location = new System.Drawing.Point(12, 58);
            this.picMagnifier.Name = "picMagnifier";
            this.picMagnifier.Size = new System.Drawing.Size(120, 120);
            this.picMagnifier.TabIndex = 1;
            this.picMagnifier.TabStop = false;
            // 
            // pnlPreview
            // 
            this.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPreview.Location = new System.Drawing.Point(145, 12);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(125, 80);
            this.pnlPreview.TabIndex = 2;
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHex.Location = new System.Drawing.Point(145, 101);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(65, 15);
            this.lblHex.TabIndex = 3;
            this.lblHex.Text = "HEX Code:";
            // 
            // txtHex
            // 
            this.txtHex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHex.Location = new System.Drawing.Point(145, 119);
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(125, 25);
            this.txtHex.TabIndex = 4;
            this.txtHex.Text = "#FFFFFF";
            this.txtHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(145, 150);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(125, 28);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy HEX";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 191);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.picMagnifier);
            this.Controls.Add(this.btnPick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picMagnifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.PictureBox picMagnifier;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Button btnCopy;
    }
}
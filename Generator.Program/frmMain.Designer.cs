namespace Generator.Program
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblGenerator = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGenerator
            // 
            this.lblGenerator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGenerator.AutoSize = true;
            this.lblGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerator.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGenerator.Location = new System.Drawing.Point(12, 9);
            this.lblGenerator.Name = "lblGenerator";
            this.lblGenerator.Size = new System.Drawing.Size(334, 29);
            this.lblGenerator.TabIndex = 2;
            this.lblGenerator.Text = "Random Number Generator";
            this.lblGenerator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblToken
            // 
            this.lblToken.Location = new System.Drawing.Point(17, 59);
            this.lblToken.Multiline = true;
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(328, 107);
            this.lblToken.TabIndex = 3;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(97, 259);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(156, 86);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "button1";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(357, 357);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.lblGenerator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenerator;
        private System.Windows.Forms.TextBox lblToken;
        private System.Windows.Forms.Button btnCriar;
    }
}


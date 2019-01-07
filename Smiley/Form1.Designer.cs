namespace Smiley
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
            this.flLPanel_emojis = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flLPanel_emojis
            // 
            this.flLPanel_emojis.AutoScroll = true;
            this.flLPanel_emojis.Location = new System.Drawing.Point(12, 93);
            this.flLPanel_emojis.Name = "flLPanel_emojis";
            this.flLPanel_emojis.Size = new System.Drawing.Size(316, 264);
            this.flLPanel_emojis.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 369);
            this.Controls.Add(this.flLPanel_emojis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flLPanel_emojis;
    }
}


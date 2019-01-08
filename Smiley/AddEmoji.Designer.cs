namespace Smiley
{
    partial class AddEmoji
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
            this.cbox_Categories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Art = new System.Windows.Forms.TextBox();
            this.btn_AddEmoji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbox_Categories
            // 
            this.cbox_Categories.FormattingEnabled = true;
            this.cbox_Categories.Location = new System.Drawing.Point(117, 26);
            this.cbox_Categories.Name = "cbox_Categories";
            this.cbox_Categories.Size = new System.Drawing.Size(121, 21);
            this.cbox_Categories.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(117, 74);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Art:";
            // 
            // tb_Art
            // 
            this.tb_Art.Location = new System.Drawing.Point(117, 121);
            this.tb_Art.Multiline = true;
            this.tb_Art.Name = "tb_Art";
            this.tb_Art.Size = new System.Drawing.Size(100, 60);
            this.tb_Art.TabIndex = 5;
            // 
            // btn_AddEmoji
            // 
            this.btn_AddEmoji.Location = new System.Drawing.Point(177, 206);
            this.btn_AddEmoji.Name = "btn_AddEmoji";
            this.btn_AddEmoji.Size = new System.Drawing.Size(61, 36);
            this.btn_AddEmoji.TabIndex = 6;
            this.btn_AddEmoji.Text = "Add";
            this.btn_AddEmoji.UseVisualStyleBackColor = true;
            this.btn_AddEmoji.Click += new System.EventHandler(this.btn_AddEmoji_Click);
            // 
            // AddEmoji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 260);
            this.Controls.Add(this.btn_AddEmoji);
            this.Controls.Add(this.tb_Art);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_Categories);
            this.Name = "AddEmoji";
            this.Text = "AddEmoji";
            this.Load += new System.EventHandler(this.AddEmoji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_Categories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Art;
        private System.Windows.Forms.Button btn_AddEmoji;
    }
}
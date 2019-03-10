namespace VirusWinForm
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
            this.BuyKey = new System.Windows.Forms.Button();
            this.InputKey = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have been hacked !";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BuyKey
            // 
            this.BuyKey.BackColor = System.Drawing.Color.Red;
            this.BuyKey.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyKey.ForeColor = System.Drawing.Color.White;
            this.BuyKey.Location = new System.Drawing.Point(28, 109);
            this.BuyKey.Name = "BuyKey";
            this.BuyKey.Size = new System.Drawing.Size(101, 65);
            this.BuyKey.TabIndex = 3;
            this.BuyKey.Text = "Buy Key";
            this.BuyKey.UseVisualStyleBackColor = false;
            this.BuyKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputKey
            // 
            this.InputKey.BackColor = System.Drawing.Color.LimeGreen;
            this.InputKey.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputKey.ForeColor = System.Drawing.Color.White;
            this.InputKey.Location = new System.Drawing.Point(216, 109);
            this.InputKey.Name = "InputKey";
            this.InputKey.Size = new System.Drawing.Size(101, 65);
            this.InputKey.TabIndex = 4;
            this.InputKey.Text = "Input Key";
            this.InputKey.UseVisualStyleBackColor = false;
            this.InputKey.Click += new System.EventHandler(this.InputKey_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VirusWinForm.Properties.Resources.exclamation_mark;
            this.pictureBox1.Location = new System.Drawing.Point(151, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(356, 197);
            this.Controls.Add(this.InputKey);
            this.Controls.Add(this.BuyKey);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oops!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BuyKey;
        private System.Windows.Forms.Button InputKey;
    }
}


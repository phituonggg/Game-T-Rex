namespace Midterm_Project___TRex
{
    partial class StartScreencs
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Midterm_Project___TRex.Properties.Resources.startscreen;
            this.pictureBox1.Location = new System.Drawing.Point(-52, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 513);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(485, 169);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(164, 61);
            this.Play.TabIndex = 1;
            this.Play.Text = "Start";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.GameStart);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.Location = new System.Drawing.Point(485, 261);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(164, 64);
            this.Help.TabIndex = 2;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.ShowHelp);
            // 
            // StartScreencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartScreencs";
            this.Text = "StartScreencs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Help;
    }
}
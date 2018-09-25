namespace Changing_pictures
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
            this.AndyRobbo = new System.Windows.Forms.PictureBox();
            this.Milner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AndyRobbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Milner)).BeginInit();
            this.SuspendLayout();
            // 
            // AndyRobbo
            // 
            this.AndyRobbo.Image = global::Changing_pictures.Properties.Resources.andyrobbo;
            this.AndyRobbo.Location = new System.Drawing.Point(322, 125);
            this.AndyRobbo.Name = "AndyRobbo";
            this.AndyRobbo.Size = new System.Drawing.Size(100, 50);
            this.AndyRobbo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AndyRobbo.TabIndex = 1;
            this.AndyRobbo.TabStop = false;
            // 
            // Milner
            // 
            this.Milner.Image = global::Changing_pictures.Properties.Resources.jmilner;
            this.Milner.Location = new System.Drawing.Point(138, 125);
            this.Milner.Name = "Milner";
            this.Milner.Size = new System.Drawing.Size(100, 50);
            this.Milner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Milner.TabIndex = 0;
            this.Milner.TabStop = false;
            this.Milner.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AndyRobbo);
            this.Controls.Add(this.Milner);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AndyRobbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Milner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Milner;
        private System.Windows.Forms.PictureBox AndyRobbo;
    }
}


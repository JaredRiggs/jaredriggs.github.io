namespace Headsortails
{
    partial class HeadsorTails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadsorTails));
            this.showHeadsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.showTailsButton = new System.Windows.Forms.Button();
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showHeadsButton
            // 
            this.showHeadsButton.Location = new System.Drawing.Point(13, 226);
            this.showHeadsButton.Name = "showHeadsButton";
            this.showHeadsButton.Size = new System.Drawing.Size(80, 23);
            this.showHeadsButton.TabIndex = 0;
            this.showHeadsButton.Text = "Show Heads";
            this.showHeadsButton.UseVisualStyleBackColor = true;
            this.showHeadsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(99, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showTailsButton
            // 
            this.showTailsButton.Location = new System.Drawing.Point(180, 226);
            this.showTailsButton.Name = "showTailsButton";
            this.showTailsButton.Size = new System.Drawing.Size(75, 23);
            this.showTailsButton.TabIndex = 2;
            this.showTailsButton.Text = "Show Tails";
            this.showTailsButton.UseVisualStyleBackColor = true;
            this.showTailsButton.Click += new System.EventHandler(this.showTailsButton_Click);
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headsPictureBox.Image")));
            this.headsPictureBox.Location = new System.Drawing.Point(13, 71);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(106, 105);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headsPictureBox.TabIndex = 3;
            this.headsPictureBox.TabStop = false;
            this.headsPictureBox.Visible = false;
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = global::Headsortails.Properties.Resources.Tails;
            this.tailsPictureBox.Location = new System.Drawing.Point(151, 71);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(104, 105);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tailsPictureBox.TabIndex = 4;
            this.tailsPictureBox.TabStop = false;
            this.tailsPictureBox.Visible = false;
            // 
            // HeadsorTails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tailsPictureBox);
            this.Controls.Add(this.headsPictureBox);
            this.Controls.Add(this.showTailsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showHeadsButton);
            this.Name = "HeadsorTails";
            this.Text = "Heads/Tails";
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showHeadsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button showTailsButton;
        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
    }
}


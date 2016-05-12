namespace CameraWrapper
{
    partial class Form2
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
            this.height = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.depth = new System.Windows.Forms.TextBox();
            this.pixelsize = new System.Windows.Forms.TextBox();
            this.height_label = new System.Windows.Forms.Label();
            this.width_label = new System.Windows.Forms.Label();
            this.depth_label = new System.Windows.Forms.Label();
            this.pixelsize_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(121, 79);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(89, 20);
            this.height.TabIndex = 1;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(121, 118);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(89, 20);
            this.width.TabIndex = 2;
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(121, 162);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(89, 20);
            this.depth.TabIndex = 3;
            // 
            // pixelsize
            // 
            this.pixelsize.Location = new System.Drawing.Point(121, 210);
            this.pixelsize.Name = "pixelsize";
            this.pixelsize.Size = new System.Drawing.Size(89, 20);
            this.pixelsize.TabIndex = 4;
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Location = new System.Drawing.Point(33, 82);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(70, 13);
            this.height_label.TabIndex = 7;
            this.height_label.Text = "Image Height";
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Location = new System.Drawing.Point(36, 121);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(67, 13);
            this.width_label.TabIndex = 8;
            this.width_label.Text = "Image Width";
            // 
            // depth_label
            // 
            this.depth_label.AutoSize = true;
            this.depth_label.Location = new System.Drawing.Point(10, 165);
            this.depth_label.Name = "depth_label";
            this.depth_label.Size = new System.Drawing.Size(93, 13);
            this.depth_label.TabIndex = 9;
            this.depth_label.Text = "Number of Frames";
            // 
            // pixelsize_label
            // 
            this.pixelsize_label.AutoSize = true;
            this.pixelsize_label.Location = new System.Drawing.Point(46, 213);
            this.pixelsize_label.Name = "pixelsize_label";
            this.pixelsize_label.Size = new System.Drawing.Size(52, 13);
            this.pixelsize_label.TabIndex = 10;
            this.pixelsize_label.Text = "Pixel Size";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(295, 269);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(79, 30);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 387);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.pixelsize_label);
            this.Controls.Add(this.depth_label);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.pixelsize);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.height);
            this.Name = "Form2";
            this.Text = "CameraID";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.TextBox pixelsize;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.Label depth_label;
        private System.Windows.Forms.Label pixelsize_label;
        private System.Windows.Forms.Button add_button;
    }
}
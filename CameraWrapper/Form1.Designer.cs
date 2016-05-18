namespace CameraWrapper
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cameraID = new System.Windows.Forms.TextBox();
            this.cameraID_label = new System.Windows.Forms.Label();
            this.newCameraID = new System.Windows.Forms.Button();
            this.CameraHeightText = new System.Windows.Forms.Label();
            this.CameraWidthText = new System.Windows.Forms.Label();
            this.CameraDepthText = new System.Windows.Forms.Label();
            this.CameraPixelText = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.Depth = new System.Windows.Forms.TextBox();
            this.PixelSize = new System.Windows.Forms.TextBox();
            this.settingsGrid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(117, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Acquire";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cameraID
            // 
            this.cameraID.Location = new System.Drawing.Point(409, 42);
            this.cameraID.Name = "cameraID";
            this.cameraID.Size = new System.Drawing.Size(73, 20);
            this.cameraID.TabIndex = 2;
            this.cameraID.TextChanged += new System.EventHandler(this.cameraID_TextChanged);
            // 
            // cameraID_label
            // 
            this.cameraID_label.AutoSize = true;
            this.cameraID_label.Location = new System.Drawing.Point(346, 45);
            this.cameraID_label.Name = "cameraID_label";
            this.cameraID_label.Size = new System.Drawing.Size(57, 13);
            this.cameraID_label.TabIndex = 3;
            this.cameraID_label.Text = "Camera ID";
            // 
            // newCameraID
            // 
            this.newCameraID.Location = new System.Drawing.Point(356, 257);
            this.newCameraID.Name = "newCameraID";
            this.newCameraID.Size = new System.Drawing.Size(126, 25);
            this.newCameraID.TabIndex = 4;
            this.newCameraID.Text = "Insert New CameraID";
            this.newCameraID.UseVisualStyleBackColor = true;
            this.newCameraID.Click += new System.EventHandler(this.newCameraID_Click);
            // 
            // CameraHeightText
            // 
            this.CameraHeightText.AutoSize = true;
            this.CameraHeightText.Location = new System.Drawing.Point(311, 89);
            this.CameraHeightText.Name = "CameraHeightText";
            this.CameraHeightText.Size = new System.Drawing.Size(38, 13);
            this.CameraHeightText.TabIndex = 5;
            this.CameraHeightText.Text = "Height";
            // 
            // CameraWidthText
            // 
            this.CameraWidthText.AutoSize = true;
            this.CameraWidthText.Location = new System.Drawing.Point(311, 128);
            this.CameraWidthText.Name = "CameraWidthText";
            this.CameraWidthText.Size = new System.Drawing.Size(35, 13);
            this.CameraWidthText.TabIndex = 6;
            this.CameraWidthText.Text = "Width";
            // 
            // CameraDepthText
            // 
            this.CameraDepthText.AutoSize = true;
            this.CameraDepthText.Location = new System.Drawing.Point(311, 166);
            this.CameraDepthText.Name = "CameraDepthText";
            this.CameraDepthText.Size = new System.Drawing.Size(89, 13);
            this.CameraDepthText.TabIndex = 7;
            this.CameraDepthText.Text = "Depth (# Frames)";
            // 
            // CameraPixelText
            // 
            this.CameraPixelText.AutoSize = true;
            this.CameraPixelText.Location = new System.Drawing.Point(311, 205);
            this.CameraPixelText.Name = "CameraPixelText";
            this.CameraPixelText.Size = new System.Drawing.Size(52, 13);
            this.CameraPixelText.TabIndex = 8;
            this.CameraPixelText.Text = "Pixel Size";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(444, 86);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(73, 20);
            this.Height.TabIndex = 9;
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(444, 125);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(73, 20);
            this.Width.TabIndex = 10;
            // 
            // Depth
            // 
            this.Depth.Location = new System.Drawing.Point(444, 163);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(73, 20);
            this.Depth.TabIndex = 11;
            // 
            // PixelSize
            // 
            this.PixelSize.Location = new System.Drawing.Point(444, 202);
            this.PixelSize.Name = "PixelSize";
            this.PixelSize.Size = new System.Drawing.Size(73, 20);
            this.PixelSize.TabIndex = 12;
            // 
            // settingsGrid
            // 
            this.settingsGrid.Location = new System.Drawing.Point(34, 25);
            this.settingsGrid.Name = "settingsGrid";
            this.settingsGrid.Size = new System.Drawing.Size(239, 209);
            this.settingsGrid.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 307);
            this.Controls.Add(this.settingsGrid);
            this.Controls.Add(this.PixelSize);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.CameraPixelText);
            this.Controls.Add(this.CameraDepthText);
            this.Controls.Add(this.CameraWidthText);
            this.Controls.Add(this.CameraHeightText);
            this.Controls.Add(this.newCameraID);
            this.Controls.Add(this.cameraID_label);
            this.Controls.Add(this.cameraID);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Camera Wrapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox cameraID;
        private System.Windows.Forms.Label cameraID_label;
        private System.Windows.Forms.Button newCameraID;
        private System.Windows.Forms.Label CameraHeightText;
        private System.Windows.Forms.Label CameraWidthText;
        private System.Windows.Forms.Label CameraDepthText;
        private System.Windows.Forms.Label CameraPixelText;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Depth;
        private System.Windows.Forms.TextBox PixelSize;
        public System.Windows.Forms.PropertyGrid settingsGrid;
    }
}
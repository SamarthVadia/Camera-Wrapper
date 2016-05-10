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
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(47, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Acquire";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cameraID
            // 
            this.cameraID.Location = new System.Drawing.Point(95, 107);
            this.cameraID.Name = "cameraID";
            this.cameraID.Size = new System.Drawing.Size(73, 20);
            this.cameraID.TabIndex = 2;
            // 
            // cameraID_label
            // 
            this.cameraID_label.AutoSize = true;
            this.cameraID_label.Location = new System.Drawing.Point(37, 110);
            this.cameraID_label.Name = "cameraID_label";
            this.cameraID_label.Size = new System.Drawing.Size(57, 13);
            this.cameraID_label.TabIndex = 3;
            this.cameraID_label.Text = "Camera ID";
            // 
            // newCameraID
            // 
            this.newCameraID.Location = new System.Drawing.Point(99, 141);
            this.newCameraID.Name = "newCameraID";
            this.newCameraID.Size = new System.Drawing.Size(126, 25);
            this.newCameraID.TabIndex = 4;
            this.newCameraID.Text = "Insert New CameraID";
            this.newCameraID.UseVisualStyleBackColor = true;
            this.newCameraID.Click += new System.EventHandler(this.newCameraID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 276);
            this.Controls.Add(this.newCameraID);
            this.Controls.Add(this.cameraID_label);
            this.Controls.Add(this.cameraID);
            this.Controls.Add(this.checkBox1);
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
    }
}
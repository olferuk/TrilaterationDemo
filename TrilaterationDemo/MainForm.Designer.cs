﻿namespace TrilaterationDemo
{
    partial class MainForm
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
            this.picBoxTrilateration = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtnPowerCenter = new System.Windows.Forms.RadioButton();
            this.rBtnRayTracing = new System.Windows.Forms.RadioButton();
            this.rBtnTrilateration = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrilateration)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxTrilateration
            // 
            this.picBoxTrilateration.Location = new System.Drawing.Point(12, 48);
            this.picBoxTrilateration.Name = "picBoxTrilateration";
            this.picBoxTrilateration.Size = new System.Drawing.Size(665, 450);
            this.picBoxTrilateration.TabIndex = 0;
            this.picBoxTrilateration.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(355, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtnPowerCenter);
            this.panel1.Controls.Add(this.rBtnRayTracing);
            this.panel1.Controls.Add(this.rBtnTrilateration);
            this.panel1.Location = new System.Drawing.Point(13, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 41);
            this.panel1.TabIndex = 2;
            // 
            // rBtnPowerCenter
            // 
            this.rBtnPowerCenter.AutoSize = true;
            this.rBtnPowerCenter.Location = new System.Drawing.Point(238, 11);
            this.rBtnPowerCenter.Name = "rBtnPowerCenter";
            this.rBtnPowerCenter.Size = new System.Drawing.Size(89, 17);
            this.rBtnPowerCenter.TabIndex = 2;
            this.rBtnPowerCenter.Text = "Power Center";
            this.rBtnPowerCenter.UseVisualStyleBackColor = true;
            this.rBtnPowerCenter.CheckedChanged += new System.EventHandler(this.rBtnPowerCenter_CheckedChanged);
            // 
            // rBtnRayTracing
            // 
            this.rBtnRayTracing.AutoSize = true;
            this.rBtnRayTracing.Location = new System.Drawing.Point(121, 11);
            this.rBtnRayTracing.Name = "rBtnRayTracing";
            this.rBtnRayTracing.Size = new System.Drawing.Size(83, 17);
            this.rBtnRayTracing.TabIndex = 1;
            this.rBtnRayTracing.Text = "Ray Tracing";
            this.rBtnRayTracing.UseVisualStyleBackColor = true;
            this.rBtnRayTracing.CheckedChanged += new System.EventHandler(this.rBtnRayTracing_CheckedChanged);
            // 
            // rBtnTrilateration
            // 
            this.rBtnTrilateration.AutoSize = true;
            this.rBtnTrilateration.Checked = true;
            this.rBtnTrilateration.Location = new System.Drawing.Point(3, 11);
            this.rBtnTrilateration.Name = "rBtnTrilateration";
            this.rBtnTrilateration.Size = new System.Drawing.Size(109, 17);
            this.rBtnTrilateration.TabIndex = 0;
            this.rBtnTrilateration.TabStop = true;
            this.rBtnTrilateration.Text = "Circle Intersection";
            this.rBtnTrilateration.UseVisualStyleBackColor = true;
            this.rBtnTrilateration.CheckedChanged += new System.EventHandler(this.rBtnTrilateration_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picBoxTrilateration);
            this.Name = "MainForm";
            this.Text = "Trilateration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrilateration)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxTrilateration;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBtnPowerCenter;
        private System.Windows.Forms.RadioButton rBtnRayTracing;
        private System.Windows.Forms.RadioButton rBtnTrilateration;
    }
}


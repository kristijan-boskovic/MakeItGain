﻿namespace FinAssist.PresentationLayer
{
    partial class frmViewHistoryWorkoutDetails
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtHistoryWorkoutDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(142, 212);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtHistoryWorkoutDetails
            // 
            this.txtHistoryWorkoutDetails.Location = new System.Drawing.Point(12, 9);
            this.txtHistoryWorkoutDetails.Name = "txtHistoryWorkoutDetails";
            this.txtHistoryWorkoutDetails.Size = new System.Drawing.Size(203, 197);
            this.txtHistoryWorkoutDetails.TabIndex = 3;
            this.txtHistoryWorkoutDetails.Text = "label1";
            this.txtHistoryWorkoutDetails.Click += new System.EventHandler(this.labelhistoryWorkoutDescription_Click);
            // 
            // frmViewHistoryWorkoutDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 250);
            this.Controls.Add(this.txtHistoryWorkoutDetails);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewHistoryWorkoutDetails";
            this.Text = "View workout details";
            this.Load += new System.EventHandler(this.frmViewHistoryWorkoutDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label txtHistoryWorkoutDetails;
    }
}
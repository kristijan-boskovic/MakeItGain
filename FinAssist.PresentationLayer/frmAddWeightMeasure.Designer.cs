﻿namespace FinAssist.PresentationLayer
{
    partial class frmAddWeightMeasure
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
            this.lblCurrentWeight = new System.Windows.Forms.Label();
            this.btnAddWeightMeasure = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCurrentWeight = new System.Windows.Forms.TextBox();
            this.lblGoalWeight = new System.Windows.Forms.Label();
            this.txtGoalWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCurrentWeight
            // 
            this.lblCurrentWeight.AutoSize = true;
            this.lblCurrentWeight.Location = new System.Drawing.Point(11, 21);
            this.lblCurrentWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentWeight.Name = "lblCurrentWeight";
            this.lblCurrentWeight.Size = new System.Drawing.Size(78, 13);
            this.lblCurrentWeight.TabIndex = 0;
            this.lblCurrentWeight.Text = "Current weight:";
            // 
            // btnAddWeightMeasure
            // 
            this.btnAddWeightMeasure.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddWeightMeasure.Location = new System.Drawing.Point(14, 153);
            this.btnAddWeightMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddWeightMeasure.Name = "btnAddWeightMeasure";
            this.btnAddWeightMeasure.Size = new System.Drawing.Size(75, 35);
            this.btnAddWeightMeasure.TabIndex = 3;
            this.btnAddWeightMeasure.Text = "Add";
            this.btnAddWeightMeasure.UseVisualStyleBackColor = true;
            this.btnAddWeightMeasure.Click += new System.EventHandler(this.btnAddWeightMeasure_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(175, 153);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCurrentWeight
            // 
            this.txtCurrentWeight.Location = new System.Drawing.Point(105, 18);
            this.txtCurrentWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentWeight.Name = "txtCurrentWeight";
            this.txtCurrentWeight.Size = new System.Drawing.Size(44, 20);
            this.txtCurrentWeight.TabIndex = 0;
            // 
            // lblGoalWeight
            // 
            this.lblGoalWeight.AutoSize = true;
            this.lblGoalWeight.Location = new System.Drawing.Point(10, 62);
            this.lblGoalWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoalWeight.Name = "lblGoalWeight";
            this.lblGoalWeight.Size = new System.Drawing.Size(66, 13);
            this.lblGoalWeight.TabIndex = 6;
            this.lblGoalWeight.Text = "Goal weight:";
            // 
            // txtGoalWeight
            // 
            this.txtGoalWeight.Location = new System.Drawing.Point(105, 59);
            this.txtGoalWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtGoalWeight.Name = "txtGoalWeight";
            this.txtGoalWeight.Size = new System.Drawing.Size(44, 20);
            this.txtGoalWeight.TabIndex = 7;
            // 
            // frmAddWeightMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(268, 199);
            this.Controls.Add(this.txtGoalWeight);
            this.Controls.Add(this.lblGoalWeight);
            this.Controls.Add(this.txtCurrentWeight);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddWeightMeasure);
            this.Controls.Add(this.lblCurrentWeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddWeightMeasure";
            this.Text = "Add new weight measure";
            this.Load += new System.EventHandler(this.frmAddWeightMeasure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentWeight;
        private System.Windows.Forms.Button btnAddWeightMeasure;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCurrentWeight;
        private System.Windows.Forms.Label lblGoalWeight;
        private System.Windows.Forms.TextBox txtGoalWeight;
    }
}
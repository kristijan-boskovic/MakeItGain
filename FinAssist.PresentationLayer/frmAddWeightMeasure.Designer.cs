namespace FinAssist.PresentationLayer
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
            this.labelCurrentWeight = new System.Windows.Forms.Label();
            this.btnAddNewWeightMeasure = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCurrentWeight = new System.Windows.Forms.TextBox();
            this.labelGoalWeight = new System.Windows.Forms.Label();
            this.txtGoalWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCurrentWeight
            // 
            this.labelCurrentWeight.AutoSize = true;
            this.labelCurrentWeight.Location = new System.Drawing.Point(11, 21);
            this.labelCurrentWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentWeight.Name = "labelCurrentWeight";
            this.labelCurrentWeight.Size = new System.Drawing.Size(78, 13);
            this.labelCurrentWeight.TabIndex = 0;
            this.labelCurrentWeight.Text = "Current weight:";
            // 
            // btnAddNewWeightMeasure
            // 
            this.btnAddNewWeightMeasure.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddNewWeightMeasure.Location = new System.Drawing.Point(14, 153);
            this.btnAddNewWeightMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewWeightMeasure.Name = "btnAddNewWeightMeasure";
            this.btnAddNewWeightMeasure.Size = new System.Drawing.Size(75, 35);
            this.btnAddNewWeightMeasure.TabIndex = 3;
            this.btnAddNewWeightMeasure.Text = "Add";
            this.btnAddNewWeightMeasure.UseVisualStyleBackColor = true;
            this.btnAddNewWeightMeasure.Click += new System.EventHandler(this.btnAddNewWeightMeasure_Click);
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
            // labelGoalWeight
            // 
            this.labelGoalWeight.AutoSize = true;
            this.labelGoalWeight.Location = new System.Drawing.Point(10, 62);
            this.labelGoalWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGoalWeight.Name = "labelGoalWeight";
            this.labelGoalWeight.Size = new System.Drawing.Size(66, 13);
            this.labelGoalWeight.TabIndex = 6;
            this.labelGoalWeight.Text = "Goal weight:";
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
            this.Controls.Add(this.labelGoalWeight);
            this.Controls.Add(this.txtCurrentWeight);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNewWeightMeasure);
            this.Controls.Add(this.labelCurrentWeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddWeightMeasure";
            this.Text = "Add new weight measure";
            this.Load += new System.EventHandler(this.frmAddWeightMeasure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentWeight;
        private System.Windows.Forms.Button btnAddNewWeightMeasure;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCurrentWeight;
        private System.Windows.Forms.Label labelGoalWeight;
        private System.Windows.Forms.TextBox txtGoalWeight;
    }
}
namespace FinAssist.PresentationLayer
{
    partial class frmViewExerciseDetails
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
            this.lblExerciseDescription = new System.Windows.Forms.Label();
            this.pctrBoxExercise = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxExercise)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(253, 351);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblExerciseDescription
            // 
            this.lblExerciseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExerciseDescription.Location = new System.Drawing.Point(352, 12);
            this.lblExerciseDescription.Name = "lblExerciseDescription";
            this.lblExerciseDescription.Size = new System.Drawing.Size(257, 66);
            this.lblExerciseDescription.TabIndex = 3;
            this.lblExerciseDescription.Text = "label";
            this.lblExerciseDescription.Click += new System.EventHandler(this.exerciseDescriptionLabel_Click);
            // 
            // pctrBoxExercise
            // 
            this.pctrBoxExercise.Image = global::FinAssist.PresentationLayer.Properties.Resources.situp;
            this.pctrBoxExercise.Location = new System.Drawing.Point(12, 12);
            this.pctrBoxExercise.Name = "pctrBoxExercise";
            this.pctrBoxExercise.Size = new System.Drawing.Size(334, 269);
            this.pctrBoxExercise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBoxExercise.TabIndex = 4;
            this.pctrBoxExercise.TabStop = false;
            // 
            // frmViewExerciseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(613, 399);
            this.Controls.Add(this.pctrBoxExercise);
            this.Controls.Add(this.lblExerciseDescription);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewExerciseDetails";
            this.Text = "View exercises";
            this.Load += new System.EventHandler(this.frmViewExerciseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxExercise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblExerciseDescription;
        private System.Windows.Forms.PictureBox pctrBoxExercise;
    }
}
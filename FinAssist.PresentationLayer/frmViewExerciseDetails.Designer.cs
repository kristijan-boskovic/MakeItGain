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
            this.labelExerciseDescription = new System.Windows.Forms.Label();
            this.pictureBoxExercise = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExercise)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(170, 249);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelExerciseDescription
            // 
            this.labelExerciseDescription.Location = new System.Drawing.Point(272, 12);
            this.labelExerciseDescription.Name = "labelExerciseDescription";
            this.labelExerciseDescription.Size = new System.Drawing.Size(203, 197);
            this.labelExerciseDescription.TabIndex = 3;
            this.labelExerciseDescription.Text = "label1";
            this.labelExerciseDescription.Click += new System.EventHandler(this.exerciseDescriptionLabel_Click);
            // 
            // pictureBoxExercise
            // 
            this.pictureBoxExercise.Image = global::FinAssist.PresentationLayer.Properties.Resources.deadlift;
            this.pictureBoxExercise.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxExercise.Name = "pictureBoxExercise";
            this.pictureBoxExercise.Size = new System.Drawing.Size(225, 209);
            this.pictureBoxExercise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExercise.TabIndex = 4;
            this.pictureBoxExercise.TabStop = false;
            // 
            // frmViewExerciseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 287);
            this.Controls.Add(this.pictureBoxExercise);
            this.Controls.Add(this.labelExerciseDescription);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewExerciseDetails";
            this.Text = "View exercises";
            this.Load += new System.EventHandler(this.frmViewExerciseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExercise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelExerciseDescription;
        private System.Windows.Forms.PictureBox pictureBoxExercise;
    }
}
namespace FinAssist.PresentationLayer
{
    partial class frmStartWorkout
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
            this.btnFinishWorkout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinishWorkout
            // 
            this.btnFinishWorkout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinishWorkout.Location = new System.Drawing.Point(117, 218);
            this.btnFinishWorkout.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinishWorkout.Name = "btnFinishWorkout";
            this.btnFinishWorkout.Size = new System.Drawing.Size(97, 46);
            this.btnFinishWorkout.TabIndex = 3;
            this.btnFinishWorkout.Text = "Finish workout";
            this.btnFinishWorkout.UseVisualStyleBackColor = true;
            this.btnFinishWorkout.Click += new System.EventHandler(this.btnFinishWorkout_Click);
            // 
            // frmStartWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 275);
            this.Controls.Add(this.btnFinishWorkout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStartWorkout";
            this.Text = "Workout session";
            this.Load += new System.EventHandler(this.frmStartWorkout_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFinishWorkout;
    }
}
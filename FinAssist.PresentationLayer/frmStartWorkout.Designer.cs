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
            this.components = new System.ComponentModel.Container();
            this.btnFinishWorkout = new System.Windows.Forms.Button();
            this.tmrWorkout = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.lblReps = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFinishWorkout
            // 
            this.btnFinishWorkout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinishWorkout.Location = new System.Drawing.Point(261, 455);
            this.btnFinishWorkout.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinishWorkout.Name = "btnFinishWorkout";
            this.btnFinishWorkout.Size = new System.Drawing.Size(108, 52);
            this.btnFinishWorkout.TabIndex = 3;
            this.btnFinishWorkout.Text = "Finish workout";
            this.btnFinishWorkout.UseVisualStyleBackColor = true;
            this.btnFinishWorkout.Click += new System.EventHandler(this.btnFinishWorkout_Click);
            // 
            // tmrWorkout
            // 
            this.tmrWorkout.Tick += new System.EventHandler(this.tmrWorkout_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimer.Location = new System.Drawing.Point(485, 77);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(66, 29);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "label";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(321, 77);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(168, 29);
            this.lblTimeElapsed.TabIndex = 6;
            this.lblTimeElapsed.Text = "Time elapsed:";
            // 
            // lblReps
            // 
            this.lblReps.AutoSize = true;
            this.lblReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReps.Location = new System.Drawing.Point(131, 0);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(32, 13);
            this.lblReps.TabIndex = 7;
            this.lblReps.Text = "Reps";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWeight.Location = new System.Drawing.Point(169, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(62, 13);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Weight (kg)";
            // 
            // frmStartWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(637, 518);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblReps);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnFinishWorkout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStartWorkout";
            this.Text = "Workout session";
            this.Load += new System.EventHandler(this.frmStartWorkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinishWorkout;
        private System.Windows.Forms.Timer tmrWorkout;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Label lblReps;
        private System.Windows.Forms.Label lblWeight;
    }
}
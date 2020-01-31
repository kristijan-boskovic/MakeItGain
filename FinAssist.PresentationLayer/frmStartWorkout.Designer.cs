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
            this.labelInfo = new System.Windows.Forms.Label();
            this.timerWorkout = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelTimeElapsed = new System.Windows.Forms.Label();
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
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInfo.Location = new System.Drawing.Point(258, 18);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(367, 32);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Input the number of reps done in each set.\r\nAfter you finish this workout, you ca" +
    "n see it\'s details in History.\r\n";
            // 
            // timerWorkout
            // 
            this.timerWorkout.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.Location = new System.Drawing.Point(420, 106);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(66, 29);
            this.labelTimer.TabIndex = 5;
            this.labelTimer.Text = "label";
            this.labelTimer.Click += new System.EventHandler(this.labelTimer_Click);
            // 
            // labelTimeElapsed
            // 
            this.labelTimeElapsed.AutoSize = true;
            this.labelTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimeElapsed.Location = new System.Drawing.Point(256, 106);
            this.labelTimeElapsed.Name = "labelTimeElapsed";
            this.labelTimeElapsed.Size = new System.Drawing.Size(168, 29);
            this.labelTimeElapsed.TabIndex = 6;
            this.labelTimeElapsed.Text = "Time elapsed:";
            // 
            // frmStartWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(637, 518);
            this.Controls.Add(this.labelTimeElapsed);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelInfo);
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
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Timer timerWorkout;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelTimeElapsed;
    }
}
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
            this.timerWorkout = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelTimeElapsed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // timerWorkout
            // 
            this.timerWorkout.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.Location = new System.Drawing.Point(485, 77);
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
            this.labelTimeElapsed.Location = new System.Drawing.Point(321, 77);
            this.labelTimeElapsed.Name = "labelTimeElapsed";
            this.labelTimeElapsed.Size = new System.Drawing.Size(168, 29);
            this.labelTimeElapsed.TabIndex = 6;
            this.labelTimeElapsed.Text = "Time elapsed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(169, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weight (kg)";
            // 
            // frmStartWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(637, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTimeElapsed);
            this.Controls.Add(this.labelTimer);
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
        private System.Windows.Forms.Timer timerWorkout;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelTimeElapsed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
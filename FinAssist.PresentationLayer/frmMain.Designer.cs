namespace FinAssist.PresentationLayer
{
    partial class frmMain
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
            this.btnExercises = new System.Windows.Forms.Button();
            this.btnWorkouts = new System.Windows.Forms.Button();
            this.btnBody = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExercises
            // 
            this.btnExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExercises.Location = new System.Drawing.Point(112, 221);
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.Size = new System.Drawing.Size(158, 54);
            this.btnExercises.TabIndex = 1;
            this.btnExercises.Text = "Exercises";
            this.btnExercises.UseVisualStyleBackColor = true;
            this.btnExercises.Click += new System.EventHandler(this.exercisesButton_Click);
            // 
            // btnWorkouts
            // 
            this.btnWorkouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkouts.Location = new System.Drawing.Point(112, 126);
            this.btnWorkouts.Name = "btnWorkouts";
            this.btnWorkouts.Size = new System.Drawing.Size(158, 54);
            this.btnWorkouts.TabIndex = 2;
            this.btnWorkouts.Text = "Workouts";
            this.btnWorkouts.UseVisualStyleBackColor = true;
            this.btnWorkouts.Click += new System.EventHandler(this.workoutsButton_Click);
            // 
            // btnBody
            // 
            this.btnBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBody.Location = new System.Drawing.Point(336, 221);
            this.btnBody.Name = "btnBody";
            this.btnBody.Size = new System.Drawing.Size(158, 54);
            this.btnBody.TabIndex = 3;
            this.btnBody.Text = "Body";
            this.btnBody.UseVisualStyleBackColor = true;
            this.btnBody.Click += new System.EventHandler(this.bodyButton_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHistory.Location = new System.Drawing.Point(336, 126);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(158, 54);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcomeTitle.Location = new System.Drawing.Point(164, 26);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(280, 29);
            this.lblWelcomeTitle.TabIndex = 6;
            this.lblWelcomeTitle.Text = "Welcome to Make It Gain";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 415);
            this.Controls.Add(this.lblWelcomeTitle);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnBody);
            this.Controls.Add(this.btnWorkouts);
            this.Controls.Add(this.btnExercises);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Make It Gain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExercises;
        private System.Windows.Forms.Button btnWorkouts;
        private System.Windows.Forms.Button btnBody;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label lblWelcomeTitle;
    }
}
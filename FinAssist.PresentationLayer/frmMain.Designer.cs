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
            this.exercisesButton = new System.Windows.Forms.Button();
            this.workoutsButton = new System.Windows.Forms.Button();
            this.bodyButton = new System.Windows.Forms.Button();
            this.trainerButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exercisesButton
            // 
            this.exercisesButton.Location = new System.Drawing.Point(98, 177);
            this.exercisesButton.Name = "exercisesButton";
            this.exercisesButton.Size = new System.Drawing.Size(158, 54);
            this.exercisesButton.TabIndex = 1;
            this.exercisesButton.Text = "Exercises";
            this.exercisesButton.UseVisualStyleBackColor = true;
            this.exercisesButton.Click += new System.EventHandler(this.exercisesButton_Click);
            // 
            // workoutsButton
            // 
            this.workoutsButton.Location = new System.Drawing.Point(98, 82);
            this.workoutsButton.Name = "workoutsButton";
            this.workoutsButton.Size = new System.Drawing.Size(158, 54);
            this.workoutsButton.TabIndex = 2;
            this.workoutsButton.Text = "Workouts";
            this.workoutsButton.UseVisualStyleBackColor = true;
            this.workoutsButton.Click += new System.EventHandler(this.workoutsButton_Click);
            // 
            // bodyButton
            // 
            this.bodyButton.Location = new System.Drawing.Point(216, 266);
            this.bodyButton.Name = "bodyButton";
            this.bodyButton.Size = new System.Drawing.Size(158, 54);
            this.bodyButton.TabIndex = 3;
            this.bodyButton.Text = "Body";
            this.bodyButton.UseVisualStyleBackColor = true;
            this.bodyButton.Click += new System.EventHandler(this.bodyButton_Click);
            // 
            // trainerButton
            // 
            this.trainerButton.Location = new System.Drawing.Point(335, 177);
            this.trainerButton.Name = "trainerButton";
            this.trainerButton.Size = new System.Drawing.Size(158, 54);
            this.trainerButton.TabIndex = 4;
            this.trainerButton.Text = "Trainer";
            this.trainerButton.UseVisualStyleBackColor = true;
            this.trainerButton.Click += new System.EventHandler(this.trainerButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(335, 82);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(158, 54);
            this.historyButton.TabIndex = 5;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 415);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.trainerButton);
            this.Controls.Add(this.bodyButton);
            this.Controls.Add(this.workoutsButton);
            this.Controls.Add(this.exercisesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Make It Gain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exercisesButton;
        private System.Windows.Forms.Button workoutsButton;
        private System.Windows.Forms.Button bodyButton;
        private System.Windows.Forms.Button trainerButton;
        private System.Windows.Forms.Button historyButton;
    }
}
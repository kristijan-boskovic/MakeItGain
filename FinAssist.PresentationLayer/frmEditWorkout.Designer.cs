namespace FinAssist.PresentationLayer
{
    partial class frmEditWorkout
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
        /// the contents of this method with the code editor.frmEditWorkout
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWorkoutName = new System.Windows.Forms.Label();
            this.btnEditWorkout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtWorkoutName = new System.Windows.Forms.TextBox();
            this.labelExercises = new System.Windows.Forms.Label();
            this.chkdListBoxExercises = new System.Windows.Forms.CheckedListBox();
            this.txtSetsPerExercise = new System.Windows.Forms.TextBox();
            this.labelSetsPerExercise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWorkoutName
            // 
            this.labelWorkoutName.AutoSize = true;
            this.labelWorkoutName.Location = new System.Drawing.Point(9, 20);
            this.labelWorkoutName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWorkoutName.Name = "labelWorkoutName";
            this.labelWorkoutName.Size = new System.Drawing.Size(80, 13);
            this.labelWorkoutName.TabIndex = 0;
            this.labelWorkoutName.Text = "Workout name:";
            // 
            // btnEditWorkout
            // 
            this.btnEditWorkout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditWorkout.Location = new System.Drawing.Point(12, 154);
            this.btnEditWorkout.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditWorkout.Name = "btnEditWorkout";
            this.btnEditWorkout.Size = new System.Drawing.Size(67, 34);
            this.btnEditWorkout.TabIndex = 3;
            this.btnEditWorkout.Text = "Apply";
            this.btnEditWorkout.UseVisualStyleBackColor = true;
            this.btnEditWorkout.Click += new System.EventHandler(this.btnEditWorkout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(183, 154);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtWorkoutName
            // 
            this.txtWorkoutName.Location = new System.Drawing.Point(105, 18);
            this.txtWorkoutName.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorkoutName.Name = "txtWorkoutName";
            this.txtWorkoutName.Size = new System.Drawing.Size(145, 20);
            this.txtWorkoutName.TabIndex = 0;
            // 
            // labelExercises
            // 
            this.labelExercises.AutoSize = true;
            this.labelExercises.Location = new System.Drawing.Point(11, 55);
            this.labelExercises.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExercises.Name = "labelExercises";
            this.labelExercises.Size = new System.Drawing.Size(55, 13);
            this.labelExercises.TabIndex = 1;
            this.labelExercises.Text = "Exercises:";
            // 
            // chkdListBoxExercises
            // 
            this.chkdListBoxExercises.FormattingEnabled = true;
            this.chkdListBoxExercises.Items.AddRange(new object[] {
            "Bench press",
            "Military press",
            "Squat",
            "Deadlift",
            "Dumbbell curl",
            "Rope pushdown",
            "Pullup",
            "Plank"});
            this.chkdListBoxExercises.Location = new System.Drawing.Point(106, 55);
            this.chkdListBoxExercises.Name = "chkdListBoxExercises";
            this.chkdListBoxExercises.Size = new System.Drawing.Size(144, 64);
            this.chkdListBoxExercises.TabIndex = 5;
            // 
            // txtSetsPerExercise
            // 
            this.txtSetsPerExercise.Location = new System.Drawing.Point(106, 125);
            this.txtSetsPerExercise.Margin = new System.Windows.Forms.Padding(2);
            this.txtSetsPerExercise.Name = "txtSetsPerExercise";
            this.txtSetsPerExercise.Size = new System.Drawing.Size(31, 20);
            this.txtSetsPerExercise.TabIndex = 9;
            // 
            // labelSetsPerExercise
            // 
            this.labelSetsPerExercise.AutoSize = true;
            this.labelSetsPerExercise.Location = new System.Drawing.Point(11, 128);
            this.labelSetsPerExercise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSetsPerExercise.Name = "labelSetsPerExercise";
            this.labelSetsPerExercise.Size = new System.Drawing.Size(91, 13);
            this.labelSetsPerExercise.TabIndex = 8;
            this.labelSetsPerExercise.Text = "Sets per exercise:";
            // 
            // frmEditWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(268, 199);
            this.Controls.Add(this.txtSetsPerExercise);
            this.Controls.Add(this.labelSetsPerExercise);
            this.Controls.Add(this.chkdListBoxExercises);
            this.Controls.Add(this.txtWorkoutName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditWorkout);
            this.Controls.Add(this.labelExercises);
            this.Controls.Add(this.labelWorkoutName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEditWorkout";
            this.Text = "Edit workout";
            this.Load += new System.EventHandler(this.frmEditWorkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWorkoutName;
        private System.Windows.Forms.Button btnEditWorkout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtWorkoutName;
        private System.Windows.Forms.Label labelExercises;
        private System.Windows.Forms.CheckedListBox chkdListBoxExercises;
        private System.Windows.Forms.TextBox txtSetsPerExercise;
        private System.Windows.Forms.Label labelSetsPerExercise;
    }
}
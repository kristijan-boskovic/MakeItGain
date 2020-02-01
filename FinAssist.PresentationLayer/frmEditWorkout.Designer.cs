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
            this.lblWorkoutName = new System.Windows.Forms.Label();
            this.btnEditWorkout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtWorkoutName = new System.Windows.Forms.TextBox();
            this.lblExercises = new System.Windows.Forms.Label();
            this.chkdListBoxExercises = new System.Windows.Forms.CheckedListBox();
            this.txtSetsPerExercise = new System.Windows.Forms.TextBox();
            this.lblSetsPerExercise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWorkoutName
            // 
            this.lblWorkoutName.AutoSize = true;
            this.lblWorkoutName.Location = new System.Drawing.Point(9, 20);
            this.lblWorkoutName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkoutName.Name = "lblWorkoutName";
            this.lblWorkoutName.Size = new System.Drawing.Size(80, 13);
            this.lblWorkoutName.TabIndex = 0;
            this.lblWorkoutName.Text = "Workout name:";
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
            // lblExercises
            // 
            this.lblExercises.AutoSize = true;
            this.lblExercises.Location = new System.Drawing.Point(11, 55);
            this.lblExercises.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExercises.Name = "lblExercises";
            this.lblExercises.Size = new System.Drawing.Size(55, 13);
            this.lblExercises.TabIndex = 1;
            this.lblExercises.Text = "Exercises:";
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
            "Situp"});
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
            // lblSetsPerExercise
            // 
            this.lblSetsPerExercise.AutoSize = true;
            this.lblSetsPerExercise.Location = new System.Drawing.Point(11, 128);
            this.lblSetsPerExercise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSetsPerExercise.Name = "lblSetsPerExercise";
            this.lblSetsPerExercise.Size = new System.Drawing.Size(91, 13);
            this.lblSetsPerExercise.TabIndex = 8;
            this.lblSetsPerExercise.Text = "Sets per exercise:";
            // 
            // frmEditWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(268, 199);
            this.Controls.Add(this.txtSetsPerExercise);
            this.Controls.Add(this.lblSetsPerExercise);
            this.Controls.Add(this.chkdListBoxExercises);
            this.Controls.Add(this.txtWorkoutName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditWorkout);
            this.Controls.Add(this.lblExercises);
            this.Controls.Add(this.lblWorkoutName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEditWorkout";
            this.Text = "Edit workout";
            this.Load += new System.EventHandler(this.frmEditWorkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWorkoutName;
        private System.Windows.Forms.Button btnEditWorkout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtWorkoutName;
        private System.Windows.Forms.Label lblExercises;
        private System.Windows.Forms.CheckedListBox chkdListBoxExercises;
        private System.Windows.Forms.TextBox txtSetsPerExercise;
        private System.Windows.Forms.Label lblSetsPerExercise;
    }
}
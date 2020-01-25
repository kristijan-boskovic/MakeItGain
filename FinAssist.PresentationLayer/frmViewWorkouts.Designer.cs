namespace FinAssist.PresentationLayer
{
    partial class frmViewWorkouts
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
            this.listWorkouts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewWorkout = new System.Windows.Forms.Button();
            this.btnEditWorkout = new System.Windows.Forms.Button();
            this.btnDeleteWorkout = new System.Windows.Forms.Button();
            this.btnSetUpWorkout = new System.Windows.Forms.Button();
            this.labelExerciseDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listWorkouts
            // 
            this.listWorkouts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listWorkouts.HideSelection = false;
            this.listWorkouts.Location = new System.Drawing.Point(11, 11);
            this.listWorkouts.Margin = new System.Windows.Forms.Padding(2);
            this.listWorkouts.Name = "listWorkouts";
            this.listWorkouts.Size = new System.Drawing.Size(339, 206);
            this.listWorkouts.TabIndex = 0;
            this.listWorkouts.UseCompatibleStateImageBehavior = false;
            this.listWorkouts.View = System.Windows.Forms.View.Details;
            this.listWorkouts.SelectedIndexChanged += new System.EventHandler(this.listWorkouts_SelectedIndexChanged);
            this.listWorkouts.DoubleClick += new System.EventHandler(this.listWorkouts_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Day";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Workout";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sets";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Exercises";
            this.columnHeader4.Width = 221;
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
            // btnAddNewWorkout
            // 
            this.btnAddNewWorkout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddNewWorkout.Location = new System.Drawing.Point(367, 11);
            this.btnAddNewWorkout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewWorkout.Name = "btnAddNewWorkout";
            this.btnAddNewWorkout.Size = new System.Drawing.Size(109, 33);
            this.btnAddNewWorkout.TabIndex = 3;
            this.btnAddNewWorkout.Text = "Add new workout";
            this.btnAddNewWorkout.UseVisualStyleBackColor = true;
            this.btnAddNewWorkout.Click += new System.EventHandler(this.btnAddNewWorkout_Click);
            // 
            // btnEditWorkout
            // 
            this.btnEditWorkout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditWorkout.Location = new System.Drawing.Point(367, 61);
            this.btnEditWorkout.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditWorkout.Name = "btnEditWorkout";
            this.btnEditWorkout.Size = new System.Drawing.Size(109, 33);
            this.btnEditWorkout.TabIndex = 4;
            this.btnEditWorkout.Text = "Edit workout";
            this.btnEditWorkout.UseVisualStyleBackColor = true;
            this.btnEditWorkout.Click += new System.EventHandler(this.btnEditWorkout_Click);
            // 
            // btnDeleteWorkout
            // 
            this.btnDeleteWorkout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeleteWorkout.Location = new System.Drawing.Point(367, 118);
            this.btnDeleteWorkout.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteWorkout.Name = "btnDeleteWorkout";
            this.btnDeleteWorkout.Size = new System.Drawing.Size(109, 33);
            this.btnDeleteWorkout.TabIndex = 5;
            this.btnDeleteWorkout.Text = "Delete workout";
            this.btnDeleteWorkout.UseVisualStyleBackColor = true;
            this.btnDeleteWorkout.Click += new System.EventHandler(this.btnDeleteWorkout_Click);
            // 
            // btnSetUpWorkout
            // 
            this.btnSetUpWorkout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSetUpWorkout.Location = new System.Drawing.Point(367, 176);
            this.btnSetUpWorkout.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetUpWorkout.Name = "btnSetUpWorkout";
            this.btnSetUpWorkout.Size = new System.Drawing.Size(109, 41);
            this.btnSetUpWorkout.TabIndex = 6;
            this.btnSetUpWorkout.Text = "Start workout session";
            this.btnSetUpWorkout.UseVisualStyleBackColor = true;
            this.btnSetUpWorkout.Click += new System.EventHandler(this.btnStartWorkout_Click);
            // 
            // labelExerciseDescription
            // 
            this.labelExerciseDescription.Location = new System.Drawing.Point(8, 245);
            this.labelExerciseDescription.Name = "labelExerciseDescription";
            this.labelExerciseDescription.Size = new System.Drawing.Size(146, 34);
            this.labelExerciseDescription.TabIndex = 7;
            this.labelExerciseDescription.Text = "Hint: click on Day number to choose workout.";
            this.labelExerciseDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmViewWorkouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(487, 287);
            this.Controls.Add(this.labelExerciseDescription);
            this.Controls.Add(this.btnSetUpWorkout);
            this.Controls.Add(this.btnDeleteWorkout);
            this.Controls.Add(this.btnEditWorkout);
            this.Controls.Add(this.btnAddNewWorkout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listWorkouts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewWorkouts";
            this.Text = "Workouts";
            this.Load += new System.EventHandler(this.frmViewWorkouts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listWorkouts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAddNewWorkout;
        private System.Windows.Forms.Button btnEditWorkout;
        private System.Windows.Forms.Button btnDeleteWorkout;
        private System.Windows.Forms.Button btnSetUpWorkout;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelExerciseDescription;
    }
}
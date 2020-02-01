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
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.btnEditWorkout = new System.Windows.Forms.Button();
            this.btnDeleteWorkout = new System.Windows.Forms.Button();
            this.btnStartWorkout = new System.Windows.Forms.Button();
            this.lblExerciseDescription = new System.Windows.Forms.Label();
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
            // btnAddWorkout
            // 
            this.btnAddWorkout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddWorkout.Location = new System.Drawing.Point(367, 11);
            this.btnAddWorkout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(109, 33);
            this.btnAddWorkout.TabIndex = 3;
            this.btnAddWorkout.Text = "Add new workout";
            this.btnAddWorkout.UseVisualStyleBackColor = true;
            this.btnAddWorkout.Click += new System.EventHandler(this.btnAddNewWorkout_Click);
            // 
            // btnEditWorkout
            // 
            this.btnEditWorkout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditWorkout.Location = new System.Drawing.Point(367, 59);
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
            this.btnDeleteWorkout.Location = new System.Drawing.Point(367, 107);
            this.btnDeleteWorkout.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteWorkout.Name = "btnDeleteWorkout";
            this.btnDeleteWorkout.Size = new System.Drawing.Size(109, 33);
            this.btnDeleteWorkout.TabIndex = 5;
            this.btnDeleteWorkout.Text = "Delete workout";
            this.btnDeleteWorkout.UseVisualStyleBackColor = true;
            this.btnDeleteWorkout.Click += new System.EventHandler(this.btnDeleteWorkout_Click);
            // 
            // btnStartWorkout
            // 
            this.btnStartWorkout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStartWorkout.Location = new System.Drawing.Point(367, 176);
            this.btnStartWorkout.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartWorkout.Name = "btnStartWorkout";
            this.btnStartWorkout.Size = new System.Drawing.Size(109, 41);
            this.btnStartWorkout.TabIndex = 6;
            this.btnStartWorkout.Text = "Start workout";
            this.btnStartWorkout.UseVisualStyleBackColor = true;
            this.btnStartWorkout.Click += new System.EventHandler(this.btnStartWorkout_Click);
            // 
            // lblExerciseDescription
            // 
            this.lblExerciseDescription.Location = new System.Drawing.Point(8, 245);
            this.lblExerciseDescription.Name = "lblExerciseDescription";
            this.lblExerciseDescription.Size = new System.Drawing.Size(146, 34);
            this.lblExerciseDescription.TabIndex = 7;
            this.lblExerciseDescription.Text = "Hint: click on Day number to choose workout.";
            this.lblExerciseDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmViewWorkouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(487, 287);
            this.Controls.Add(this.lblExerciseDescription);
            this.Controls.Add(this.btnStartWorkout);
            this.Controls.Add(this.btnDeleteWorkout);
            this.Controls.Add(this.btnEditWorkout);
            this.Controls.Add(this.btnAddWorkout);
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
        private System.Windows.Forms.Button btnAddWorkout;
        private System.Windows.Forms.Button btnEditWorkout;
        private System.Windows.Forms.Button btnDeleteWorkout;
        private System.Windows.Forms.Button btnStartWorkout;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblExerciseDescription;
    }
}
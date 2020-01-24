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
            this.btnClose = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addNewWorkoutButton = new System.Windows.Forms.Button();
            this.editWorkoutButton = new System.Windows.Forms.Button();
            this.deleteWorkoutButton = new System.Windows.Forms.Button();
            this.startWorkoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listWorkouts
            // 
            this.listWorkouts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listWorkouts.HideSelection = false;
            this.listWorkouts.Location = new System.Drawing.Point(11, 11);
            this.listWorkouts.Margin = new System.Windows.Forms.Padding(2);
            this.listWorkouts.Name = "listWorkouts";
            this.listWorkouts.Size = new System.Drawing.Size(351, 219);
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
            this.columnHeader2.Width = 90;
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Exercises";
            this.columnHeader3.Width = 331;
            // 
            // addNewWorkoutButton
            // 
            this.addNewWorkoutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addNewWorkoutButton.Location = new System.Drawing.Point(367, 11);
            this.addNewWorkoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.addNewWorkoutButton.Name = "addNewWorkoutButton";
            this.addNewWorkoutButton.Size = new System.Drawing.Size(109, 33);
            this.addNewWorkoutButton.TabIndex = 3;
            this.addNewWorkoutButton.Text = "Add new workout";
            this.addNewWorkoutButton.UseVisualStyleBackColor = true;
            this.addNewWorkoutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // editWorkoutButton
            // 
            this.editWorkoutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.editWorkoutButton.Location = new System.Drawing.Point(367, 67);
            this.editWorkoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.editWorkoutButton.Name = "editWorkoutButton";
            this.editWorkoutButton.Size = new System.Drawing.Size(109, 33);
            this.editWorkoutButton.TabIndex = 4;
            this.editWorkoutButton.Text = "Edit workout";
            this.editWorkoutButton.UseVisualStyleBackColor = true;
            // 
            // deleteWorkoutButton
            // 
            this.deleteWorkoutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.deleteWorkoutButton.Location = new System.Drawing.Point(367, 127);
            this.deleteWorkoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteWorkoutButton.Name = "deleteWorkoutButton";
            this.deleteWorkoutButton.Size = new System.Drawing.Size(109, 33);
            this.deleteWorkoutButton.TabIndex = 5;
            this.deleteWorkoutButton.Text = "Delete workout";
            this.deleteWorkoutButton.UseVisualStyleBackColor = true;
            // 
            // startWorkoutButton
            // 
            this.startWorkoutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.startWorkoutButton.Location = new System.Drawing.Point(367, 189);
            this.startWorkoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.startWorkoutButton.Name = "startWorkoutButton";
            this.startWorkoutButton.Size = new System.Drawing.Size(109, 41);
            this.startWorkoutButton.TabIndex = 6;
            this.startWorkoutButton.Text = "Start workout session";
            this.startWorkoutButton.UseVisualStyleBackColor = true;
            // 
            // frmViewWorkouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 287);
            this.Controls.Add(this.startWorkoutButton);
            this.Controls.Add(this.deleteWorkoutButton);
            this.Controls.Add(this.editWorkoutButton);
            this.Controls.Add(this.addNewWorkoutButton);
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
        private System.Windows.Forms.Button addNewWorkoutButton;
        private System.Windows.Forms.Button editWorkoutButton;
        private System.Windows.Forms.Button deleteWorkoutButton;
        private System.Windows.Forms.Button startWorkoutButton;
    }
}
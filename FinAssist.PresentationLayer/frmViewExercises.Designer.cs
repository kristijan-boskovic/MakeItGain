namespace FinAssist.PresentationLayer
{
    partial class frmViewExercises
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
            this.listExercises = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblExerciseDescription = new System.Windows.Forms.Label();
            this.cmbMuscleGroup = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listExercises
            // 
            this.listExercises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listExercises.HideSelection = false;
            this.listExercises.Location = new System.Drawing.Point(11, 11);
            this.listExercises.Margin = new System.Windows.Forms.Padding(2);
            this.listExercises.Name = "listExercises";
            this.listExercises.Size = new System.Drawing.Size(289, 219);
            this.listExercises.TabIndex = 0;
            this.listExercises.UseCompatibleStateImageBehavior = false;
            this.listExercises.View = System.Windows.Forms.View.Details;
            this.listExercises.DoubleClick += new System.EventHandler(this.listExercises_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Exercise";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Muscle group";
            this.columnHeader2.Width = 137;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(182, 249);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblExerciseDescription
            // 
            this.lblExerciseDescription.Location = new System.Drawing.Point(319, 196);
            this.lblExerciseDescription.Name = "lblExerciseDescription";
            this.lblExerciseDescription.Size = new System.Drawing.Size(147, 34);
            this.lblExerciseDescription.TabIndex = 4;
            this.lblExerciseDescription.Text = "Hint: double-click on exercise name to see exercise details.";
            // 
            // cmbMuscleGroup
            // 
            this.cmbMuscleGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMuscleGroup.FormattingEnabled = true;
            this.cmbMuscleGroup.Items.AddRange(new object[] {
            "all",
            "abs",
            "back",
            "biceps",
            "chest",
            "legs",
            "shoulders",
            "triceps"});
            this.cmbMuscleGroup.Location = new System.Drawing.Point(357, 11);
            this.cmbMuscleGroup.Name = "cmbMuscleGroup";
            this.cmbMuscleGroup.Size = new System.Drawing.Size(76, 21);
            this.cmbMuscleGroup.TabIndex = 5;
            this.cmbMuscleGroup.SelectedIndexChanged += new System.EventHandler(this.cmbMuscleGroup_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(319, 14);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Filter:";
            // 
            // frmViewExercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(487, 287);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbMuscleGroup);
            this.Controls.Add(this.lblExerciseDescription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listExercises);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewExercises";
            this.Text = "Exercises";
            this.Load += new System.EventHandler(this.frmViewExercises_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listExercises;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblExerciseDescription;
        private System.Windows.Forms.ComboBox cmbMuscleGroup;
        private System.Windows.Forms.Label lblFilter;
    }
}
namespace FinAssist.PresentationLayer
{
    partial class ExercisesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listDiplayExercises = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listAccounts
            // 
            this.listDiplayExercises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listDiplayExercises.HideSelection = false;
            this.listDiplayExercises.Location = new System.Drawing.Point(141, 92);
            this.listDiplayExercises.Margin = new System.Windows.Forms.Padding(2);
            this.listDiplayExercises.Name = "listAccounts";
            this.listDiplayExercises.Size = new System.Drawing.Size(465, 219);
            this.listDiplayExercises.TabIndex = 1;
            this.listDiplayExercises.UseCompatibleStateImageBehavior = false;
            this.listDiplayExercises.View = System.Windows.Forms.View.Details;
            this.listDiplayExercises.SelectedIndexChanged += new System.EventHandler(this.listAccounts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 173;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Muscle group";
            this.columnHeader2.Width = 137;
            // 
            // ExercisesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listDiplayExercises);
            this.Name = "ExercisesControl";
            this.Size = new System.Drawing.Size(817, 423);
            this.Load += new System.EventHandler(this.ExercisesControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listDiplayExercises;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

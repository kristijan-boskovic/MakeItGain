namespace FinAssist.PresentationLayer
{
    partial class frmViewWeightMeasures
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
            this.listWeightMeasures = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddWeightMeasure = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listWeightMeasures
            // 
            this.listWeightMeasures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listWeightMeasures.HideSelection = false;
            this.listWeightMeasures.Location = new System.Drawing.Point(138, 11);
            this.listWeightMeasures.Margin = new System.Windows.Forms.Padding(2);
            this.listWeightMeasures.Name = "listWeightMeasures";
            this.listWeightMeasures.Size = new System.Drawing.Size(318, 216);
            this.listWeightMeasures.TabIndex = 0;
            this.listWeightMeasures.UseCompatibleStateImageBehavior = false;
            this.listWeightMeasures.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 64;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Current weight";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Goal weight";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Weight to lose";
            this.columnHeader4.Width = 90;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(186, 249);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddWeightMeasure
            // 
            this.btnAddWeightMeasure.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddWeightMeasure.Location = new System.Drawing.Point(11, 11);
            this.btnAddWeightMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddWeightMeasure.Name = "btnAddWeightMeasure";
            this.btnAddWeightMeasure.Size = new System.Drawing.Size(99, 46);
            this.btnAddWeightMeasure.TabIndex = 3;
            this.btnAddWeightMeasure.Text = "Add new weight measure";
            this.btnAddWeightMeasure.UseVisualStyleBackColor = true;
            this.btnAddWeightMeasure.Click += new System.EventHandler(this.btnAddWeightMeasure_Click);
            // 
            // lblHint
            // 
            this.lblHint.Location = new System.Drawing.Point(8, 193);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(117, 34);
            this.lblHint.TabIndex = 5;
            this.lblHint.Text = "Hint: for decimal sign use comma (e.g. 92,5)";
            // 
            // frmViewWeightMeasures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(487, 287);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnAddWeightMeasure);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listWeightMeasures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewWeightMeasures";
            this.Text = "Workouts";
            this.Load += new System.EventHandler(this.frmViewWeightMeasures_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listWeightMeasures;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAddWeightMeasure;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblHint;
    }
}
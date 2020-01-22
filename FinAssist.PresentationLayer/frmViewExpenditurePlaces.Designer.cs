namespace FinAssist.PresentationLayer
{
    partial class frmViewExpenditurePlaces
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
            this.ctrlListPlaces = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewPlaceName = new System.Windows.Forms.TextBox();
            this.cmdAddNewPlace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlListPlaces
            // 
            this.ctrlListPlaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ctrlListPlaces.Location = new System.Drawing.Point(22, 29);
            this.ctrlListPlaces.Name = "ctrlListPlaces";
            this.ctrlListPlaces.Size = new System.Drawing.Size(209, 270);
            this.ctrlListPlaces.TabIndex = 5;
            this.ctrlListPlaces.UseCompatibleStateImageBehavior = false;
            this.ctrlListPlaces.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Place name";
            this.columnHeader1.Width = 203;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(94, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNewPlaceName
            // 
            this.txtNewPlaceName.Location = new System.Drawing.Point(22, 323);
            this.txtNewPlaceName.Name = "txtNewPlaceName";
            this.txtNewPlaceName.Size = new System.Drawing.Size(133, 20);
            this.txtNewPlaceName.TabIndex = 8;
            // 
            // cmdAddNewPlace
            // 
            this.cmdAddNewPlace.Location = new System.Drawing.Point(161, 323);
            this.cmdAddNewPlace.Name = "cmdAddNewPlace";
            this.cmdAddNewPlace.Size = new System.Drawing.Size(70, 23);
            this.cmdAddNewPlace.TabIndex = 7;
            this.cmdAddNewPlace.Text = "Add new";
            this.cmdAddNewPlace.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Places";
            // 
            // frmViewExpenditurePlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 409);
            this.Controls.Add(this.ctrlListPlaces);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNewPlaceName);
            this.Controls.Add(this.cmdAddNewPlace);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewExpenditurePlaces";
            this.Text = "Expenditure places";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ctrlListPlaces;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNewPlaceName;
        private System.Windows.Forms.Button cmdAddNewPlace;
        private System.Windows.Forms.Label label1;
    }
}
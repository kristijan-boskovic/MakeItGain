namespace FinAssist.PresentationLayer
{
    partial class frmViewExpenditureCategories
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
            this.button3 = new System.Windows.Forms.Button();
            this.txtSubCatPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdAddSubCategory = new System.Windows.Forms.Button();
            this.txtSubCatName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMainCatName = new System.Windows.Forms.TextBox();
            this.cmdAddMainCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSubCat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMainCat = new System.Windows.Forms.ListView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(251, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtSubCatPrice
            // 
            this.txtSubCatPrice.Location = new System.Drawing.Point(252, 68);
            this.txtSubCatPrice.Name = "txtSubCatPrice";
            this.txtSubCatPrice.Size = new System.Drawing.Size(64, 20);
            this.txtSubCatPrice.TabIndex = 4;
            this.txtSubCatPrice.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price:";
            // 
            // cmdAddSubCategory
            // 
            this.cmdAddSubCategory.Location = new System.Drawing.Point(14, 31);
            this.cmdAddSubCategory.Name = "cmdAddSubCategory";
            this.cmdAddSubCategory.Size = new System.Drawing.Size(183, 23);
            this.cmdAddSubCategory.TabIndex = 2;
            this.cmdAddSubCategory.Text = "Add new subcategory";
            this.cmdAddSubCategory.UseVisualStyleBackColor = true;
            // 
            // txtSubCatName
            // 
            this.txtSubCatName.Location = new System.Drawing.Point(75, 68);
            this.txtSubCatName.Name = "txtSubCatName";
            this.txtSubCatName.Size = new System.Drawing.Size(122, 20);
            this.txtSubCatName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSubCatPrice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmdAddSubCategory);
            this.groupBox2.Controls.Add(this.txtSubCatName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(220, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 108);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subcategories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cat. name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMainCatName);
            this.groupBox1.Controls.Add(this.cmdAddMainCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 108);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main categories";
            // 
            // txtMainCatName
            // 
            this.txtMainCatName.Location = new System.Drawing.Point(69, 68);
            this.txtMainCatName.Name = "txtMainCatName";
            this.txtMainCatName.Size = new System.Drawing.Size(113, 20);
            this.txtMainCatName.TabIndex = 5;
            // 
            // cmdAddMainCategory
            // 
            this.cmdAddMainCategory.Location = new System.Drawing.Point(11, 31);
            this.cmdAddMainCategory.Name = "cmdAddMainCategory";
            this.cmdAddMainCategory.Size = new System.Drawing.Size(171, 23);
            this.cmdAddMainCategory.TabIndex = 6;
            this.cmdAddMainCategory.Text = "Add new main category";
            this.cmdAddMainCategory.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cat.name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Subcategories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Main categories";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pred.def.price";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 216;
            // 
            // listSubCat
            // 
            this.listSubCat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listSubCat.FullRowSelect = true;
            this.listSubCat.Location = new System.Drawing.Point(220, 30);
            this.listSubCat.Name = "listSubCat";
            this.listSubCat.Size = new System.Drawing.Size(322, 193);
            this.listSubCat.TabIndex = 11;
            this.listSubCat.UseCompatibleStateImageBehavior = false;
            this.listSubCat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 156;
            // 
            // listMainCat
            // 
            this.listMainCat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listMainCat.FullRowSelect = true;
            this.listMainCat.Location = new System.Drawing.Point(24, 30);
            this.listMainCat.Name = "listMainCat";
            this.listMainCat.Size = new System.Drawing.Size(170, 193);
            this.listMainCat.TabIndex = 10;
            this.listMainCat.UseCompatibleStateImageBehavior = false;
            this.listMainCat.View = System.Windows.Forms.View.Details;
            // 
            // frmViewExpenditureCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 423);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listSubCat);
            this.Controls.Add(this.listMainCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewExpenditureCategories";
            this.Text = "Expenditure categories";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSubCatPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdAddSubCategory;
        private System.Windows.Forms.TextBox txtSubCatName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMainCatName;
        private System.Windows.Forms.Button cmdAddMainCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listSubCat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listMainCat;
    }
}
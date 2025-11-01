namespace Joshua_Ezcares_CRUD
{
    partial class Form1
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
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.txtCourse = new Guna.UI.WinForms.GunaTextBox();
            this.txtsearch = new Guna.UI.WinForms.GunaTextBox();
            this.seachbtn = new Guna.UI.WinForms.GunaButton();
            this.Addbtn = new Guna.UI.WinForms.GunaButton();
            this.updatebtn = new Guna.UI.WinForms.GunaButton();
            this.deletebtn = new Guna.UI.WinForms.GunaButton();
            this.dtview = new System.Windows.Forms.DataGridView();
            this.txtID = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.Location = new System.Drawing.Point(21, 239);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(339, 42);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtCourse
            // 
            this.txtCourse.BaseColor = System.Drawing.Color.White;
            this.txtCourse.BorderColor = System.Drawing.Color.Silver;
            this.txtCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourse.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCourse.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCourse.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCourse.Location = new System.Drawing.Point(21, 376);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PasswordChar = '\0';
            this.txtCourse.SelectedText = "";
            this.txtCourse.Size = new System.Drawing.Size(339, 42);
            this.txtCourse.TabIndex = 2;
            // 
            // txtsearch
            // 
            this.txtsearch.BaseColor = System.Drawing.Color.White;
            this.txtsearch.BorderColor = System.Drawing.Color.Silver;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsearch.Location = new System.Drawing.Point(22, 22);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(252, 42);
            this.txtsearch.TabIndex = 3;
            // 
            // seachbtn
            // 
            this.seachbtn.AnimationHoverSpeed = 0.07F;
            this.seachbtn.AnimationSpeed = 0.03F;
            this.seachbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.seachbtn.BorderColor = System.Drawing.Color.Black;
            this.seachbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.seachbtn.FocusedColor = System.Drawing.Color.Empty;
            this.seachbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seachbtn.ForeColor = System.Drawing.Color.White;
            this.seachbtn.Image = null;
            this.seachbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.seachbtn.Location = new System.Drawing.Point(281, 22);
            this.seachbtn.Name = "seachbtn";
            this.seachbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.seachbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.seachbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.seachbtn.OnHoverImage = null;
            this.seachbtn.OnPressedColor = System.Drawing.Color.Black;
            this.seachbtn.Size = new System.Drawing.Size(79, 42);
            this.seachbtn.TabIndex = 4;
            this.seachbtn.Text = "Search";
            this.seachbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seachbtn.Click += new System.EventHandler(this.seachbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.AnimationHoverSpeed = 0.07F;
            this.Addbtn.AnimationSpeed = 0.03F;
            this.Addbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Addbtn.BorderColor = System.Drawing.Color.Black;
            this.Addbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Addbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Image = null;
            this.Addbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.Addbtn.Location = new System.Drawing.Point(23, 436);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Addbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Addbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Addbtn.OnHoverImage = null;
            this.Addbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Addbtn.Size = new System.Drawing.Size(98, 42);
            this.Addbtn.TabIndex = 5;
            this.Addbtn.Text = "Add";
            this.Addbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.AnimationHoverSpeed = 0.07F;
            this.updatebtn.AnimationSpeed = 0.03F;
            this.updatebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.updatebtn.BorderColor = System.Drawing.Color.Black;
            this.updatebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updatebtn.FocusedColor = System.Drawing.Color.Empty;
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Image = null;
            this.updatebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.updatebtn.Location = new System.Drawing.Point(142, 436);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.updatebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updatebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.updatebtn.OnHoverImage = null;
            this.updatebtn.OnPressedColor = System.Drawing.Color.Black;
            this.updatebtn.Size = new System.Drawing.Size(101, 42);
            this.updatebtn.TabIndex = 6;
            this.updatebtn.Text = "Update";
            this.updatebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.AnimationHoverSpeed = 0.07F;
            this.deletebtn.AnimationSpeed = 0.03F;
            this.deletebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.deletebtn.BorderColor = System.Drawing.Color.Black;
            this.deletebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deletebtn.FocusedColor = System.Drawing.Color.Empty;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Image = null;
            this.deletebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deletebtn.Location = new System.Drawing.Point(265, 436);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.deletebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deletebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deletebtn.OnHoverImage = null;
            this.deletebtn.OnPressedColor = System.Drawing.Color.Black;
            this.deletebtn.Size = new System.Drawing.Size(96, 42);
            this.deletebtn.TabIndex = 7;
            this.deletebtn.Text = "Delete";
            this.deletebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // dtview
            // 
            this.dtview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtview.Location = new System.Drawing.Point(22, 73);
            this.dtview.Name = "dtview";
            this.dtview.Size = new System.Drawing.Size(338, 138);
            this.dtview.TabIndex = 9;
            this.dtview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtview_CellClick);
            // 
            // txtID
            // 
            this.txtID.BaseColor = System.Drawing.Color.White;
            this.txtID.BorderColor = System.Drawing.Color.Silver;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.Location = new System.Drawing.Point(21, 307);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(339, 42);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Course:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(384, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtview);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.seachbtn);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaTextBox txtCourse;
        private Guna.UI.WinForms.GunaTextBox txtsearch;
        private Guna.UI.WinForms.GunaButton seachbtn;
        private Guna.UI.WinForms.GunaButton Addbtn;
        private Guna.UI.WinForms.GunaButton updatebtn;
        private Guna.UI.WinForms.GunaButton deletebtn;
        private System.Windows.Forms.DataGridView dtview;
        private Guna.UI.WinForms.GunaTextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


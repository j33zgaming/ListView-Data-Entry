
namespace Data_Entry
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtStuNo = new System.Windows.Forms.TextBox();
			this.txtStuName = new System.Windows.Forms.TextBox();
			this.txtCourse = new System.Windows.Forms.TextBox();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnView = new System.Windows.Forms.Button();
			this.dgvStudent = new System.Windows.Forms.DataGridView();
			this.StuNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(146, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "DATA ENTRY";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(424, 41);
			this.panel1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(26, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Student #:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(106, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Student Name:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(278, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Course:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtStuNo
			// 
			this.txtStuNo.Location = new System.Drawing.Point(26, 80);
			this.txtStuNo.Name = "txtStuNo";
			this.txtStuNo.Size = new System.Drawing.Size(74, 20);
			this.txtStuNo.TabIndex = 0;
			// 
			// txtStuName
			// 
			this.txtStuName.Location = new System.Drawing.Point(106, 80);
			this.txtStuName.Name = "txtStuName";
			this.txtStuName.Size = new System.Drawing.Size(166, 20);
			this.txtStuName.TabIndex = 1;
			// 
			// txtCourse
			// 
			this.txtCourse.Location = new System.Drawing.Point(278, 80);
			this.txtCourse.Name = "txtCourse";
			this.txtCourse.Size = new System.Drawing.Size(120, 20);
			this.txtCourse.TabIndex = 2;
			// 
			// btnNew
			// 
			this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Location = new System.Drawing.Point(127, 110);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(86, 25);
			this.btnNew.TabIndex = 3;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.BtnNewClick);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(212, 110);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(86, 25);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.Location = new System.Drawing.Point(299, 161);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(99, 25);
			this.btnRemove.TabIndex = 6;
			this.btnRemove.Text = "Remove Record";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.BtnRemoveClick);
			// 
			// btnView
			// 
			this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnView.Location = new System.Drawing.Point(26, 161);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(99, 25);
			this.btnView.TabIndex = 5;
			this.btnView.Text = "View Record";
			this.btnView.UseVisualStyleBackColor = true;
			this.btnView.Click += new System.EventHandler(this.BtnViewClick);
			// 
			// dgvStudent
			// 
			this.dgvStudent.AllowUserToAddRows = false;
			this.dgvStudent.AllowUserToDeleteRows = false;
			this.dgvStudent.AllowUserToResizeColumns = false;
			this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
			this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.StuNo,
									this.StuName,
									this.Course});
			this.dgvStudent.Location = new System.Drawing.Point(26, 192);
			this.dgvStudent.Name = "dgvStudent";
			this.dgvStudent.ReadOnly = true;
			this.dgvStudent.RowHeadersVisible = false;
			this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStudent.Size = new System.Drawing.Size(372, 146);
			this.dgvStudent.StandardTab = true;
			this.dgvStudent.TabIndex = 7;
			// 
			// StuNo
			// 
			this.StuNo.HeaderText = "Student #";
			this.StuNo.Name = "StuNo";
			this.StuNo.ReadOnly = true;
			// 
			// StuName
			// 
			this.StuName.HeaderText = "Student Name";
			this.StuName.Name = "StuName";
			this.StuName.ReadOnly = true;
			this.StuName.Width = 169;
			// 
			// Course
			// 
			this.Course.HeaderText = "Course";
			this.Course.Name = "Course";
			this.Course.ReadOnly = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(424, 350);
			this.Controls.Add(this.dgvStudent);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.txtCourse);
			this.Controls.Add(this.txtStuName);
			this.Controls.Add(this.txtStuNo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Data Entry";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Course;
		private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
		private System.Windows.Forms.DataGridViewTextBoxColumn StuNo;
		private System.Windows.Forms.DataGridView dgvStudent;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.TextBox txtCourse;
		private System.Windows.Forms.TextBox txtStuName;
		private System.Windows.Forms.TextBox txtStuNo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}

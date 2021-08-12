using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Data_Entry
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();	
			
		}
		
		private void BtnNewClick(object sender, EventArgs e)
		{
			
       		txtStuNo.Clear();
        	txtStuName.Clear();
        	txtCourse.Clear();
        	txtStuNo.Focus();
        	
        	txtStuNo.Enabled = true;
        	txtStuName.Enabled = true;
        	txtCourse.Enabled = true;
        	btnNew.Enabled = false;
        	btnSave.Enabled = true;
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			 if (txtStuNo.Text == "" | txtStuName.Text == "" | txtCourse.Text == "")
			 	MessageBox.Show("Please provide complete student details.", "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
			 
			 else
        	{
				string StuNo = txtStuNo.Text;
        		string StuName = txtStuName.Text;
        		string Course = txtCourse.Text;
        		string[] row = { StuNo, StuName, Course };
        		dgvStudent.Rows.Add(row);
 				
            	txtStuNo.Enabled = false;
            	txtStuName.Enabled = false;
            	txtCourse.Enabled = false;
            	btnSave.Enabled = false;
            	btnNew.Enabled = true;
        	}
		}
		
		void BtnViewClick(object sender, EventArgs e)
		{
			dgvStudent.Refresh();
		}
		
		void BtnRemoveClick(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dgvStudent.SelectedRows)
			{
     			dgvStudent.Rows.RemoveAt(row.Index);
			}
        	MessageBox.Show("Record has been deleted.", "Remove Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}

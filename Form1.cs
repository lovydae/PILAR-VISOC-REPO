using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CRUDSYSTEM_SYSARCH
{
    public partial class Form1 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=\"D:\\download files\\CRUDSYSTEM_SYSARCH\\CRUDSYSTEM_SYSARCH\\CRUDSYSTEM_SYSARCH\\Database1.accdb\"";

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT 
                            d.DepartmentID, d.DepartmentName, d.DepartmentCode, d.IsActive AS DeptActive, 
                            c.CollegeID, c.CollegeName, c.CollegeCode, c.IsActive AS CollegeActive 
                         FROM Department d
                         INNER JOIN College c ON d.CollegeID = c.CollegeID";

                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCollegeID.Text) ||
                string.IsNullOrWhiteSpace(txtCollegeName.Text) ||
                string.IsNullOrWhiteSpace(txtCollegeCode.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentID.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentName.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentCode.Text))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbTransaction transaction = conn.BeginTransaction();

                try
                {
                    OleDbCommand checkCollegeCmd = new OleDbCommand("SELECT CollegeID FROM College WHERE CollegeID = @CollegeID", conn, transaction);
                    checkCollegeCmd.Parameters.AddWithValue("@CollegeID", txtCollegeID.Text);
                    object collegeExists = checkCollegeCmd.ExecuteScalar();

                    if (collegeExists == null)
                    {
                        OleDbCommand insertCollegeCmd = new OleDbCommand(@"
                            INSERT INTO College (CollegeID, CollegeName, CollegeCode, IsActive) 
                            VALUES (@CollegeID, @CollegeName, @CollegeCode, @IsActive)", conn, transaction);

                        insertCollegeCmd.Parameters.AddWithValue("@CollegeID", txtCollegeID.Text);
                        insertCollegeCmd.Parameters.AddWithValue("@CollegeName", txtCollegeName.Text);
                        insertCollegeCmd.Parameters.AddWithValue("@CollegeCode", txtCollegeCode.Text);
                        insertCollegeCmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);

                        insertCollegeCmd.ExecuteNonQuery();
                    }

                    OleDbCommand insertDepartmentCmd = new OleDbCommand(@"
                        INSERT INTO Department (DepartmentName, DepartmentCode, IsActive, CollegeID) 
                        VALUES (@DepartmentName, @DepartmentCode, @IsActive, @CollegeID)", conn, transaction);

                    insertDepartmentCmd.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text);
                    insertDepartmentCmd.Parameters.AddWithValue("@DepartmentCode", txtDepartmentCode.Text);
                    insertDepartmentCmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
                    insertDepartmentCmd.Parameters.AddWithValue("@CollegeID", txtCollegeID.Text);

                    insertDepartmentCmd.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Records successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbTransaction transaction = conn.BeginTransaction();

                try
                {
                    if (!string.IsNullOrWhiteSpace(txtCollegeID.Text))
                    {
                        string updateCollegeQuery = "UPDATE College SET CollegeName = ?, CollegeCode = ?, IsActive = ? WHERE CollegeID = ?";
                        OleDbCommand collegeCmd = new OleDbCommand(updateCollegeQuery, conn, transaction);
                        collegeCmd.Parameters.AddWithValue("@CollegeName", txtCollegeName.Text);
                        collegeCmd.Parameters.AddWithValue("@CollegeCode", txtCollegeCode.Text);
                        collegeCmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked ? 1 : 0);
                        collegeCmd.Parameters.AddWithValue("@CollegeID", txtCollegeID.Text);

                        collegeCmd.ExecuteNonQuery();
                    }

                    if (!string.IsNullOrWhiteSpace(txtDepartmentID.Text))
                    {
                        string updateDepartmentQuery = "UPDATE Department SET DepartmentName = ?, DepartmentCode = ?, CollegeID = ?, IsActive = ? WHERE DepartmentID = ?";
                        OleDbCommand deptCmd = new OleDbCommand(updateDepartmentQuery, conn, transaction);
                        deptCmd.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text);
                        deptCmd.Parameters.AddWithValue("@DepartmentCode", txtDepartmentCode.Text);
                        deptCmd.Parameters.AddWithValue("@CollegeID", txtCollegeID.Text);
                        deptCmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked ? 1 : 0);
                        deptCmd.Parameters.AddWithValue("@DepartmentID", txtDepartmentID.Text);

                        deptCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Records updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadData();
                dataGridView1.Refresh();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartmentID.Text) && string.IsNullOrWhiteSpace(txtCollegeID.Text))
            {
                MessageBox.Show("Select a record first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbTransaction transaction = conn.BeginTransaction();

                try
                {
                    if (!string.IsNullOrWhiteSpace(txtDepartmentID.Text))
                    {
                        string deleteDepartmentQuery = "DELETE FROM Department WHERE DepartmentID = ?";
                        OleDbCommand deptCmd = new OleDbCommand(deleteDepartmentQuery, conn, transaction);
                        deptCmd.Parameters.AddWithValue("@DepartmentID", txtDepartmentID.Text);
                        deptCmd.ExecuteNonQuery();
                    }

                    if (!string.IsNullOrWhiteSpace(txtCollegeID.Text))
                    {

                        string checkDepartmentsQuery = "SELECT COUNT(*) FROM Department WHERE CollegeID = ?";
                        OleDbCommand checkDeptCmd = new OleDbCommand(checkDepartmentsQuery, conn, transaction);
                        checkDeptCmd.Parameters.AddWithValue("@CollegeID", txtCollegeID.Text);
                        int departmentCount = (int)checkDeptCmd.ExecuteScalar();

                        if (departmentCount == 0)
                        {
                            string deleteCollegeQuery = "DELETE FROM College WHERE CollegeID = ?";
                            OleDbCommand collegeCmd = new OleDbCommand(deleteCollegeQuery, conn, transaction);
                            collegeCmd.Parameters.AddWithValue("@CollegeID", txtCollegeID.Text);
                            collegeCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Cannot delete College: Departments exist under it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadData();
                dataGridView1.Refresh();
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtCollegeID.Text = row.Cells["CollegeID"].Value?.ToString() ?? "";
                txtCollegeName.Text = row.Cells["CollegeName"].Value?.ToString() ?? "";
                txtCollegeCode.Text = row.Cells["CollegeCode"].Value?.ToString() ?? "";

                txtDepartmentID.Text = row.Cells["DepartmentID"].Value?.ToString() ?? "";
                txtDepartmentName.Text = row.Cells["DepartmentName"].Value?.ToString() ?? "";
                txtDepartmentCode.Text = row.Cells["DepartmentCode"].Value?.ToString() ?? "";

                bool isCollegeActive = row.Cells["CollegeActive"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["CollegeActive"].Value);
                bool isDeptActive = row.Cells["DeptActive"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["DeptActive"].Value);
                chkIsActive.Checked = isCollegeActive || isDeptActive;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCollegeID.Clear();
            txtCollegeName.Clear();
            txtCollegeCode.Clear();
            txtDepartmentID.Clear();
            txtDepartmentName.Clear();
            txtDepartmentCode.Clear();
        }
    }
}

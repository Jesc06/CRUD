using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Joshua_Ezcares_CRUD
{
    public partial class Form1 : Form
    {


        
        string connString = "Server=localhost;Database=stud;Uid=root;Pwd=joshuaesc;";
        int selected = -1;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            dtview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtview.MultiSelect = false;
            dtview.ReadOnly = true;
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM students ORDER BY id DESC";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtview.DataSource = dt;

                    dtview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private bool ValidateInputs()
        {

            string name = txtName.Text.Trim();
            string studentId = txtID.Text.Trim();
            string course = txtCourse.Text.Trim();


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(course))
            {
                MessageBox.Show("All fields (Name, Student ID, Course) are required.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Name can only contain letters and spaces.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(studentId, @"^[a-zA-Z0-9\-]+$"))
            {
                MessageBox.Show("Student ID can only contain letters, numbers, or dashes.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(course, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Course can only contain letters and spaces.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; 
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO students (name, student_id, course) VALUES (@name, @student_id, @course)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@student_id", txtID.Text);
                    cmd.Parameters.AddWithValue("@course", txtCourse.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student added successfully!");
                ClearInputs();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            
            if (selected < 0)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "UPDATE students SET name=@name, student_id=@student_id, course=@course WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@student_id", txtID.Text);
                    cmd.Parameters.AddWithValue("@course", txtCourse.Text);
                    cmd.Parameters.AddWithValue("@id", selected);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student updated successfully!");
                ClearInputs();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (selected < 0)
            {
                MessageBox.Show("Select a record to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "DELETE FROM students WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selected);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Student deleted successfully!");
                ClearInputs();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message);
            }
        }

        private void dtview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtview.Rows[e.RowIndex];
                selected = Convert.ToInt32(row.Cells["id"].Value);
                txtName.Text = row.Cells["name"].Value.ToString();
                txtID.Text = row.Cells["id"].Value.ToString();
                txtCourse.Text = row.Cells["course"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtID.Clear();
            txtCourse.Clear();
            selected = -1;
        }

        private void seachbtn_Click(object sender, EventArgs e)
        {
            string searchName = txtsearch.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM students WHERE name LIKE @search ORDER BY id DESC";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchName + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtview.DataSource = dt;
                dtview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}

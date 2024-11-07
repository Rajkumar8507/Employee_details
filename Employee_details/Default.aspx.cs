using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_details
{
    public partial class _Default : Page
    {
        // Connection string defined here
        private string connectionString = "Data Source=HEMANTH\\SQLEXPRESS2019;Initial Catalog=employee_details;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getemployeelist();
            }
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int empId = int.Parse(TextBox1.Text);
            int contact = int.Parse(TextBox4.Text);
            string empName = TextBox2.Text;
            string dob = TextBox3.Text;
            string gender = RadioButtonList1.SelectedValue;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Use parameterized query to prevent SQL injection
                    SqlCommand cmd = new SqlCommand("INSERT INTO Employee_details (EmpId, EmpName, DoB,Gender, Contact) VALUES (@EmpId, @EmpName, @DoB,@Gender, @Contact)", con);
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    cmd.Parameters.AddWithValue("@EmpName", empName);
                    cmd.Parameters.AddWithValue("@DoB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Contact", contact);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully saved.');", true);
                    getemployeelist();
                }
                catch (Exception ex)
                {
                    // Handle exception
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", $"alert('Error: {ex.Message}');", true);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            int empId = int.Parse(TextBox1.Text);
            int contact = int.Parse(TextBox4.Text);
            string empName = TextBox2.Text;
            string dob = TextBox3.Text;
            string gender = RadioButtonList1.SelectedValue;

            // Update logic can be implemented here
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Employee_details SET EmpName=@EmpName,DoB=@DoB,Gender=@Gender,Contact=@Contact WHERE EmpId=@EmpId", con);
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    cmd.Parameters.AddWithValue("@EmpName", empName);
                    cmd.Parameters.AddWithValue("@DoB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('successfully updated');", true);
                    getemployeelist();
                }

                catch (Exception ex1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", $"alert('Error:{ex1.Message}');", true);
                }

            }
        }


        void getemployeelist()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Employee_details", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle exception
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", $"alert('Error retrieving data: {ex.Message}');", true);
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int empId = int.Parse(TextBox1.Text);
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete Employee_details   WHERE EmpId=@EmpId", con);
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully deleted.');", true);
                    getemployeelist();
                }
                catch (Exception ex3)
                {
                    // Handle exception
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", $"alert('Error: {ex3.Message}');", true);
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



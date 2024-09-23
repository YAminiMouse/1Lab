using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1Lab
{
    public partial class Form1 : Form
    {
        string connectionString;

        SqlDataAdapter adapterDoctor;
        SqlDataAdapter adapterSpecialization;

        SqlCommandBuilder commandBuilderDoctor;
        SqlCommandBuilder commandBuilderSpecialization;

        DataSet dataSet;

        public Form1()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TestConnection"].ConnectionString;
            dataSet = new DataSet();

            adapterDoctor = new SqlDataAdapter("Select * from Doctor", connectionString);
            adapterSpecialization = new SqlDataAdapter("Select * from Specialization", connectionString);

            commandBuilderDoctor = new SqlCommandBuilder(adapterDoctor);
            commandBuilderSpecialization = new SqlCommandBuilder(adapterSpecialization);

            adapterDoctor.Fill(dataSet, "Doctor");
            adapterSpecialization.Fill(dataSet, "Specialization");

            dataGridViewDoctor.DataSource = dataSet.Tables["Doctor"];
            dataGridViewSpecialization.DataSource = dataSet.Tables["Specialization"];

            FillSpecializationDoctorCombobox();
        }

        private void FillSpecializationDoctorCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewDoctor.Columns["specialization_id"]).DataSource = 
                dataSet.Tables["Specialization"];
            ((DataGridViewComboBoxColumn)dataGridViewDoctor.Columns["specialization_id"]).DisplayMember = 
                "Name";
            ((DataGridViewComboBoxColumn)dataGridViewDoctor.Columns["specialization_id"]).ValueMember =
                "Id";

        }

        private void buttonSaveDoctor_Click(object sender, EventArgs e)
        {
            adapterDoctor.Update(dataSet, "Doctor");
        }

        private void buttonSaveSpecialization_Click(object sender, EventArgs e)
        {
            adapterSpecialization.Update(dataSet, "Specialization");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("GetVisits", sqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@startDate", SqlDbType.Date));
                sqlDataAdapter.SelectCommand.Parameters["@startDate"].Value = dateTimePicker1.Value;

                sqlDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@endDate", SqlDbType.Date));
                sqlDataAdapter.SelectCommand.Parameters["@endDate"].Value = dateTimePicker2.Value;

                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds, "report2");
                dataGridViewReport2.DataSource = ds.Tables["report2"];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string start = textBox1.Text;
            string end = textBox2.Text;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(
                    $"SELECT Doctor.Name as ФИО_Врача, COUNT(Visiting.doctor_id) AS Количество_посещений, Specialization.Name AS Специальность " +
                    $"FROM Visiting " +
                    $"JOIN Doctor ON Visiting.doctor_id = Doctor.Id " +
                    $"JOIN Specialization ON Doctor.specialization_id = Specialization.Id " +
                    $"WHERE Visiting.Date > '{start}' AND Visiting.Date < '{end}' " +
                    $"GROUP BY Doctor.Name, Specialization.Name",
                    sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                DataTable dataTable = new DataTable("report2");
                dataTable.Columns.Add("ФИО_Врача");
                dataTable.Columns.Add("Кол-во посещений");
                dataTable.Columns.Add("Специальность");

                while (sqlDataReader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["ФИО_Врача"] = sqlDataReader["ФИО_врача"];
                    row["Кол-во посещений"] = sqlDataReader["Количество_посещений"];
                    row["Специальность"] = sqlDataReader["Специальность"];
                    dataTable.Rows.Add(row);
                }

                sqlDataReader.Close();

                dataGridViewReport1.DataSource = dataTable;
            }
        }
    }
}
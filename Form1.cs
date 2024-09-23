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
    }
}

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
        }

        private void buttonSaveDoctor_Click(object sender, EventArgs e)
        {
            adapterDoctor.Update(dataSet, "Doctor");
        }

        private void buttonSaveSpecialization_Click(object sender, EventArgs e)
        {
            adapterSpecialization.Update(dataSet, "Specialization");
        }
    }
}

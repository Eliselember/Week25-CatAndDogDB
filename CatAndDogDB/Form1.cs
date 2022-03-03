﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatAndDogDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CatAndDogDB.Properties.Settings.PetsConnectionString"].ConnectionString;
        }

        private void PopulatePetsTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PetType", connection))
            {
                DataTable petTable = new DataTable();
                adapter.Fill(petTable);

                listPets.DisplayMember = "PetTypeName";
                listPets.ValueMember = "Id";
                listPets.DataSource = petTable;
            }
        }
        private void PopulatePetName()
        {
            string query = "SELECT Pet.Name FROM PetType INNER JOIN Pet ON Pet.TypeId = PetType.Id WHERE PetType.Id = @TypeId;";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
              command.Parameters.AddWithValue("@TypeId", listPets.SelectedValue);
                DataTable petNameTable = new DataTable();
                adapter.Fill(petNameTable);

                listPetName.DisplayMember = "Name";
                listPetName.ValueMember = "Id";
                listPetName.DataSource = petNameTable;
            }
        }

        private void listPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePetName();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulatePetsTable();
        }
    }
}

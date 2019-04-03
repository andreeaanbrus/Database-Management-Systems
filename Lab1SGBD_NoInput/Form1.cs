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

namespace Lab1SGBD_NoInput
{
    public partial class Form1 : Form
    {
        SqlConnection dbConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MovieRental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        DataSet ds = new DataSet();
        private int movieID = 0;
        private SqlCommandBuilder sqlcb;
        private SqlDataAdapter dataAdapterGenres, dataAdapterMovies;
        BindingSource bindingSourceVideos, bindingSourceGenres;
        public Form1()
        {
            InitializeComponent();
            populateGenres();
            populateVideos();
        }

        private void updateDB_Click(object sender, EventArgs e)
        {
            sqlcb = new SqlCommandBuilder(dataAdapterMovies);
            dataAdapterMovies.Update(ds, "Videos");
        }

        public void populateGenres()
        {
            dataAdapterGenres = new SqlDataAdapter("SELECT * FROM Genres", dbConnection);
            dataAdapterGenres.Fill(ds, "Genres");
            bindingSourceGenres = new BindingSource();
            bindingSourceGenres.DataSource = ds;
            bindingSourceGenres.DataMember = "Genres";
            dataGridGenres.DataSource = bindingSourceGenres;
        }

        public void populateVideos()
        {

            dataAdapterMovies = new SqlDataAdapter("SELECT * FROM Videos", dbConnection);
            dataAdapterMovies.Fill(ds, "Videos");
            DataRelation dataRelation = new DataRelation("FK_Videos_Genres", ds.Tables["Genres"].Columns["genreID"], ds.Tables["Videos"].Columns["genreId"]);
            ds.Relations.Add(dataRelation);
            bindingSourceVideos = new BindingSource();
            bindingSourceVideos.DataSource = bindingSourceGenres;
            bindingSourceVideos.DataMember = "FK_Videos_Genres";

            dataGridVideos.DataSource = bindingSourceVideos;
        }

    }
}

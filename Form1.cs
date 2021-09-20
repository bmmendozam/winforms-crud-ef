using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winforms_crud_ef.Modelos; 


namespace winforms_crud_ef
{
	public partial class Form1 : Form
	{
    StudentInformationEntities1 db = new StudentInformationEntities1();
    StudentDetails TablaStudent = new StudentDetails();
    bool nuevo = false;
    int id;

    public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
      Display();   // calling Display Method for Bind the Student Details in Datagridview  
    }

    public void Display() {    
       var post = db.StudentDetails.Select(p => new { p.Id, p.Name });
      dataGridViewM.AutoGenerateColumns = false;
      dataGridViewM.DataSource = post.ToList(); 

        //esta linea funciona solita
        dataGridView1.DataSource = db.StudentDetails.ToList <StudentDetails>();
    }

    public void ClearData()
    {
      txtciudad.Text = txtciudad.Text = txtedad.Text = txtnombres.Text = txtgenero.Text = string.Empty;
      btnborrar.Enabled = false;
  //    btngrabar.Text = "Agregar Nuevo";
    }

    private void btnnuevo_Click(object sender, EventArgs e)
    {
      ClearData();
      nuevo = true;
      btnborrar.Enabled = false;
    }

    private void btngrabar_Click(object sender, EventArgs e)
		{
      try
      {
        TablaStudent.Name = txtnombres.Text;
        TablaStudent.Age = Convert.ToInt32(txtedad.Text);
        TablaStudent.City = txtciudad.Text;
        TablaStudent.Gender = txtgenero.Text;

        if (nuevo)
        {
          db.StudentDetails.Add(TablaStudent);
        }
        else {
          db.Entry(TablaStudent).State = System.Data.Entity.EntityState.Modified;
        }
          db.SaveChanges();
          ClearData();
          Display();
          MessageBox.Show("Registro grabado satisfactoriamiente");
      }
      catch { 

      }
		}

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
      if (dataGridView1.CurrentCell.RowIndex != -1) { 
        id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
        TablaStudent = db.StudentDetails.Where(x => x.Id  == id).FirstOrDefault();
        txtgenero.Text = TablaStudent.Gender;
        txtnombres.Text = TablaStudent.Name;
        txtedad.Text = TablaStudent.Age.ToString();
        txtciudad.Text = TablaStudent.City;
        txtid.Text = TablaStudent.Id.ToString(); 
      }
      btngrabar.Text = "Actualizar";
      btnborrar.Enabled = true;
    }

		private void btnborrar_Click(object sender, EventArgs e)
		{
      if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        db.StudentDetails.Remove(TablaStudent);
        db.SaveChanges();
        ClearData();
        Display();
        MessageBox.Show("Record Deleted Successfully");
      }
    }
	}
}

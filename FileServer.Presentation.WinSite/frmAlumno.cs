using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileServer.Common.Model;
using FileServer.Insfrastructure.Repository;
using FileServer.Insfrastructure.Repository.Repositories;

namespace FileServer.Presentation.WinSite
{
  public partial class frmAlumno : Form
  {
		IAlumnoRepository iAlumnoRepository;

    public frmAlumno()
    {
      InitializeComponent();
      iAlumnoRepository = new AlumnoRepository();
    }

    private void btn_Afegir_Click(object sender, EventArgs e)
    {
			string dbFile = Properties.Settings.Default.PathFitxer + "\\" +
				              Properties.Settings.Default.NomFitxer;
      try { 
				Alumno alumne = new Alumno(IdAlumno	 :	Convert.ToInt32(txtBox_CodiClient.Text),
					                         Nombre		 : txtBox_Nom.Text,
					                         Apellidos : txtBox_Cognoms.Text,
					                         Dni			 : txtBox_Dni.Text);

				iAlumnoRepository.Add(alumne, dbFile);

        MessageBox.Show ("Registre afegit a la DB!");
      }
      catch (Exception ex) {
        Console.WriteLine(ex.Message);
      }
    }
  }
}

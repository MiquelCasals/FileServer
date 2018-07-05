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
using log4net;

namespace FileServer.Presentation.WinSite
{
  public partial class frmAlumno : Form
  {
		private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		IAlumnoRepository iAlumnoRepository;

    public frmAlumno()
    {
			log.Info("Inici constructor");
			InitializeComponent();
      iAlumnoRepository = new AlumnoRepository();
			log.Info("Final constructor");
    }

    private void btn_Afegir_Click(object sender, EventArgs e)
    {
			log.Info("Inici btn_Afegir_Click");
			//string dbFile = Properties.Settings.Default.PathFitxer + "\\" +
			//	              Properties.Settings.Default.NomFitxer;
      try { 
				Alumno alumne = new Alumno(IdAlumno	 :	Convert.ToInt32(txtBox_CodiClient.Text),
					                         Nombre		 : txtBox_Nom.Text,
					                         Apellidos : txtBox_Cognoms.Text,
					                         Dni			 : txtBox_Dni.Text);

				iAlumnoRepository.Add(alumne);

        MessageBox.Show ("Registre afegit a la DB!");
				log.Info("Alumne: " + alumne.ID.ToString() + alumne.Nombre + " afegit.");
      }
      catch (Exception ex) {
				log.Error("Error al fer el Add del alumne: ", ex);
      }
			log.Info("Final btn_Afegir_Click");
    }
  }
}

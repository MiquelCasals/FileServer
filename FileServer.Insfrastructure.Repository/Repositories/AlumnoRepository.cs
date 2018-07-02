using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileServer.Common.Model;
using Newtonsoft.Json;
using System.IO;
using System.Configuration;

namespace FileServer.Insfrastructure.Repository.Repositories
{
	public class AlumnoRepository : IAlumnoRepository
	{
		/// <summary>
		/// Afegeix un alumne al srxiu JSON
		/// </summary>
		/// <param name="alumno"></param>
		/// <returns>El Alumne inserit o null si no coincideix</returns>
		public Alumno Add(Alumno alumno)
		{
			Alumno alumneAdded = null;
      StreamWriter sw = null;
			// Llegim la variable del App.Config que ens indica el nom del arxiu on gravarem el alumne
			string dbFile = ConfigurationManager.AppSettings.Get("Path");

			try {
				// Serialitzem el alumne en format json
				string json = JsonConvert.SerializeObject(alumno);
				// Si no existeix el arxiu de DB el creem
				if (FileManager.CreateFile(dbFile)) {
					// Gravem el alumne a la DB
					sw = new StreamWriter(dbFile, true);
					sw.WriteLine(json);
					// A partir del string del json composo una nova instància alumne
					alumneAdded = JsonConvert.DeserializeObject<Alumno>(json);
				}
      }
      catch (Exception ex) {
        Console.WriteLine(ex.Message);
      }
      finally {
        if (sw != null) sw.Close();
      }
			return(alumneAdded);
		}
	}
}

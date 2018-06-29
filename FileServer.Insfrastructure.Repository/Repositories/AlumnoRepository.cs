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
		public Alumno Add( Alumno alumno, string dbFile )
		{
			Alumno alumneAdded = null;
      StreamWriter sw = null;
			string dbFile1 = ConfigurationManager.AppSettings.Get("Path");

			try {
				// Serialitzem el alumne en format json
				string json = JsonConvert.SerializeObject(alumno);
				// Gravem el alumne a la DB
        sw = new StreamWriter(dbFile1, true);
        sw.WriteLine(json);
				// A partir del string del json composo una nova instància alumne
        alumneAdded = JsonConvert.DeserializeObject<Alumno>(json);
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

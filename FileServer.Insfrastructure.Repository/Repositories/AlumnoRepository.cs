using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileServer.Common.Model;
using Newtonsoft.Json;
using System.IO;

namespace FileServer.Insfrastructure.Repository.Repositories
{
	public class AlumnoRepository : IAlumnoRepository
	{
		private Object lockObject = new Object();
		/// <summary>
		/// Constructor.
		/// Comprovem si el fitxer de DB existeix i sino el crea.
		/// </summary>
		public AlumnoRepository()
		{
			// Si el fitxer de la DB no existeix el creem
			if (!FileManager.Exist()) {
				FileManager.Create();
			}
		}
		/// <summary>
		/// Afegeix un alumne al arxiu JSON
		/// </summary>
		/// <param name="alumno"></param>
		/// <returns>El Alumne inserit o null si no coincideix</returns>
		public Alumno Add(Alumno alumno)
		{
			Alumno alumneAdded = null;

			try {
				// Serialitzem el alumne en format json
				string json = JsonConvert.SerializeObject(alumno);
				// Gravem el alumne a la DB. 
				// Utilitzem el Lock per a fer-lo thread save
				lock (lockObject)
				{
					FileManager.Write(json);
					// Cal llegir el alumne insertat en el arxiu
					alumneAdded = GetLastAlumno();
				}
      }
      catch (Exception ex) {
        Console.WriteLine(ex.Message);
      }
			return(alumneAdded);
		}

		/// <summary>
		/// Obtenim el últim alumne afegit al fitxer DB
		/// </summary>
		/// <returns></returns>
		public Alumno GetLastAlumno()
		{
			Alumno lastAlumne = null;
			string json = String.Empty;

			// Llegeixo el últim registre i el serialitzo 
			json = FileManager.ReadLast();
			// A partir del string del json composo una nova instància alumne
			lastAlumne = JsonConvert.DeserializeObject<Alumno>(json);

			return (lastAlumne);
		}
	}
}

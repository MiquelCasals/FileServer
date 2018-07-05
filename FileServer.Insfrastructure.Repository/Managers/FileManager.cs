using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FileServer.Insfrastructure.Repository.Repositories
{
	/// <summary>
	/// Classe responsable de crear el fitxer de text
	/// </summary>
	public static class FileManager
	{
		public static string PathName { get; set; }

		/// <summary>
		/// Constructor static
		/// </summary>
		static FileManager()
		{
			// Llegim la variable del App.Config que ens indica el nom del arxiu que farem servir de DB
			PathName = 	ConfigurationManager.AppSettings.Get("Path");
		}

		public static bool Exist()
		{
			return(File.Exists(PathName));
		}
		// Els mètodes statics no es poden crear en interfaces.
		//
		/// <summary>
		/// Creem el arxiu
		/// </summary>
		/// <returns></returns>
		public static bool Create()
		{
			bool fitxerCreat = false;

			try {
				fitxerCreat = (File.Create(PathName) != null);
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
				throw;
			}
			return(fitxerCreat);
		}

		/// <summary>
		/// Escriu en el fitxer
		/// </summary>
		/// <param name="buffer">string a escriure al fitxer</param>
		/// <returns></returns>
		public static bool Write(string buffer)
		{
			bool ok = false;

			// Gravem el alumne a la DB
			using (StreamWriter sw = new StreamWriter(PathName, true))
			{
				try {
					sw.WriteLine(buffer);
					ok = true;
				}
				catch (Exception ex) {
					ok = false;
					throw;
				}
			}
			return(ok);
		}
		/// <summary>
		/// Reads the last record of the file.
		/// </summary>
		/// <returns></returns>
		public static string ReadLast()
		{
			string ultimRegistre = String.Empty;

			// Obtenim el últim registre del fitxer
			using (StreamReader sr = new StreamReader(PathName))
			{
				do {
					ultimRegistre = sr.ReadLine();
				}
				while (!sr.EndOfStream);
			}
			return(ultimRegistre);
		}

	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Insfrastructure.Repository.Repositories
{
	/// <summary>
	/// Classe responsable de crear el fitxer de text
	/// </summary>
	public class FileManager
	{
		// Els mètodes statics no es poden crear en interfaces.
		//
		public static bool CreateFile(string Path)
		{
			bool fitxerCreat = false;

			try {
				if (!File.Exists(Path)) {
					fitxerCreat = (File.Create(Path) != null);
				}
				else {
					fitxerCreat = true;
				}
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
			return(fitxerCreat);
		}
	}
}

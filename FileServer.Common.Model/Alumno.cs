using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Common.Model
{
	public class Alumno
	{
		/// <summary>
		/// Identificador
		/// </summary>
		public int ID { get; set; }
		/// <summary>
		/// Nom del alumne
		/// </summary>
		public string Nombre { get; set; }
		/// <summary>
		/// Cognoms del alumne
		/// </summary>
		public string Apellidos { get; set; }
		/// <summary>
		/// Document Nacional d'Identitat
		/// </summary>
		public string DNI { get; set; }

		public Alumno()
		{

		}
		/// <summary>
		/// Constructor 2
		/// </summary>
		public Alumno (int IdAlumno, string Nombre, string Apellidos, string Dni)
		{
			this.ID					= IdAlumno;
			this.Nombre			= Nombre;
			this.Apellidos	= Apellidos;
			this.DNI				= Dni;
		}
		/// <summary>
		/// Equals: ens permet comparar classes Alumno
		/// </summary>
		/// <param name="obj">Objecte amb el que comparar</param>
		/// <returns>Si compleixen el patró de igualtat. En el nostre cas, si tenen el mateix ID</returns>
		public override bool Equals(object obj)
		{
			var alumne = obj as Alumno;
			var sonIguals = false;

			if (alumne != null) {
				sonIguals = (this.ID.Equals(alumne.ID));
			}
			return(sonIguals);
		}

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <returns>
		/// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
		/// </returns>
		public override int GetHashCode()
		{
			// Buscar a Google com implementar-ho.
			return(this.ID.GetHashCode());
		}

	}
}

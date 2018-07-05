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
		public override bool Equals( object obj )
		{
			var alumno = obj as Alumno;
			return (alumno    != null &&
						  ID        == alumno.ID &&
						  Nombre    == alumno.Nombre &&
						  Apellidos == alumno.Apellidos &&
						  DNI       == alumno.DNI);
		}

		/// <summary>
		/// GetHashCode
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			var hashCode = 287315274;
			hashCode = hashCode * -1521134295 + ID.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DNI);
			return hashCode;
		}

	}
}

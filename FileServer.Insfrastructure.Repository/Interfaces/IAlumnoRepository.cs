using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileServer.Common.Model;

namespace FileServer.Insfrastructure.Repository
{
	/// <summary>
	/// 
	/// </summary>
	public interface IAlumnoRepository
	{
		/// <summary>
		/// Afegim un alumne al arxiu json
		/// </summary>
		/// <param name="alumno">Alumne a inserir</param>
		/// <returns>El Alumne inserit</returns>
		Alumno Add(Alumno alumno);
	}
}

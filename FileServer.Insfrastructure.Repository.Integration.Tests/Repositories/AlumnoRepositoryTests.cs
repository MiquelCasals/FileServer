using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileServer.Insfrastructure.Repository.Repositories;
using FileServer.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Insfrastructure.Repository.Repositories.Tests
{
	[TestClass()]
	public class AlumnoRepositoryTests
	{
		readonly IAlumnoRepository iAlumnoRepository = new AlumnoRepository();

    Alumno alumne = new Alumno { ID = 1, Nombre = "Miquel", Apellidos = "Casals Barbany", DNI = "00000000T" };
		string dbFile = @"C:\Projectes\NET\FileServer\DB\Alumnes.Json";

		[TestMethod]
		public void AddTest()
		{
			Assert.IsTrue(iAlumnoRepository.Add(alumne, dbFile).Equals(alumne));
		}
	}
}
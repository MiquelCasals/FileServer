using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileServer.Insfrastructure.Repository.Repositories;
using FileServer.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace FileServer.Insfrastructure.Repository.Repositories.Tests
{
	[TestClass()]
	public class AlumnoRepositoryTests
	{
    private IAlumnoRepository mockObject;

		Alumno alumne = new Alumno { ID = 1, Nombre = "Miquel", Apellidos = "Casals Barbany", DNI = "00000000T" };

    [TestInitialize]
    public void Setup()
    {
      var mock = new Mock<IAlumnoRepository>();      

      mock.Setup(x => x.Add(alumne)).Returns(alumne);
      
      mockObject = mock.Object;
    }

		[TestMethod()]
		public void AddTest()
		{
      var result = mockObject.Add(alumne);
      Assert.AreEqual(alumne,result);
		}
	}
}
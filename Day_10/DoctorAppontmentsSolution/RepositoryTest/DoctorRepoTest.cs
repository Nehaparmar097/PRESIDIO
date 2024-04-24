using DoctorsAppontmentModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorAppointmentDALLibrary;
using DoctorsAppontmentModelLibrary;

namespace RepositoryTest
{
    public class DoctorRepTests
    {
        private DoctorRep repository;

        [SetUp]
        public void Setup()
        {
            repository = new DoctorRep();
        }

        [Test]
        public void Add_NewDoctor_ReturnsDoctor()
        {
            var doctor = new Doctor { DoctorName = "neha", Specialization = "cardio" };
            var result = repository.Add(doctor);
            Assert.IsNotNull(result);
            Assert.AreEqual(doctor, result);
        }

        [Test]
        public void Add_DuplicateDoctor_ReturnsNull()
        {
            var doctor1 = new Doctor { DoctorName = "neha", Specialization = "cardio" };
            repository.Add(doctor1);
            var result = repository.Add(doctor1);
            Assert.IsNull(result);
        }

        [Test]
        public void Delete_ExistingDoctor_ReturnsDeletedDoctor()
        {
            var doctor = new Doctor { DoctorName = "neha", Specialization = "cardio" };
            repository.Add(doctor);
            var result = repository.Delete(doctor.Id);
            Assert.IsNotNull(result);
            Assert.AreEqual(doctor, result);
        }

        [Test]
        public void Delete_NonExistingDoctor_ReturnsNull()
        {
            var result = repository.Delete(999);
            Assert.IsNull(result);
        }

        [Test]
        public void Get_ExistingDoctor_ReturnsDoctor()
        {
            var doctor = new Doctor { DoctorName = "neha", Specialization = "cardio" };
            repository.Add(doctor);
            var result = repository.Get(doctor.Id);
            Assert.IsNotNull(result);
            Assert.AreEqual(doctor, result);
        }

        [Test]
        public void Get_NonExistingDoctor_ReturnsNull()
        {
            var result = repository.Get(999);
            Assert.IsNull(result);
        }

        [Test]
        public void Update_ExistingDoctor_ReturnsUpdatedDoctor()
        {
            var doctor = new Doctor { DoctorName = "neha", Specialization = "cardio" };
            repository.Add(doctor);
            var updatedDoctor = new Doctor { Id = doctor.Id, DoctorName = "shailu", Specialization = "mbbs" };
            var result = repository.Update(updatedDoctor);
            Assert.IsNotNull(result);
            Assert.AreEqual(updatedDoctor, result);
        }

        [Test]
        public void Update_NonExistingDoctor_ReturnsNull()
        {
            var doctor = new Doctor { DoctorName = "neha", Specialization = "cardio" };
            var result = repository.Update(doctor);
            Assert.IsNull(result);
        }
    }
}

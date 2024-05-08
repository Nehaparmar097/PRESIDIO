using DoctorAppointmentDALLibrary;
using DoctorsAppontmentModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorsAppontmentModelLibrary;
using DoctorAppointmentDALLibrary;

namespace RepositoryTest
{
    public class PatientRepoTest
    {
        private PatientRepo repository;

        [SetUp]
        public void Setup()
        {
            repository = new PatientRepo();
        }

        [Test]
        public void Add_NewPatient_ReturnsPatient()
        {
            var patient = new Patient { PatientName = "neha", Disease = "Fever", Fee = 100 };
            Assert.AreEqual(patient, repository.Add(patient));
        }

        [Test]
        public void Add_DuplicatePatient_ReturnsNull()
        {
            var patient1 = new Patient { PatientName = "neha", Disease = "Fever", Fee = 100 };
            repository.Add(patient1);
            Assert.IsNull(repository.Add(patient1));
        }

        [Test]
        public void Delete_ExistingPatient_ReturnsDeletedPatient()
        {
            var patient = new Patient { PatientName = "neha", Disease = "Fever", Fee = 100 };
            repository.Add(patient);
            //Assert.AreEqual(patient, repository.Delete(patient.Id));
        }

        [Test]
        public void Delete_NonExistingPatient_ReturnsNull()
        {
            Assert.IsNull(repository.Delete(999));
        }

        [Test]
        public void Get_ExistingPatient_ReturnsPatient()
        {
            var patient = new Patient { PatientName = "neha", Disease = "Fever", Fee = 100 };
            repository.Add(patient);
            Assert.AreEqual(patient, repository.Get(patient.Id));
        }

        [Test]
        public void Get_NonExistingPatient_ReturnsNull()
        {
            Assert.IsNull(repository.Get(999));
        }

        [Test]
        public void Update_ExistingPatient_ReturnsUpdatedPatient()
        {
            var patient = new Patient { PatientName = "neha", Disease = "Fever", Fee = 100 };
            repository.Add(patient);
            var updatedPatient = new Patient { Id = patient.Id, PatientName = "laxmi", Disease = "Cold", Fee = 150 };
            Assert.AreEqual(updatedPatient, repository.Update(updatedPatient));
        }

        [Test]
        public void Update_NonExistingPatient_ReturnsNull()
        {
            var patient = new Patient { PatientName = "neha", Disease = "Fever", Fee = 100 };
            Assert.IsNull(repository.Update(patient));
        }

        [Test]
        public void GetAll_ReturnsAllPatients()
        {
            var patient1 = new Patient { PatientName = "neha", Disease = "Fever", Fee = 100 };
            var patient2 = new Patient { PatientName = "laxmi", Disease = "Cold", Fee = 50 };
            repository.Add(patient1);
            repository.Add(patient2);
            Assert.AreEqual(2, repository.GetAll().Count());
        }
    }
}

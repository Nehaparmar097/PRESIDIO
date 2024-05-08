using DoctorAppointmentDALLibrary;
using DoctorsAppontmentModelLibrary;

namespace RepositoryTest
{
    public class CreateAppointmentTests
    {

        private AppointmentRepo repository;

        [SetUp]
        public void Setup()
        {
            repository = new AppointmentRepo();
        }

        [Test]
        public void Add_NewAppointment_ReturnsAppointment()
        {
            // Arrange
            var appointment = new Appointments("Hospital");

            // Act
            var result = repository.Add(appointment);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(appointment, result);
        }

        [Test]
        public void Add_DuplicateAppointment_ReturnsNull()
        {
            // Arrange
            var appointment1 = new Appointments("Hospital");
            repository.Add(appointment1); 

            // Act
            var result = repository.Add(appointment1);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void Delete_ExistingAppointment_ReturnsDeletedAppointment()
        {
            // Arrange
            var appointment = new Appointments("Hospital");
            repository.Add(appointment); 

            // Act
            var result = repository.Delete(appointment.Id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(appointment, result);
        }

        [Test]
        public void Delete_NonExistingAppointment_ReturnsNull()
        {
            // Act
            var result = repository.Delete(999); 

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void Get_ExistingAppointment_ReturnsAppointment()
        {
            // Arrange
            var appointment = new Appointments("Hospital");
            repository.Add(appointment); 

            // Act
            var result = repository.Get(appointment.Id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(appointment, result);
        }

        [Test]
        public void Get_NonExistingAppointment_ReturnsNull()
        {
            // Act
            var result = repository.Get(999); 

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void Update_ExistingAppointment_ReturnsUpdatedAppointment()
        {
            // Arrange
            var appointment = new Appointments("Hospital");
            repository.Add(appointment); 

            var updatedAppointment = new Appointments("Clinic");
            updatedAppointment.Id = appointment.Id;

            // Act
            var result = repository.Update(updatedAppointment);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(updatedAppointment, result);
        }

        [Test]
        public void Update_NonExistingAppointment_ReturnsNull()
        {
            // Arrange
            var appointment = new Appointments("Hospital");

            // Act
            var result = repository.Update(appointment); 

            // Assert
            Assert.IsNull(result);
        }
    }


    }
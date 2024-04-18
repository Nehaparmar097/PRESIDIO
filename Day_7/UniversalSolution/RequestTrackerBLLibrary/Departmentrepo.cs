using requestTrackerLibrary;
using RequestTrackerDALLibrary;
namespace RequestTrackerBLLibrary
{

    public class Departmentrepo : IDepartmentService
    {   //read only making cud operation with int and Department named it as _departmentRepository
        readonly IRepository<int, Department> _departmentRepository;
        public Departmentrepo()
        {
            _departmentRepository = new DepartmentRepository();
        }

        public int AddDepartment(Department department)
        {
            var result = _departmentRepository.Add(department);

            if (result != null)
            {
                return result.Id;
            }
            throw new DuplicateDepartmentNameException();
        }

        public Department ChangeDepartmentName(string departmentOldName, string departmentNewName)
        {
          
                try
                {
                   
                    Department department = GetDepartmentByName(departmentOldName);
                    if (department == null)
                    {
                    throw new DepartmentNotFoundException();
                    }
                    department.Name = departmentNewName;

                    // upadet i call from dal repo
                    _departmentRepository.Update(department);

                   
                    return department;
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine($"Error occurred while changing department name: {ex.Message}");
                    throw;
                }
            

        }

        public Department GetDepartmentById(int id)
        {
            Department department = _departmentRepository.Get(id);

            // Check if department is found
            if (department != null)
            {
                return department;
            }
            else
            {
                throw new DepartmentNotFoundException();
            }
        }

        public Department GetDepartmentByName(string departmentName)
        {
            Department department = _departmentRepository.Find(d => ((Department)d).Name == departmentName);

         
            if (department != null)
            {
                return department;
            }
            else
            {
                throw new DepartmentNotFoundException();
            }
        }

        

        public List<Department> GetDepartmentList()
        {
            throw new NotImplementedException();
        }

    }
}

using System;
namespace DapExc1
{
	public interface IDepartmentRepository
	{
		public IEnumerable<Department> GetAllDepartments();
		public void InsertDepartment(string newDepartmentName);
	}
}


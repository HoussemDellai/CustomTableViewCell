using Foundation;
using System;
using UIKit;

namespace CustomTableApp3
{
    public partial class EmployeeTableCell : UITableViewCell
    {
        public EmployeeTableCell (IntPtr handle) : base (handle)
        {
        }

		internal void UpdateCell(Employee employee)
		{

			FullnameLabel.Text = employee.Fullname;

			DepartmentLabel.Text = employee.Department;

			DescriptionLabel.Text = employee.Description;
		}
    }
}
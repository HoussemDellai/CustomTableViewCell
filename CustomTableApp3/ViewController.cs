using System;
using System.Collections.Generic;
using UIKit;

namespace CustomTableApp3
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var employees = new List<Employee>
			{
				
				new Employee
				{
					Fullname = "Ahmed",
					Department = "Finance",
					Description = "Controlling expenditures and obligations (including operating expenses, debt, payroll) receipting and depositing all revenues"
				},
				new Employee
				{
					Fullname = "Khaled",
					Department = "Accounting",
					Description = "Recording and reporting the cash flow transactions of a company"
				},
				new Employee
				{
					Fullname = "Hassen",
					Department = "Legal",
					Description = "Contract management, real estate transactions, customer claims against the company for product damages and defects, litigation, employment law"
				},
				new Employee
				{
					Fullname = "Nader",
					Department = "Marketing",
					Description = "Create an overarching image that represents your company in a positive light"
				},
				new Employee
				{
					Fullname = "Seif",
					Department = "Sales",
					Description = "Engage in a variety of activities with the objective to promote the customer purchase of a product"
				},
				new Employee
				{
					Fullname = "Adam",
					Department = "HR",
					Description = "Responsible for payroll, hiring and firing of employees, explaining and handling benefits"
				},
			};

			EmployeesTableView.Source = new EmployeesTVS(employees);

			EmployeesTableView.RowHeight = UITableView.AutomaticDimension;
			EmployeesTableView.EstimatedRowHeight = 40f;
			EmployeesTableView.ReloadData();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

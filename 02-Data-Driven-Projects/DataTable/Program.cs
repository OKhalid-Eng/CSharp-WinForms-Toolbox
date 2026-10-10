using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create DataTable (in-memory tabular structure)
            DataTable EmployeeDatatable = new DataTable();

            // Define columns
            EmployeeDatatable.Columns.Add("ID", typeof(int));
            EmployeeDatatable.Columns.Add("Name", typeof(string));
            EmployeeDatatable.Columns.Add("Salary", typeof(double));
            EmployeeDatatable.Columns.Add("Country", typeof(string));
            EmployeeDatatable.Columns.Add("Date", typeof(DateTime));

            // Add rows (data records)
            EmployeeDatatable.Rows.Add(1, "Omar Khalid", 10000, "Egypt", DateTime.Now);
            EmployeeDatatable.Rows.Add(2, "Yusuf Khalid", 90000, "Egypt", DateTime.Now);
            EmployeeDatatable.Rows.Add(3, "Anas Khalid", 80000, "Jordan", DateTime.Now);
            EmployeeDatatable.Rows.Add(4, "Ashraf Khalid", 8000, "palestine", DateTime.Now);
            EmployeeDatatable.Rows.Add(5, "Mohamed Khalid", 800, "Tonis", DateTime.Now);

            // Variables for statistics
            int EmployeeCount = 0;
            double AvgSalary = 0;
            double TotalSalary = 0;
            double MaxSalary = 0;
            double MinSalary = 0;

            // Count employees
            EmployeeCount = EmployeeDatatable.Rows.Count;

            // Aggregate functions using Compute
            TotalSalary = Convert.ToDouble(EmployeeDatatable.Compute("SUM(Salary)", string.Empty));
            AvgSalary = Convert.ToDouble(EmployeeDatatable.Compute("AVG(Salary)", string.Empty));
            MaxSalary = Convert.ToDouble(EmployeeDatatable.Compute("Max(Salary)", string.Empty));
            MinSalary = Convert.ToDouble(EmployeeDatatable.Compute("Min(Salary)", string.Empty));

            Console.WriteLine("\nEmployee List\n");

            // Display all rows
            foreach (DataRow RowItem in EmployeeDatatable.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Salary: {2} \t Country: {3} \t Date: {4} ",
                    RowItem["ID"], RowItem["Name"], RowItem["Salary"], RowItem["Country"], RowItem["Date"]);
            }

            Console.WriteLine("\n\nExtra Info:\n");

            Console.WriteLine("Total Number of Employee is: " + EmployeeCount);
            Console.WriteLine("Total Salary of Employee is: " + TotalSalary);
            Console.WriteLine("Average Salary of Employee is: " + AvgSalary);
            Console.WriteLine("Max Salary is: " + MaxSalary);
            Console.WriteLine("Min Salary is: " + MinSalary);

            // Filter data using Select
            DataRow[] ResultRow = EmployeeDatatable.Select("Country='Egypt'");

            Console.WriteLine("\nEmployees Where Country = 'Egypt'\n");

            foreach (DataRow RowItem in ResultRow)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Salary: {2} \t Country: {3} \t Date: {4} ",
                    RowItem["ID"], RowItem["Name"], RowItem["Salary"], RowItem["Country"], RowItem["Date"]);
            }

            // Statistics for filtered data
            EmployeeCount = ResultRow.Count();
            TotalSalary = Convert.ToDouble(EmployeeDatatable.Compute("SUM(Salary)", "Country='Egypt'"));
            AvgSalary = Convert.ToDouble(EmployeeDatatable.Compute("AVG(Salary)", "Country='Egypt'"));
            MaxSalary = Convert.ToDouble(EmployeeDatatable.Compute("Max(Salary)", "Country='Egypt'"));
            MinSalary = Convert.ToDouble(EmployeeDatatable.Compute("Min(Salary)", "Country='Egypt'"));

            Console.WriteLine("\n\nExtra Info Where Country = 'Egypt':\n");

            Console.WriteLine("Total Number of Employee is: " + EmployeeCount);
            Console.WriteLine("Total Salary of Employee is: " + TotalSalary);
            Console.WriteLine("Average Salary of Employee is: " + AvgSalary);
            Console.WriteLine("Max Salary is: " + MaxSalary);
            Console.WriteLine("Min Salary is: " + MinSalary);

            // Multi-condition filter
            ResultRow = EmployeeDatatable.Select("Country='Egypt' or Country= 'Jordan'");

            Console.WriteLine("\nEmployees Where Country = 'Egypt' or 'Jordan'\n");

            foreach (DataRow RowItem in ResultRow)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Salary: {2} \t Country: {3} \t Date: {4} ",
                    RowItem["ID"], RowItem["Name"], RowItem["Salary"], RowItem["Country"], RowItem["Date"]);
            }

            // Sorting using DefaultView (descending by ID)
            EmployeeDatatable.DefaultView.Sort = "ID Desc";

            // Convert view back to DataTable
            EmployeeDatatable = EmployeeDatatable.DefaultView.ToTable();

            Console.WriteLine("\nEmployees List Sorted by ID desc\n");

            foreach (DataRow RowItem in EmployeeDatatable.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Salary: {2} \t Country: {3} \t Date: {4} ",
                    RowItem["ID"], RowItem["Name"], RowItem["Salary"], RowItem["Country"], RowItem["Date"]);
            }

            // Sort by Name ascending
            EmployeeDatatable.DefaultView.Sort = "Name ASC";
            EmployeeDatatable = EmployeeDatatable.DefaultView.ToTable();

            Console.WriteLine("\nEmployees List Sorted by Name ASC\n");

            foreach (DataRow RowItem in EmployeeDatatable.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Salary: {2} \t Country: {3} \t Date: {4} ",
                    RowItem["ID"], RowItem["Name"], RowItem["Salary"], RowItem["Country"], RowItem["Date"]);
            }

            // Delete employee with ID = 4
            Console.WriteLine("\n\nEmployees List After Deleting ID = 4 :\n");

            DataRow[] Restults = EmployeeDatatable.Select("ID=4");

            foreach (var RecordRow in Restults)
            {
                RecordRow.Delete();
            }

            EmployeeDatatable.AcceptChanges();

            Console.WriteLine("\nEmployees List After Delete ID = 4\n");

            foreach (DataRow RecordRow in EmployeeDatatable.Rows)
            {
                Console.WriteLine(" ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ",
                    RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
            }

            // Update employee where ID = 5
            Restults = EmployeeDatatable.Select("ID=5");

            foreach (var RecordRow in Restults)
            {
                RecordRow["Name"] = "Samy Ashref";
                RecordRow["Salary"] = 1200;
            }

            Console.WriteLine("\nEmployees List After Update ID = 5\n");

            foreach (DataRow RecordRow in EmployeeDatatable.Rows)
            {
                Console.WriteLine(" ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ",
                    RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);
            }

            // Clear all data
            EmployeeDatatable.Clear();

            // Set primary key
            DataColumn[] PrimaryKeyColumn = new DataColumn[1];
            PrimaryKeyColumn[0] = EmployeeDatatable.Columns["ID"];
            EmployeeDatatable.PrimaryKey = PrimaryKeyColumn;

            // Re-add rows
            EmployeeDatatable.Rows.Add(1, "Omar Khalid", 10000, "Egypt", DateTime.Now);
            EmployeeDatatable.Rows.Add(2, "Yusuf Khalid", 90000, "Egypt", DateTime.Now);
            EmployeeDatatable.Rows.Add(3, "Anas Khalid", 80000, "Jordan", DateTime.Now);
            EmployeeDatatable.Rows.Add(4, "Ashraf Khalid", 8000, "palestine", DateTime.Now);
            EmployeeDatatable.Rows.Add(5, "Mohamed Khalid", 800, "Tonis", DateTime.Now);

            Console.WriteLine("\nEmployee List\n");

            foreach (DataRow RowItem in EmployeeDatatable.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Salary: {2} \t Country: {3} \t Date: {4} ",
                    RowItem["ID"], RowItem["Name"], RowItem["Salary"], RowItem["Country"], RowItem["Date"]);
            }

            // Second DataTable with manual column definitions
            DataTable EmployeeDatatable2 = new DataTable();

            DataColumn dtColumn;

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);
            dtColumn.ColumnName = "ID";
            dtColumn.AutoIncrement = true;
            dtColumn.AutoIncrementSeed = 1;
            dtColumn.AutoIncrementStep = 1;
            dtColumn.Caption = "Employee ID";
            dtColumn.ReadOnly = true;
            EmployeeDatatable2.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Name";
            EmployeeDatatable2.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(double);
            dtColumn.ColumnName = "Salary";
            EmployeeDatatable2.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Country";
            EmployeeDatatable2.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(DateTime);
            dtColumn.ColumnName = "Date";
            EmployeeDatatable2.Columns.Add(dtColumn);

            // Primary key
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = EmployeeDatatable2.Columns["ID"];
            EmployeeDatatable2.PrimaryKey = PrimaryKeyColumns;

            // Add rows (auto increment ID)
            EmployeeDatatable2.Rows.Add(null, "Omar Khalid", 10000, "Egypt", DateTime.Now);
            EmployeeDatatable2.Rows.Add(null, "Yusuf Khalid", 90000, "Egypt", DateTime.Now);
            EmployeeDatatable2.Rows.Add(null, "Anas Khalid", 80000, "Jordan", DateTime.Now);
            EmployeeDatatable2.Rows.Add(null, "Ashraf Khalid", 8000, "palestine", DateTime.Now);
            EmployeeDatatable2.Rows.Add(null, "Mohamed Khalid", 800, "Tonis", DateTime.Now);

            Console.WriteLine("\nEmployee List\n");

            foreach (DataRow RowItem in EmployeeDatatable2.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Salary: {2} \t Country: {3} \t Date: {4} ",
                    RowItem["ID"], RowItem["Name"], RowItem["Salary"], RowItem["Country"], RowItem["Date"]);
            }

            // DataView (live view over DataTable)
            DataView EmployeesDataView1 = EmployeeDatatable2.DefaultView;

            // Display DataView
            for (int i = 0; i < EmployeesDataView1.Count; i++)
            {
                Console.WriteLine("\n\n{0}, {1}, {2}, {3}",
                    EmployeesDataView1[i][0], EmployeesDataView1[i][1],
                    EmployeesDataView1[i][2], EmployeesDataView1[i][3]);
            }

            // Filter using DataView
            EmployeesDataView1.RowFilter = "Country ='Egypt' or Country ='Jordan'";

            Console.WriteLine("\n\nEmployees list from dataview after filtering 'Jordan or Egypt':");

            for (int i = 0; i < EmployeesDataView1.Count; i++)
            {
                Console.WriteLine("\n\n{0}, {1}, {2}, {3}",
                    EmployeesDataView1[i][0], EmployeesDataView1[i][1],
                    EmployeesDataView1[i][2], EmployeesDataView1[i][3]);
            }

            // Sort using DataView
            EmployeesDataView1.Sort = "Name ASC";

            Console.WriteLine("\n\nEmployees list from dataview after Sorting 'Name ASC':");

            for (int i = 0; i < EmployeesDataView1.Count; i++)
            {
                Console.WriteLine("\n\n{0}, {1}, {2}, {3}",
                    EmployeesDataView1[i][0], EmployeesDataView1[i][1],
                    EmployeesDataView1[i][2], EmployeesDataView1[i][3]);
            }


            // Same Result

            /*
            foreach (DataRowView row in EmployeesDataView1)
            {
                Console.WriteLine("\n\n{0}, {1}, {2}, {3}",
                    row["ID"],
                    row["Name"],
                    row["Salary"],
                    row["Country"]);
            }
            */


            DataTable EmployeesDataTable = new DataTable("EmployeesDataTable");
            EmployeesDataTable.Columns.Add("ID", typeof(int));
            EmployeesDataTable.Columns.Add("Name", typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary", typeof(Double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            //Add rows 
            EmployeesDataTable.Rows.Add(1, "Mohammed Abu-Hadhoud", "Jordan", 5000, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "Ali Maher", "KSA", 525.5, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "Lina Kamal", "Jordan", 730.5, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "Fadi JAmeel", "Egypt", 800, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "Omar Mahmoud", "Lebanon", 7000, DateTime.Now);


            Console.WriteLine("\nEmployees List:\n");

            foreach (DataRow RecordRow in EmployeesDataTable.Rows)
            {
                //Using Field Name
                Console.WriteLine("ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ",
                    RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"],
                    RecordRow["Date"]);

            }


            DataTable DepartmentsDataTable = new DataTable("DepartmentsDataTable");
            DepartmentsDataTable.Columns.Add("DepartmentID", typeof(int));
            DepartmentsDataTable.Columns.Add("Name", typeof(string));

            //Add rows 
            DepartmentsDataTable.Rows.Add(1, "Marketing");
            DepartmentsDataTable.Rows.Add(2, "IT");
            DepartmentsDataTable.Rows.Add(3, "HR");


            Console.WriteLine("\nDepartments List:\n");

            foreach (DataRow RecordRow in DepartmentsDataTable.Rows)
            {

                //Using Field Name
                Console.WriteLine("DepartmentID: {0}\t Name : {1} ",
                    RecordRow["DepartmentID"], RecordRow["Name"]);

            }

            //Create Dataset
            DataSet dataSet1 = new DataSet();

            //Adding DataTables into DataSet
            dataSet1.Tables.Add(EmployeesDataTable);
            dataSet1.Tables.Add(DepartmentsDataTable);

            Console.WriteLine("\nPrinting Employees Data form the Dataset\n");
            foreach (DataRow RecordRow in dataSet1.Tables["EmployeesDataTable"].Rows)
            {
                //Using Field Name
                Console.WriteLine("ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ",
                    RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"],
                    RecordRow["Date"]);
            }

            Console.WriteLine("\nPrinting Departments Data form the Dataset\n");
            foreach (DataRow RecordRow in dataSet1.Tables["DepartmentsDataTable"].Rows)
            {
                //Using Field Name
                Console.WriteLine("DepartmentID: {0}\t Name : {1} ",
                    RecordRow["DepartmentID"], RecordRow["Name"]);
            }


        }
    }
}
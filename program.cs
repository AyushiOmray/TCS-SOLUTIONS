using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		List<Department> departments = new List<Department>
            {
                new Department(){DepartmentID=1,DepartmentName="EEE",Location="Mumbai" },
                new Department(){ DepartmentID = 2, DepartmentName = "ECE", Location = "Chennai" },
                new Department(){ DepartmentID = 3, DepartmentName = "CSE", Location = "Mumbai" },
                new Department(){ DepartmentID = 4, DepartmentName = "IT", Location = "Chennai" },

            };
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("Priya", 23, 1));
            studentList.Add(new Student("Madhu", 25, 2));
            studentList.Add(new Student("Asha", 24, 1));
            studentList.Add(new Student("Arpit", 23, 1));
            studentList.Add(new Student("Bhavik", 25, 4));
            studentList.Add(new Student("Kamala", 23, 2));

            int choice = Convert.ToInt32(Console.ReadLine());

		//1.View All
		if(choice==1){
		PrintAllStudent(departments,studentList);
		}
		else if(choice==2){
			    string n=Console.ReadLine();
                int a=Convert.ToInt32(Console.ReadLine());
                string dn=Console.ReadLine();
                string dloc=Console.ReadLine();
                int id=0;
                foreach(Department d in departments){
                  if(d.Dname==dn){
                      id=d.DId;
                      break;
                  }
                }

                if(a<18){
                    Console.WriteLine(n+" is too young to join");
                }
                else if(a>25){
                   Console.WriteLine(n+" is too old to join");
                }
                else{
				//Max Student strength
				int res=countException(departments,studentList,dn);
					if(res==0){Console.WriteLine("Limit Exceeded Can't Add Students");}
					else{
                int flag=0;
                foreach(Department d in departments){
                    if(d.Dname==dn){
                        flag=1;
                        break;
                    }
                }
                if(flag==0){
                    Console.WriteLine("Department does not exist");
                }
                else{
                studentList.Add(new Student(n, a, id));
                Console.WriteLine(n+" has been added successfully");
					PrintAllStudent(departments,studentList);
				 }
				}
				}
		}

	}

	static void PrintAllStudent(List<Department> Departments,List<Student> Studentlist)
		{
			foreach(Student std in Studentlist){
				string d="smh";
				string l="smh";
				foreach(Department dep in Departments ){
					if(dep.DId==std.Sdep){
						d=dep.Dname;
						l=dep.Dloc;
			           Console.WriteLine(std.Sname+"("+std.Sage+") - Department: "+d+","+l);
					}
				}
			}
		}

	static int countException(List<Department> Departments,List<Student> Studentlist,string d)
	{
		int count=0;
		int did=0;

		foreach(Department dep in Departments){
		if(d==dep.Dname){
		did=dep.DId;
			break;
		}
		}

		foreach(Student stu in Studentlist)
		{
			if(stu.Sdep==did){count++;}
		}
		if(count>=3){
		return 0;
		}
		return 1;
	}

	class Department
	{
		public int DepartmentID;
		public string DepartmentName;
		public string Location;

		public int DId{
		get{return DepartmentID;}
		set{DepartmentID=value;}
		}

		public string Dname{
		get{return DepartmentName;}
		set{DepartmentName=value;}
		}

		public string Dloc{
		get{return Location;}
		set{Location=value;}
		}
	}

	class Student
	{
		string sname;
		int sage;
		int sdep;

		public Student(string name,int age,int dep){
		    this.sname=name;
			this.sage=age;
			this.sdep=dep;
		}

		public string Sname{
		get{return sname;}
		set{sname=value;}
		}

		public int Sage{
		get{return sage;}
		set{sage=value;}
		}

		public int Sdep{
		get{return sdep;}
		set{sdep=value;}
		}
	}

}

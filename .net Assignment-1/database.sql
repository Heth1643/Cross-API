select D.DeptName,count(e.EmpId),Sum(e.Salary) from Employee1 e inner join Department1 D on e.DeptId=D.Id group by D.DeptName;

SELECT *from Employee1;

SELECT *from Department1;

DELETE from department1 WHERE Id between  33 and 35;

select D.DeptName,count(e.EmpId)as 'Employee',Sum(e.Salary)as 'Total' from Employee1 e inner join Department1 D on e.DeptId=D.Id group by D.DeptName,e.EmpId,e.Salary;


select *, D.DeptName,count(e.EmpId)as 'Employee',Sum(e.Salary)as 'Total' from Employee1 e inner join Department1 D on e.DeptId=D.Id group by D.DeptName,e.EmpId,e.DeptId,e.EmpName,e.Salary,D.Id

SELECT *from Department1;

select *from Employee;




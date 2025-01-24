namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic Ex : SWAP
            //int A = 4;
            //int B = 5;

            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //Console.WriteLine("*********After SWAP************");

            //Healper.SWAP( ref A, ref B );

            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //double L = 1.4;
            //double K = 2.5;

            //Console.WriteLine($"L = {L}");
            //Console.WriteLine($"K = {K}");

            //Console.WriteLine("*********After SWAP************");

            //Healper.SWAP(ref L, ref K);

            //Console.WriteLine($"L = {L}");
            //Console.WriteLine($"K = {K}");

            //Point P01 = new Point(1, 1);
            //Point P02 = new Point(2, 2);

            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");

            //Console.WriteLine("*********After SWAP************");

            //Healper.SWAP(ref P01, ref P02);

            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");

            /*****************************************/

            //int A = 4;
            //int B = 5;

            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //Console.WriteLine("*********After SWAP************");

            //Healper.SWAP(ref A, ref B);

            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //double L = 1.4;
            //double K = 2.5;

            //Console.WriteLine($"L = {L}");
            //Console.WriteLine($"K = {K}");

            //Console.WriteLine("*********After SWAP************");

            //Healper.SWAP(ref L, ref K);

            //Console.WriteLine($"L = {L}");
            //Console.WriteLine($"K = {K}");

            //Point P01 = new Point(1, 1);
            //Point P02 = new Point(2, 2);

            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}");

            //Console.WriteLine("*********After SWAP************");

            //Healper/*<T>*/.SWAP(ref P01, ref P02);

            //Console.WriteLine($"P01 = {P01}");
            //Console.WriteLine($"P02 = {P02}"); 
            #endregion

            #region Generic EX : LinnerSearch

            //int[] Numbers = { 11, 21, 3, 4, 5, -1, 6, 7, 8 };

            //int index =Healper.LinnerSearch(Numbers, 21);

            //index = Healper.LinnerSearch(Numbers, -1);



            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 22, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 21, Salary = 11000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Mona", Age = 24, Salary = 13000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mohemed", Age = 23, Salary = 15000 };

            //Employee[] employees = { E01, E02, E03, E04 };

            //index = Healper.LinnerSearch(employees, E03);

            //Console.WriteLine($"index = {index}"); 
            #endregion

            #region Equality in class or struct
            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 22, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 1, Name = "Ahmed", Age = 22, Salary = 12000 };
            ////Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 21, Salary = 11000 };

            ////if (E01.Equals(E02))
            ////    Console.WriteLine("E01 = E02");
            ////else Console.WriteLine("E01 != E02");

            //if (E01==(E02))
            //    Console.WriteLine("E01 = E02");
            //else Console.WriteLine("E01 != E02"); 
            #endregion

            #region Generic Ex: BubbleSort
            //int[] Numbers = { 1, 7, 8, 5, 4, 0, 6, 9, 25, 12, 96, 14 };
            //Healper.Print(Numbers);
            //Console.WriteLine();
            //Healper.BubbleSort(Numbers);
            //Healper.Print(Numbers);

            //Point[] points =
            //{
            //    new Point(4,4),
            //    new Point(1,1),
            //    new Point(5,5),
            //    new Point(2,2),
            //    new Point(6,6),
            //    new Point(3,3),

            //};

            //Healper.BubbleSort(points);
            //Healper.Print(points);
            //Console.WriteLine(points); 
            #endregion


            #region is Ans as Operators
            //Point p01 = new Point(4, 4);
            //Point p02 = new Point(1, 1);

            ////if (p01.CompareTo(p02) > 0)
            ////    Console.WriteLine("P01>P02");
            ////else Console.WriteLine("P01<P02");

            //if (p01.CompareTo("Ahmed") > 0)
            //    Console.WriteLine("P01>P02");
            //else Console.WriteLine("P01<P02"); 
            #endregion

            // Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 22, Salary = 12000 };
            //// Employee E02 = new Employee() { Id = 1, Name = "Ahmed", Age = 22, Salary = 12000 };
            // Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 21, Salary = 11000 };

            // if (E01.Equals(null))
            //     Console.WriteLine("E01 = E02");
            // else Console.WriteLine("E01 != E02");

            // //if (E01 == (E02))
            // //    Console.WriteLine("E01 = E02");
            // //else Console.WriteLine("E01 != E02");



            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 22, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 21, Salary = 11000 };
            //Employee E03 = new Employee() { Id = 3, Name = "Mona", Age = 24, Salary = 13000 };
            //Employee E04 = new Employee() { Id = 4, Name = "Mohemed", Age = 23, Salary = 15000 };

            //Employee[] employees = { E01, E02, E03, E04 };

            //Healper.Print(employees);
            ////Healper.BubbleSort(employees,new EmployeeComparerSalary());
            //Healper.BubbleSort(employees, new EmployeeComparerSalary());
            //int index = Healper.LinnerSearch<Employee>(employees, new Employee() { Name = "Mona" }, new EmployeeEquatableComparerName());

            //Console.WriteLine($"index = {index}");

        }  
    }
}

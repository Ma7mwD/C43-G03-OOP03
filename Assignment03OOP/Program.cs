﻿namespace Assignment03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            //Question 1: What is the primary purpose of an interface in C#?
            // b) To define a blueprint for a class

            //Question 2: Which of the following is NOT a valid access modifier for interface members in C#?
            // a) private, 

            //Question 3: Can an interface contain fields in C#?
            // b) No

            //Question 4: In C#, can an interface inherit from another interface?
            // b) Yes, interfaces can inherit from multiple interfaces

            //Question 5: Which keyword is used to implement an interface in a class in C#?
            // d) implements

            //Question 6: Can an interface contain static methods in C#?
            // a) Yes

            //Question 7: In C#, can an interface have explicit access modifiers for its members?
            // b) No, all members are implicitly public

            //Question 8: What is the purpose of an explicit interface implementation in C#?
            // b) To provide a clear separation between interface and class members

            //Question 9: In C#, can an interface have a constructor?
            // d) Only if the constructor is static

            //Question 10: How can a C# class implement multiple interfaces?
            // c) By separating interface names with commas
            #endregion


            #region Part 02
                
            ICircle circle = new ICircle();
            IRectangle rectangle = new IRectangle();

            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();

            #endregion
        }
    }
}

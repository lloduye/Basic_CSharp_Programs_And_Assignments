using System;

//Create an Employee class
public class Employee
{
    //Class properties with FirstName, LastName and Id
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //overload an operator with == to check if two employee
    //objects are equal by comparing their ID property.
    public static bool operator == (Employee a, Employee b)
    {
        bool status = false;
        if (a.Id == b.Id)
        {
            status = true;
        }
        return status;
    }

    //Checking if the two id properties are not equal
    public static bool operator != (Employee a, Employee b)
    {
        bool status = false;
        if (a.Id != b.Id)
        {
            status = true;
        }
        return status;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRepositoryPattern.Business_Layer;
using VendorRepositoryPattern.Data_Access_Layer;

namespace VendorRepositoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendorBusiness vendorbusiness = new VendorBusiness(new VendorRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'R' for Record, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "R")
                    {
                        List<Vendor> _listVendor = vendorbusiness.Get();
                        Console.WriteLine("Directory of Vendor:");
                        Console.WriteLine("ID   |   Name     |  Address");
                        foreach (Vendor _Vendor in _listVendor)
                        {
                            Console.WriteLine(_Vendor.ID + "  |   " + _Vendor.Name + "  |   " + _Vendor.Address);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a ID to find a Vendor:");
                        string ID = Console.ReadLine();
                        Vendor ven = vendorbusiness.Get(Convert.ToInt32(ID));
                        Console.WriteLine(ven.ID + ". " + ven.Name + " -- " + ven.Address);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a ID:");
                        string ID = Console.ReadLine();
                        Console.WriteLine("Input a Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a Address:");
                        string address = Console.ReadLine();
                        Vendor ven = new Vendor();
                        ven.ID = Convert.ToInt32(ID);
                        ven.Name = name;
                        ven.Address = address;
                        bool isExecuted = vendorbusiness.Add(ven);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added Successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to Add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a ID:");
                        string ID = Console.ReadLine();
                        Console.WriteLine("Input a Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a Address:");
                        string address = Console.ReadLine();
                        Vendor ven = new Vendor();
                        ven.ID = Convert.ToInt32(ID);
                        ven.Name = name;
                        ven.Address = address;
                        bool isExecuted = vendorbusiness.Update(ven);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated Successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to Update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a ID:");
                        string id = Console.ReadLine();
                        bool isExecuted = vendorbusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted Successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to Delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            Console.Read();
        }
    }
}

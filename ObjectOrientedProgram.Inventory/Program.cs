// See https://aka.ms/new-console-template for more information
using ObjectOrientedProgram.Inventory;

const string INVENTORY_DATA_FILE_PATH = @"D:\Bridgelabs\ObjectOrientedProgram.Inventory\ObjectOrientedProgram.Inventory\Inventorymanagement\Inventor.json";
 {
        Console.WriteLine(" Inventory Management Programme ");
        
        Inventory inventory = new Inventory();
        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);

 }

/// See https://aka.ms/new-console-template for more information
using ObjectOrientedProgram.Inventory;
using ObjectOrientedProgram.Inventory.InventoryManagementProgram;
using ObjectOrientedProgram.Inventory.StockManagement;

const string INVENTORY_DATA_FILE_PATH = @"D:\Bridgelabs\ObjectOrientedProgram.Inventory\ObjectOrientedProgram.Inventory\Inventorymanagement\Inventor.json";
const string INVENTORYDETAILS_DATA_FILE_PATH = @"D:\Bridgelabs\ObjectOrientedProgram.Inventory\ObjectOrientedProgram.Inventory\InventoryManagementProgram\Json.file";
const string STOCKDETAILS_DATA_FILE_PATH = @"D:\Bridgelabs\ObjectOrientedProgram.Inventory\ObjectOrientedProgram.Inventory\StockManagement\Stock.json";
while (true)
{
    {
        Console.WriteLine("1) Inventory Management Programme \n 2) InventoryManagementSystem \n 3) StockManagement ");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Inventory inventory = new Inventory();
                inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                break;
            //Uc_2 for Json Assignment
            case 2:
                //const string INVENTORYDETAILS_DATA_FILE_PATH = @"D:\Bridgelabs\ObjectOrientedProgram.Inventory\ObjectOrientedProgram.Inventory\InventoryManagementProgram\Json.file";
                InventoryFactory inventoryFactory = new InventoryFactory();
                inventoryFactory.ReadJsonFile(INVENTORYDETAILS_DATA_FILE_PATH);
                InventoryDetails details = new InventoryDetails()

                {
                    Name = "a",
                    Weight = 5,
                    Price = 25
                };
                inventoryFactory.AddInventory("WheatList", details);
                //inventoryFactory.DeleteInventory("WheatList", "a");
                inventoryFactory.WriteTojson(INVENTORYDETAILS_DATA_FILE_PATH);
                break;
            case 3:
                //UC3_Problem
                //const string STOCKDETAILS_DATA_FILE_PATH = @"D:\Bridgelabs\ObjectOrientedProgram.Inventory\ObjectOrientedProgram.Inventory\StockManagement\Stock.json";
                Stock stock = new Stock();
                stock.ReadJsonFile(STOCKDETAILS_DATA_FILE_PATH);
                break;
        }

    }

}


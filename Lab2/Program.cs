namespace Lab2;

internal abstract class Program
{
    private static void Main()
    {
        IItemFactory standardFactory = new StandardItemFactory();

        var inventory = new Inventory();

        var manager = new InventoryManager(standardFactory);

        manager.AddWeaponToInventory(inventory);
        manager.AddArmorToInventory(inventory);
        manager.AddPotionToInventory(inventory);

        inventory.ShowInventory();

        inventory.UseItem("Обычный меч");
        inventory.UseItem("Зелье лечения");

        manager.AddWeaponToInventory(inventory);

        inventory.Upgrade("Обычный меч");

        inventory.ShowInventory();

        inventory.UseItem("Обычный меч");
    }
}

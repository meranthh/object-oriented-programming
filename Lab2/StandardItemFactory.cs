namespace Lab2;

public class StandardItemFactory : IItemFactory
{
    public Weapon CreateWeapon()
    {
        return new WeaponBuilder()
            .SetName("Обычный меч")
            .SetDamage(30)
            .SetDescription("Простой меч.")
            .Build();
    }

    public Armor CreateArmor()
    {
        return new ArmorBuilder()
            .SetName("Обычная броня")
            .SetDefense(20)
            .SetOverview("Простая кожаная броня.")
            .Build();
    }

    public Potion CreatePotion()
    {
        return new PotionBuilder()
            .SetName("Зелье лечения")
            .SetEffect("Восстанавливает 50 здоровья.")
            .SetOverview("Простое зелье.")
            .Build();
    }
}
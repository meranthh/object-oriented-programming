namespace Lab2;

public class EnhancedItemFactory : IItemFactory
{
    public Weapon CreateWeapon()
    {
        return new WeaponBuilder()
            .SetName("Улучшенный меч")
            .SetDamage(70)
            .SetDescription("Меч с магической силой.")
            .Build();
    }

    public Armor CreateArmor()
    {
        return new Armor
        {
            Name = "Улучшенная броня",
            Defense = 50,
            Overview = "Кованая стальная броня с магическими свойствами.",
        };
    }

    public Potion CreatePotion()
    {
        return new Potion
        {
            Name = "Зелье великого лечения",
            Effect = "Восстанавливает 200 здоровья.",
            Overview = "Мощное зелье для восстановления.",
        };
    }
}

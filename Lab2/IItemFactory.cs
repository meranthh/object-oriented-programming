namespace Lab2;

public interface IItemFactory
{
    Weapon CreateWeapon();

    Armor CreateArmor();

    Potion CreatePotion();
}

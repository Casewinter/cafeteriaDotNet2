namespace Menu.Models;

public class MenuModel
{
    public MenuModel(string name, string typeOfProduct, string description, float price, bool vegan, float weight = 0, string photo = "")
    {
        id = Guid.NewGuid();
        Name = name;
        TypeOfProduct = typeOfProduct;
        Description = description;
        Price = price;
        Weight = weight;
        Vegan = vegan;
        Active = true;
        Photo = photo;
    }

    public Guid id { get; init; }
    public string Name { get; private set; }
    public string TypeOfProduct { get; private set; }
    public float Price { get; private set; }
    public string Description { get; private set; }
    public float Weight { get; private set; }
    public bool Vegan { get; private set; }
    public bool Active { get; private set; }
    public string Photo { get; private set; }

    public void updatingProduct(string name, string typeOfProduct, string description, float price, bool vegan, float weight = 0, string photo = "")
    {
        Name = name;
        TypeOfProduct = typeOfProduct;
        Description = description;
        Price = price;
        Weight = weight;
        Vegan = vegan;
        Active = true;
        Photo = photo;
    }
    public void inactiveProduct()
    {
        Active = false;
    }

}
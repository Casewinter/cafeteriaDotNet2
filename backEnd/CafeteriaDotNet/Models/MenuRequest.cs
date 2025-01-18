namespace Menu.Models;

public record MenuRequest(string name, string typeOfProduct, string description, float price, bool vegan, float weight);
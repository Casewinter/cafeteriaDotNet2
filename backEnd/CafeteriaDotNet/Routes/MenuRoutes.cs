using Menu.Data;
using Menu.Models;
using Microsoft.EntityFrameworkCore;

namespace Menu.Routers;

public static class Menu
{
    public static void MenuRouters(this WebApplication app)
    {
        var route = app.MapGroup("menu");

        route.MapGet("",
        async (
            MenuContext context

        ) =>
        {
            var allItens = await context.Menu.Where(status => status.Active == true).ToArrayAsync();
            return Results.Ok(allItens);
        });

        route.MapGet("todos-produtos",
        async (
           MenuContext context

       ) =>
       {
           var allItens = await context.Menu.ToArrayAsync();
           return Results.Ok(allItens);
       });

        route.MapPost("", async (MenuRequest request, MenuContext context) =>
        {
            var product = new MenuModel(request.name,
            request.typeOfProduct,
            request.description,
            request.price,
            request.vegan,
            request.weight);

            await context.AddAsync(product);
            await context.SaveChangesAsync();
        });
        route.MapPut("{id:guid}", async (Guid id, MenuRequest request, MenuContext context) =>
        {

            var product = await context.Menu.FirstOrDefaultAsync(line => line.id == id);

            if (product == null) return Results.NotFound();


            product.updatingProduct(request.name,
            request.typeOfProduct,
            request.description,
            request.price,
            request.vegan,
            request.weight);

            await context.SaveChangesAsync();
            return Results.Ok(product);
        });

        route.MapDelete("{id:guid}", async (Guid id, MenuContext context) =>
        {

            var product = await context.Menu.FirstOrDefaultAsync(line => line.id == id);

            if (product == null) return Results.NotFound();


            product.inactiveProduct();

            await context.SaveChangesAsync();
            return Results.Ok(product);
        });
    }
}
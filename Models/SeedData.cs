using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BubbleBalloons.Data;

namespace BubbleBalloons.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BubbleBalloonsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BubbleBalloonsContext>>()))
            {
                // Look for any movies.
                if (context.Balloon.Any())
                {
                    return;   // DB has been seeded
                }

                context.Balloon.AddRange(
                    new Balloon
                    {
                        Material = "Natural Latex",
                        Type = "Latex",
                        Size = "s",
                        Color = "red",
                        Rating = "5",
                        Price = 7.99M
                    },

                    new Balloon
                    {
                        Material = "Biodegradable latex ",
                        Type = "Mylar",
                        Size = "M",
                        Color = "blue",
                        Rating = "3",
                        Price = 8.99M
                    },

                    new Balloon
                    {
                        Material = "Chloroprene latex",
                        Type = "water",
                        Size = "xl",
                        Color = "Green",
                        Rating= "5",
                        Price = 9.99M
                    },

                    new Balloon
                    {
                        Material = "Mylar",
                        Type = "Latex",
                        Size = "L",
                        Color = "Grey",
                        Rating = "4",
                        Price = 3.99M
                    },new Balloon
                    {
                        Material = "Nylon",
                        Type = "Mylar",
                        Size = "xxl",
                        Color = "Violet",
                        Rating = "2",
                        Price = 3.99M
                    },new Balloon
                    {
                        Material = "Tuf-Tex Latex",
                        Type = "Mylar",
                        Size = "M",
                        Color = "Orange",
                        Rating = "3",
                        Price = 3.99M
                    },new Balloon
                    {
                        Material = "Crystal latex",
                        Type = "Mylar",
                        Size = "S",
                        Color = "White",
                        Rating = "4",
                        Price = 3.99M
                    },new Balloon
                    {
                        Material = "Mylar",
                        Type = "Latex",
                        Size = "L",
                        Color = "Green",
                        Rating = "1",
                        Price = 3.99M
                    },new Balloon
                    {
                        Material = "Deco Bubble",
                        Type = "Mylar",
                        Size = "S",
                        Color = "Black",
                        Rating = "5",
                        Price = 3.99M
                    },new Balloon
                    {
                        Material = "Biodegradable PVC",
                        Type = "Mylar",
                        Size = "S",
                        Color = "Pink",
                        Rating = "3",
                        Price = 3.99M
                    }

                );
                context.SaveChanges();
            }
        }
    }
}

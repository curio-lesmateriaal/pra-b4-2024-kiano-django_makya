﻿using PRA_B4_FOTOKIOSK.magie;
using PRA_B4_FOTOKIOSK.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PRA_B4_FOTOKIOSK.controller
{
    public class ShopController
    {
        public static Home Window { get; set; }

        public void Start()
        {
            // Stel de prijslijst in aan de rechter kant.
            ShopManager.SetShopPriceList("Prijzen:\n");


            // Vul de productlijst met producten
            ShopManager.Products.Add(new KioskProduct() { Name = "Foto 10x15", Price = 2.55 });
            ShopManager.Products.Add(new KioskProduct() { Name = "Foto 20x30", Price = 4.95 });
            ShopManager.Products.Add(new KioskProduct() { Name = "Mok met Foto", Price = 9.95 });
            ShopManager.Products.Add(new KioskProduct() { Name = "Sleutelhanger met foto", Price = 6.12 });
            ShopManager.Products.Add(new KioskProduct() { Name = "T-shirt met foto", Price = 11.99 });
            foreach (KioskProduct product in ShopManager.Products)
            {
                ShopManager.AddShopPriceList($"{product.Name}: €{product.Price}\n");
            }


            // Stel de bon in onderaan het scherm
            ShopManager.SetShopReceipt("Eindbedrag\n");


            // Update dropdown met producten
            ShopManager.UpdateDropDownProducts();
        }

        // Wordt uitgevoerd wanneer er op de Toevoegen knop is geklikt
        public void AddButtonClick()
        {
            ShopManager.CheckoutProduct();
        }

        // Wordt uitgevoerd wanneer er op de Resetten knop is geklikt
        public void ResetButtonClick()
        {

        }

        // Wordt uitgevoerd wanneer er op de Save knop is geklikt
        public void SaveButtonClick()
        {
            ShopManager.AddShopReceipt("Bon Gemaakt!");
            ShopManager.AddToReceipt();
        }
    }
}
using System.IO;
using PRA_B4_FOTOKIOSK.magie;

namespace PRA_B4_FOTOKIOSK.models;

public class OrderedProduct
{
    public static void CheckoutProduct()
    {
        KioskProduct selectedProduct = ShopManager.GetSelectedProduct();
        int? fotoId = ShopManager.GetFotoId();
        int? amount = ShopManager.GetAmount();

        if (selectedProduct != null && fotoId.HasValue && amount.HasValue)
        {
            double totalPrice = selectedProduct.Price * amount.Value;
<<<<<<< HEAD
            string content = $"Foto ID: {fotoId.Value}\nProduct: {selectedProduct.Name}\n" +
                             $"Aantal: {amount.Value}\nTotaalprijs: €{totalPrice:F2}\n\n";
        
            File.WriteAllText("../../../magie/bonBestand.txt", content);    
=======
            string receiptText = $"Foto ID: {fotoId.Value}\nProduct: {selectedProduct.Name}\n" +
                                 $"Aantal: {amount.Value}\nTotaalprijs: €{totalPrice:F2}\n\n";
            ShopManager.AddShopReceipt(receiptText);
>>>>>>> 2f2626c23157376d0daa4161e64acb10ba1b56f0
        }
    }

    public static void AddToReceipt()
    {
        KioskProduct selectedProduct = ShopManager.GetSelectedProduct();
        int? fotoId = ShopManager.GetFotoId();
        int? amount = ShopManager.GetAmount();
        double totalPrice = selectedProduct.Price * amount.Value;
        string content = $"Foto ID: {fotoId.Value}\nProduct: {selectedProduct.Name}\n" +
                         $"Aantal: {amount.Value}\nTotaalprijs: €{totalPrice:F2}\n\n";

        File.WriteAllText("../../../magie/bonBestand.txt", content);
    }
}
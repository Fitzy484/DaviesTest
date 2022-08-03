// See https://aka.ms/new-console-template for more information
using CheckoutKata.Models;


//1.Given I have selected to add an item to the basket Then the item should be added to the basket
//2. Given items have been added to the basket Then the total cost of the basket should be calculated
//3. Given I have added a multiple of 3 lots of item ‘B’ to the basket Then a promotion of ‘3 for 40’ should be applied to every multiple of 3 (see: Grid 1).
//4.Given I have added a multiple of 2 lots of item ‘D’ to the basket Then a promotion of ‘25% off’ should be applied to every multiple of 2 (see: Grid 1)0
//
//
//.

Dictionary<int, ShoppingItem> basket = new Dictionary<int, ShoppingItem>();

string itemSKU = Console.ReadLine();

switch (itemSKU)
{
    case "A":
        basket.Add(1, new ShoppingItem(10));
        break;
    case "B":
        // code block
        break;

    case "C":
        //
    case "D":
        //
    default:
        // code block
        break;
}
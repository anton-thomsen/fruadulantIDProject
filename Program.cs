/*B123
C234
A345
C15
B177
G3003
C235
B179*/
string[] orderID = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
foreach (string fraudulantOrder in orderID)
{
 if (fraudulantOrder.StartsWith ("B"))
   {
      Console.WriteLine ($"{fraudulantOrder}");
   }
}
string[] fraudulantOrderIDs = new string [3];

fraudulantOrderIDs [0] = "A123";
fraudulantOrderIDs [1] = "B456";
fraudulantOrderIDs [2] = "C789";

Console.WriteLine ($"First: {fraudulantOrderIDs [0]}");
Console.WriteLine ($"Secon {fraudulantOrderIDs [1]}");
Console.WriteLine ($"Third: {fraudulantOrderIDs [2]}");

fraudulantOrderIDs [0] = "F000";

Console.WriteLine ($"Reasign First: {fraudulantOrderIDs [0]}");
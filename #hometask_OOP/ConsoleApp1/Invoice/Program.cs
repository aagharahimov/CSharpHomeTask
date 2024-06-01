using InvoiceProgram;


Invoice inv = new Invoice(678904, "agasi", "azercell");
inv.Article = "USB-hab";
inv.Quantity = 6;
inv.Price = 30;
inv.CostCalculation(true);




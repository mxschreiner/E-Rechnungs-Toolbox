namespace XRechnung2PDF
{
    internal class InvoiceLine
    {
        int id;
        double quantity;
        double pricePerUnit;
        string name;
        string description;
        double totalPosAmmount;

        public int Id { get => id; set => id = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double PricePerUnit { get => pricePerUnit; set => pricePerUnit = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double TotalPosAmmount { get => totalPosAmmount; set => totalPosAmmount = value; }
    }
}
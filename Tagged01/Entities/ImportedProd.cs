using System.Globalization;

namespace Tagged01.Entities
{
    class ImportedProd: Product
    {  
        public ImportedProd(){}

        public ImportedProd(string Name, double Price, double customsFee)
            : base(Name, Price)
        {
            CustomsFee = customsFee;
        }
        
        public double CustomsFee { get; set; }

        public double totalPrice()
        {
            double result = CustomsFee + Price;

            return result;
            
        }


        public override string priceTag()
        {
            return $"{this.Name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }


    }
    
}
namespace Assignment1
{
    public class Medicine
    {
        public int medicineCode;
        public string medicineName;
        public string manufactureName;
        public int price;
        public int quantity;
        public string date;
        public string expiryDate;
        public int batchno;

        //public Medicine(int medicineCode, string medicineName, string manufactureName, int price, int quantity, DateTime date, int batchno)
        //{
        //    this.medicineCode = medicineCode;
        //    this.medicineName = medicineName;
        //    this.manufactureName = manufactureName;
        //    this.price = price;
        //    this.quantity = quantity;
        //    this.date = date;
        //    this.batchno = batchno;
        //}

        public void accept()
        {
            Console.WriteLine("Enter Medicine Code");
            medicineCode = int.Parse(Console.ReadLine());
           // Console.WriteLine(medicineCode);
            Console.WriteLine("Enter Medicine Name");
            medicineName = Console.ReadLine();
            Console.WriteLine("Enter Manufacture Name");
            manufactureName = Console.ReadLine();
            Console.WriteLine("Enter Quantity");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Medicine Price");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Batch number");
            batchno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date");
            date = Console.ReadLine();
            Console.WriteLine("Enter expiry date");
            expiryDate = Console.ReadLine();
            print();
        }

        public void print()
        {
            Console.WriteLine(medicineCode);

            Console.WriteLine(medicineName);
            Console.WriteLine(manufactureName);
            Console.WriteLine(price);
            Console.WriteLine(quantity);
            Console.WriteLine(batchno);
            Console.WriteLine(date);
            Console.WriteLine(expiryDate);
        }
    }
    public class Sales
    {
        public int medicineCode;
        public int quantitySold;
        public int plannedSales;
        public int actualSales;
        public string region;

        //public Sales(int medicineCode, int quantitySold, int plannedSales, int actualSales, string region)
        //{
        //    this.medicineCode = medicineCode;
        //    this.quantitySold = quantitySold;
        //    this.plannedSales = plannedSales;
        //    this.actualSales = actualSales;
        //    this.region = region;
        //}

        public void accept()
        {
            Console.WriteLine("Enter Medicine Code");
            medicineCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quntity Sold");
            quantitySold = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Planned Sales");
            plannedSales = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Actual Sales");
            actualSales = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Region");
            region = Console.ReadLine();
            print();
        }
        public void print()
        {
            Console.WriteLine(medicineCode);
            Console.WriteLine(quantitySold);
            Console.WriteLine(plannedSales);
            Console.WriteLine(actualSales);
            Console.WriteLine(region);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Medicine med = new Medicine();
            med.accept();
            //Console.WriteLine("============================");
           

            Sales sales = new Sales();
            sales.accept();
            
            
        }
    }
}
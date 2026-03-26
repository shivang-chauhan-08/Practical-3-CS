namespace Inheritance___Polymorphism
{
    internal class Laptop
    {
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        /// <summary>
        /// This method prints Brand & Model Name of the Laptop
        /// Return Type : void
        /// </summary>
        public void LaptopDetails()
        {
            Console.WriteLine("Brand : " + Brand);
            Console.WriteLine("Model : " + Model);
            MotherBoardInfo();
        }

        /// <summary>
        /// This is private method, so Main cannot access it.
        /// </summary>
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
}

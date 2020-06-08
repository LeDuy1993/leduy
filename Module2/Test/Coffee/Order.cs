namespace Coffee
{
    class Order
    {
        public string NameDrink { get; set; }
        public long Price { get; set; }
        public long Count { set; get; }
        public long Total => Price * Count;

        public override string ToString()
        {
            return $"Name Drink: {NameDrink}\t" +
                $"Price: {Price}\t" +
                $"Count: {Count}\t" +
                $"Total: {Total}\n";
        }

    }
}

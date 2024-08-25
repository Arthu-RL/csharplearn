namespace calc {
    public class Container {
        private int _capacity;

        public Container(int capacity) {_capacity = capacity;}

        public int GetCapacity() {
            return _capacity;
        }

        public void AddToCapacity(int amount) {
            _capacity += amount;
        }

        public static void CheckCapacity (int capacity) {
            if (capacity >= 20) {
                Console.WriteLine("Good capacity by the way.");
            } else {
                Console.WriteLine("Low capacity");
            }
        }
    }
}

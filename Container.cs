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
    }
}

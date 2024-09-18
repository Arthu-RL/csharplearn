namespace math {
    public static class MathConcepts {
        static int fibbonaci(int n) {
            int j = 0; 
            int k = 0;

            int i = 1;
            int h = 1;

            while (n > 0) {
                if (n % 2 != 0) {
                    int temp = j+h;
                    j = i*h + j*k + temp;
                    i = i*k + temp;
                }

                int t = h*h;
                h = 2*k*h + t;
                k = k*k + t;
                n /= 2;
            }

            return j;
        }
    };
}

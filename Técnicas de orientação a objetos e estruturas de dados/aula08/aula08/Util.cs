namespace curso {
    class Util {

        public static int MenorDentreTres(int a, int b, int c) {
            if (a < b && a < c) {
                return a;
            }
            else if (b < c) {
                return b;
            }
            else {
                return c;
            }
        }

    }
}

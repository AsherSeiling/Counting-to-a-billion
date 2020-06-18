public class java{
    public static void main(final String[] args) {
        int num = 0;
        boolean run = true;
        while (run == true){
            num += 1;
            System.out.println(num);
            if (num == 1000000000){
                run = false;
            }
        }
    }
}
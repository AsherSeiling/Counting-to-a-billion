using System;
namespace c_sharp{
    class c_sharp{
        static void main(string[] args){
            int num = 0;
            bool run = true;
            while (run == true){
                num += 1;
                Console.WriteLine(num);
                if (num == 1000000000){
                    run = false;
                }
            }
        }
    }
}
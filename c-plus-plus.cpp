#include <iostream>

using namespace std;

int main(){
    int number = 0;
    bool run = true;
    while(run == true){
        number += 1;
        cout << number << endl;
        if(number == 1000000000){
            run = false;
            
        }
    }
}
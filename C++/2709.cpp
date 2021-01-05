#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include <locale.h>
using namespace std;

int count = 0;

int Primo(int total) {
    
    if (total != 2  && total % 2 == 0 || total == 1)
		return 0;

    int metade = int(total/2);
    for (count = 3; count <= metade; count++) {
        if (total % count == 0) {
            return 0;
        }           
    }
    return 1; 
}

void Impress(int check) {      
    
    if (check == 1) {        
        cout << "You’re a coastal aircraft, Robbie, a large silver aircraft.";
    }           
    else {
        cout << "Bad boy! I’ll hit you.";
    }

    cout << "\n";   
}

int main(int argc, char *argv[]) {
    setlocale(LC_ALL, " ");    
    int M = 0;
    int coins[25];
    
    while (cin >> M) {
           
        int N = 0, total = 0;                         
        total = 0;
        for (count = 0; count <= M; count++) {            
            cin >> coins[count];
        }                    
        
        for (count = M-1; count >= 0; count -= coins[M]) {
            total += coins[count];
        }      
       
        Impress(Primo(total));    
    }
    
    return 0; 
}
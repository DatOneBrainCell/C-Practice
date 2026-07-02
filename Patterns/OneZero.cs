using System;

class Pattern {
    
    static void Main() {
        
        int n = 5;

        for(int i = 0; i < n; i++) {
            
            for(int j = 1; j < i+1; j++) {
                
                if((i + j) % 2 == 0) {
                    Console.Write(1 + " ");
                }
                else {
                    Console.Write(0 + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

// O/P:
// 1 
// 0 1 
// 1 0 1 
// 0 1 0 1 

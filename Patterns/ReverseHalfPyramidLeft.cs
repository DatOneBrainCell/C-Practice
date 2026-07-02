using System;

class Pattern {
    
    static void Main() {
        
        int n = 5;
        
        for(int i = 0; i < n; i++) {
            
            for(int k = n-1; k > i; k--) {
                Console.Write(n-k + " ");
            }
            Console.WriteLine();
        }
    }
}

// O/P:
// 1 2 3 4 
// 1 2 3 
// 1 2 
// 1 

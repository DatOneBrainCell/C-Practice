using System;

class Pattern {
    
    static void Main() {
        
        int n = 5;
        
        for(int i = 0; i < n; i++) {
            
            for(int k = 0; k < i; k++) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

// O/P:
     
// 1 
// 2 2 
// 3 3 3 
// 4 4 4 4 

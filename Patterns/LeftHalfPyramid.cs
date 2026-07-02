using System;

class Pattern {
    
    static void Main() {
        
        int n = 5;
        
        for(int i = 0; i < n; i++) {
            
            for(int j = 1; j < i+1; j++) {
                
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

// O/P:

// 1 
// 1 2 
// 1 2 3 
// 1 2 3 4 

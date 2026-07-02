using System;

class Pattern {
    
    static void Main() {
        
        int n = 5;
        int inc = 1;
        
        for(int i = 0; i < n; i++) {
            
            for(int j = 1; j < i+1; j++) {
                
                Console.Write(inc + " ");
                inc++;
            }
            Console.WriteLine();
        }
    }
}

// O/P:

// 1 
// 2 3 
// 4 5 6 
// 7 8 9 10 
// 1 2 3 4 

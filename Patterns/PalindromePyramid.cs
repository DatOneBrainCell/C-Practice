using System;

class Pattern {
    
    static void Main() {
        
        int n = 5;
        int i, j, k;

        for(i = 0; i < n; i++) {
            
            for(j = n; j > i; j--) {
                Console.Write("  ");
            }
            for(k = i; k >= 1; k--) {
                Console.Write(k + " ");
            }
            for(k = 2; k <= i; k++) {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }
    }
}

// O/P:
          
//         1 
//       2 1 2 
//     3 2 1 2 3 
//   4 3 2 1 2 3 4 

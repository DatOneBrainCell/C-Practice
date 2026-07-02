using System;

class Pattern {
    
    static void Main() {
        
        int n = 5;
        int i, j, k;

        for(i = 0; i < n; i++) {
            
            for(j = 0; j < i; j++) {
                Console.Write("  ");
            }
            for(k = 0; k < n; k++) {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

// O/P:
          
// * * * * * 
//   * * * * * 
//     * * * * * 
//       * * * * * 
//         * * * * * 

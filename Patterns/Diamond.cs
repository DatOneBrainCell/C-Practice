using System;

class Pattern {
    
    static void Main() {
        
        int n = 5;
        int i, j, k;

        for(i = 0; i < n; i++) {
            
            for(j = n; j > i; j--) {
                Console.Write("  ");
            }
            for(k = 0; k < i+1; k++) {
                Console.Write("* ");
            }
            for(k = i+1; k > 1; k--) {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        for(i = 0; i < n-1; i++) {
            
            for(j = 0; j <= i+1; j++) {
                Console.Write("  ");
            }
            for(k = n; k > i+1; k--) {
                Console.Write("* ");
            }
            for(k = n-1; k > i+1; k--) {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

// O/P:
//           * 
//         * * * 
//       * * * * * 
//     * * * * * * * 
//   * * * * * * * * * 
//     * * * * * * * 
//       * * * * * 
//         * * * 
//           * 

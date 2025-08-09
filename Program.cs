using System;

namespace TestProject4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ilustrando tipo de referência
            // int[] data = new int[3];
            // foreach (var d in data)
            // {
            //     Console.WriteLine(data[d]);
            // }

            //tipo de valor
            int val_A = 2;
            int val_B = val_A;
            // val_B é uma cópia de val_A
            val_B = 5;
            // Alterando val_B não afeta val_A, pois são tipos de valor.

            Console.WriteLine("--Value Types--");
            Console.WriteLine($"val_A: {val_A}");
            Console.WriteLine($"val_B: {val_B}");

            //tipo de referência
            int[] ref_A = new int[1];
            ref_A[0] = 2;
            int[] ref_B = ref_A;
            // ref_B é uma referência ao mesmo array que ref_A
            // Alterando o valor em ref_B também altera ref_A, pois ambos referenciam
            // o mesmo array na memória.
            ref_B[0] = 5;

            Console.WriteLine("--Reference Types--");
            Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            Console.WriteLine($"ref_B[0]: {ref_B[0]}");
        }
    }
}
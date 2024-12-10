using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        #region soal 1

        //input array
        Console.WriteLine("SOAL 1");
        Console.WriteLine("Input angka, gunakan '[]' untuk membungkus angka dan ','" +
            " untuk memisahkan angka contoh ([1,2,3,4,5])");
        string userInput = Console.ReadLine();
        userInput = userInput.Replace("[", "").Replace("]", "");

        if (!string.IsNullOrWhiteSpace(userInput))
        {
            bool isValid = userInput.Split(',').All(segment=> int.TryParse(segment, out _));
            if (!isValid) //Stop aplikasi saat input tidak berupa angka dan dipisahkan oleh koma
            {
                Console.WriteLine("Input Hanya boleh menggunakan angka, dipisahkan oleh koma! \n");
            }
            else
            {
                //ubah input string menjadi array integer
                int[] input = userInput
                    .Split(',')         //Pisahkan dengan 
                    .Select(int.Parse)  //ubah setiap elemen menjadi integer
                    .ToArray();         //convert ke array

                
                var oddNumbers = input.Where(x => x % 2 != 0);              //filter angka ganjil
                var result = oddNumbers.Where(x => x < input.Max());   //pilih angka ganjil terkecil
                List<int> output = result.ToList();
                output = output.OrderByDescending(x => x).ToList();
                Console.WriteLine("[" + string.Join(", ", output) + "]");   //output hasil
                
            }
        }
        else
        {
            Console.WriteLine("Input tidak boleh berupa string kosong!");
        }

        #endregion soal 1

        #region soal 2
        Console.WriteLine("SOAL 2");
        Console.WriteLine("Masukkan String : ");
        string inputno2 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(inputno2))
        {
            Console.WriteLine("Input tidak boleh kosong!");
            return;
        }
        StringBuilder outputNo2 = new StringBuilder(); // var untuk save hasil

        char currentChar = inputno2[0];
        int count = 1;

        for (int i = 1; i < inputno2.Length; i++)
        {
            if (inputno2[i] == currentChar)
            {
                count++;
            }
            else
            {
                outputNo2.AppendLine($"{currentChar} = {count}");
                currentChar = inputno2[i];
                count = 1;
            }
        }

        outputNo2.AppendLine($"{currentChar} = {count}");
        Console.WriteLine(outputNo2.ToString());
        #endregion soal 2

    }
}
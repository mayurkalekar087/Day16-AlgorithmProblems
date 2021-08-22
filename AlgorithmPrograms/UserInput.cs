using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class UserInput
    {
        public UserInput()
        {
            int userInput;
            Console.WriteLine("Choose - 1. Permutation ");
            Console.WriteLine("Choose - 2. Binary Search");
            Console.WriteLine("Choose - 3. Insertion Sort ");
            Console.WriteLine("Choose - 4. Bubble Sort ");
            Console.WriteLine("Choose - 5. Merge Sort ");
            Console.WriteLine("Choose - 6. Prime ");
            Console.WriteLine("Choose - 7. Anagram Detection ");
            Console.WriteLine("*****************************");
            Console.WriteLine("Enter One Number : ");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("*****************************");

            switch (userInput)
            {
                case 1:
                    String str = "ABC";
                    int n = str.Length;
                    Permutations permutations = new Permutations();
                    permutations.permute(str, 0, n - 1);
                    permutations.IterationPermutation(str);
                    break;
                case 2:
                    BinarySearch binarySearch = new BinarySearch();
                    binarySearch.binarysearch();
                    break;
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.Insert();
                    break;
                case 4:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.Bubblesort();
                    break;
                case 5:
                    MergeSort mergeSort = new MergeSort();
                    mergeSort.Merging();
                    break;
                case 6:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.Prime();
                    break;
                case 7:
                    Anagram anagram = new Anagram();
                    anagram.anagram();
                    break;
                default:
                    Console.WriteLine("Number is Invalid");
                    break;
            }

        }
    }
}

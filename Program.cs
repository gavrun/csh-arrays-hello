namespace csh_arrays_hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Arrays!\n");
            
            // combining individual variables into an ordered array
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int[] A = { a, b, c, d };
            Console.WriteLine("Array A = [1, 2, 3, 4]:");
            foreach (var item in A)
                Console.Write(item + " ");
            Console.WriteLine("\n");
            
            // basic array initialization
            int[] basicArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Basic Array:");
            foreach (var item in basicArray)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            // initializing array with default values (0 for int)
            int[] defaultArray = new int[5]; // automatically set to { 0, 0, 0, 0, 0 }
            Console.WriteLine("Default Array with 5 elements:");
            foreach (var item in defaultArray)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            // initializing array with inferred type and values
            var inferredArray = new[] { 10, 20, 30, 40, 50 };
            Console.WriteLine("Inferred Type Array:");
            foreach (var item in inferredArray)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            // initializing array by using create instance for generic array
            Array genericArray = Array.CreateInstance(typeof(int), 5);
            for (int i = 0; i < genericArray.Length; i++)
                genericArray.SetValue(i + 1, i); // setting values { 1, 2, 3, 4, 5 }
            Console.WriteLine("Generic Array using Array.CreateInstance:");
            foreach (var item in genericArray)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            // initializing an array with a specific size and using a loop to populate it
            int[] loopInitializedArray = new int[5];
            for (int i = 0; i < loopInitializedArray.Length; i++)
            {
                loopInitializedArray[i] = (i + 1) * 2; // sets { 2, 4, 6, 8, 10 }
            }
            Console.WriteLine("Loop Initialized Array:");
            foreach (var item in loopInitializedArray)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            // initializing an array with values using collection initializer syntax
            int[] collectionInitializedArray = { 100, 200, 300, 400, 500 };
            Console.WriteLine("Collection Initialized Array:");
            foreach (var item in collectionInitializedArray)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            // initializing an array by enumeration
            int[] enumedArray = Enumerable.Repeat(1, 5).ToArray(); // array of 5 elements
            Console.WriteLine("Array initialized with the same value:");
            Console.WriteLine(string.Join(" ", enumedArray));
            Console.WriteLine();

            // reusing basicArray in other operations 
            Console.WriteLine("Reusing Basic Array:");
            foreach (var item in basicArray)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            // accessing and modifying elements of an array
            Console.WriteLine("Accessing first element: " + basicArray[0]);
            basicArray[0] = 10;
            Console.WriteLine("After modifying first element: " + basicArray[0]);
            Console.WriteLine();

            // multi-dimensional array
            int[,] multiArray = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("Multi-dimensional Array:");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.WriteLine($"multiArray[{i},{j}] = {multiArray[i, j]}");
            Console.WriteLine();

            // jagged array with sizes 1, 2, 3, and 4
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 1 };
            jaggedArray[1] = new int[] { 1, 2 };
            jaggedArray[2] = new int[] { 1, 2, 3 };
            jaggedArray[3] = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Jagged Array:");
            foreach (var array in jaggedArray)
            {
                foreach (var item in array)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            // collection (dynamic list) of arrays
            List<int[]> listOfArrays = new List<int[]>();
            listOfArrays.Add(new int[] { 1, 2 });
            listOfArrays.Add(new int[] { 3, 4, 5 });
            Console.WriteLine("List of arrays (dynamic 'jagged' structure):");
            foreach (var arrayItem in listOfArrays)
                Console.WriteLine(string.Join(" ", arrayItem));
            Console.WriteLine();

            // array methods
            int[] sampleArray = { 5, 3, 1, 4, 2 };
            Array.Sort(sampleArray);
            Console.WriteLine("Sorted Array:");
            Console.WriteLine(string.Join(" ", sampleArray));

            // array methods
            Array.Reverse(sampleArray);
            Console.WriteLine("Reversed Array:");
            Console.WriteLine(string.Join(" ", sampleArray));

            // array methods
            int index = Array.IndexOf(sampleArray, 4);
            Console.WriteLine("Index of 4 in reversed array: " + index);

            // checking array bounds
            if (sampleArray.Length > 3)
            {
                Console.WriteLine("Accessing element at index 3: " + sampleArray[3]);
            }
            else
            {
                Console.WriteLine("Array does not have an index 3.");
            }

            // getting the last element safely
            if (sampleArray.Length > 0)
            {
                Console.WriteLine("Last element: " + sampleArray[sampleArray.Length - 1]);
            }
            else
            {
                Console.WriteLine("Array is empty.");
            }

            // finding maximum and minimum elements
            int max = sampleArray.Max();
            int min = sampleArray.Min();
            Console.WriteLine("Maximum value in array: " + max);
            Console.WriteLine("Minimum value in array: " + min);

            // summing all elements
            int sum = sampleArray.Sum();
            Console.WriteLine("Sum of all elements in array: " + sum);

            // copying and cloning arrays
            int[] copyArray = new int[5];
            Array.Copy(sampleArray, copyArray, sampleArray.Length);
            Console.WriteLine("Copied Array:");
            Console.WriteLine(string.Join(" ", copyArray));
            int[] clonedArray = (int[])sampleArray.Clone();
            Console.WriteLine("Cloned Array:");
            Console.WriteLine(string.Join(" ", clonedArray));

            // resizing arrays 
            Array.Resize(ref copyArray, 7);
            copyArray[5] = 99;
            copyArray[6] = 100;
            Console.WriteLine("Resized Array:");
            Console.WriteLine(string.Join(" ", copyArray));
            Console.WriteLine();

            // basic LINQ with arrays
            
            int[] numbers = { 1, -2, 3, -4, 5 };
            var positiveNumbers = numbers.Where(n => n > 0).ToArray();
            Console.WriteLine("Positive Numbers (LINQ):");
            Console.WriteLine(string.Join(" ", positiveNumbers));

            var sortedNumbers = numbers.OrderBy(n => n).ToArray();
            Console.WriteLine("Sorted Numbers (LINQ):");
            Console.WriteLine(string.Join(" ", sortedNumbers));

            int totalSum = numbers.Sum();
            Console.WriteLine("Sum of Array Elements (LINQ): " + totalSum);
            Console.WriteLine();

            // checking, finding, and filtering elements
            bool existsGreaterThanZero = Array.Exists(numbers, n => n > 0);
            Console.WriteLine("Exists element > 0: " + existsGreaterThanZero);
            int firstPositive = Array.Find(numbers, n => n > 0);
            Console.WriteLine("First positive number: " + firstPositive);
            int[] allPositives = Array.FindAll(numbers, n => n > 0);
            Console.WriteLine("All positive numbers:");
            Console.WriteLine(string.Join(" ", allPositives));
            Console.WriteLine();

            // binary search for a sorted array
            Array.Sort(numbers);
            int binarySearchIndex = Array.BinarySearch(numbers, 3);
            Console.WriteLine("Binary Search for 3: Index = " + binarySearchIndex);
            Console.WriteLine();

            // removing elements
            int[] originalArray = { 1, 2, 3, 4, 5 };
            int elementToRemove = 3;
            int[] modifiedArray = originalArray.Where(x => x != elementToRemove).ToArray();
            Console.WriteLine("Array after removing element 3:");
            Console.WriteLine(string.Join(" ", modifiedArray));
            Console.WriteLine();

            // using array segments
            int[] fullArray = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("FullArray:");
            foreach (var item in fullArray)
                Console.Write(item + " ");
            Console.WriteLine();
            ArraySegment<int> subArray = new ArraySegment<int>(fullArray, 2, 3); // elements from 2 to 4 (3 elements)
            Console.WriteLine("SubArray:");
            foreach (var item in subArray)
                Console.Write(item + " ");
            Console.WriteLine();

            // reversing array segments
            int[] arrayForReversing = { 1, 2, 3, 4, 5 };
            int start = 1, length = 3;
            Array.Reverse(arrayForReversing, start, length); // reverses elements 2, 3 and 4
            Console.WriteLine("Array after reversing a subarray:");
            Console.WriteLine(string.Join(" ", arrayForReversing));
            
            // remove duplicates with collection (dynamic hashset)
            int[] arrayWithDuplicates = { 1, 2, 2, 3, 4, 4, 5 };
            int[] uniqueArray = new HashSet<int>(arrayWithDuplicates).ToArray();
            Console.WriteLine("Array after removing duplicates:");
            Console.WriteLine(string.Join(" ", uniqueArray));
            Console.WriteLine();

            // advanced LINQ with arrays
            int[] complexArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var result = complexArray.Where(x => x % 2 == 0).OrderByDescending(x => x).ToArray();
            Console.WriteLine("Even numbers sorted in descending order:");
            Console.WriteLine(string.Join(" ", result));
            int[] complexArray2 = { 1, 2, 2, 3, 5, 6, 6, 7, 8, 9, 11, 13 };
            var result2 = complexArray2.Where(x => x % 2 == 0).OrderByDescending(x => x).ToArray();
            Console.WriteLine(string.Join(" ", result2));
            Console.WriteLine();

            // serializing array
            int[] arrayToSerialize = { 1, 2, 3, 4, 5 };
            string serializedArray = string.Join(",", arrayToSerialize);
            Console.WriteLine("Serialized array:");
            Console.WriteLine(serializedArray);
            Console.WriteLine();

            // filling an array with random
            int[] randomArray = new int[5];
            Random random = new Random();
            for (int i = 0; i < randomArray.Length; i++)
                randomArray[i] = random.Next(1, 100); // numbers from 1 to 100
            Console.WriteLine("Array with random values:");
            Console.WriteLine(string.Join(" ", randomArray));

            Console.WriteLine("\nGood bye, Arrays.");
        }
    }
}

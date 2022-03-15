using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Different ways of defining arrays
            // 1D array
            int[] numbers = { 10, 12, 34, 45, 67, 78 };
            string[] names = new string[5] { "Dhamu", "Kannan", "Kumar", "Rahim", "David" };
            float[] avgs = new float[5];
            avgs[0] = 60.5f;
            avgs[1] = 70.5f;
            avgs[2] = 50.5f;
            avgs[3] = 20.5f;
            avgs[4] = 80.5f;

            decimal[] salary;  // array not initialized
            salary = new decimal[4] { 100.5m, 45.7m, 567.0m, 70.5m };

            Console.WriteLine("First element in numbers array: " + numbers[0]);
            Console.WriteLine("Last element in names array: " + names[4]);
            Console.WriteLine("Third element in avgs array: " + avgs[2]);
            Console.ReadLine();

            // Multi-dimensional - 2D arrays
            int[,] matrix = new int[2, 2] { { 4, 5  }, 
                                            { 10, 4 } 
                                          };
            int[,] twodnumbers = new int[4, 2] { 
                { 4, 5 }, 
                { 10, 4 }, 
                {45,60}, 
                {10,12} 
            };

            // Multi-dimensional - 3D arrays
            int[,,] threednumbers = new int[3, 3, 4]
            {
                { { 1, 2, 3,10 },
                  { 4, 5, 6,20}, 
                  {20,30,40,50 } 
                 },

                { { 1, 2, 3,10 },
                  { 4, 5, 6,20}, 
                  {20,30,40,78} 
                },

                 { { 1, 2, 3,10 },
                  { 4, 5, 6,20},
                  {20,30,40,78}
                }
            };
           
            int[,,] intarray3D = new int[,,] { 
                { 
                    { 1, 2, 3 }, { 4, 5, 6 } 
                },
                
                { 
                    { 7, 8, 9 }, { 10, 11, 12 } 
                } 
            };

            int[,,] intarray3Dd = new int[2, 2, 3] 
            { 
                { { 1, 2, 3 }, { 4, 5, 6 } },
                { { 7, 8, 9 }, { 10, 11, 12 } } 
            };


            //Jagged Array - An array whose elements are arrays is known as Jagged arrays it means “array of arrays“. 
            // In Jagged arrays, user has to provide the number of rows only. 
            // If the user is also going to provide the number of columns, then this array will be no more Jagged Array
            // Declare the array of two elements: 
            int[][] arr = new int[2][];

            // Initialize the elements: 
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };
      

            Console.WriteLine("=> Array of Objects.");
            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(2020, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();

        }
    }
}

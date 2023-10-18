namespace Strategy_Pattern
{
    using System;
    using System.Collections.Generic;

    public interface ISortStrategy
    {
        List<int> Sort(List<int> data);
    }

    public class BubbleSort : ISortStrategy
    {
        public List<int> Sort(List<int> data)
        {
            // Simulate bubblesort
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = 0; j < data.Count - 1 - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            return data;
        }
    }

    public class QuickSort : ISortStrategy
    {
        public List<int> Sort(List<int> data)
        {
            return data;  // Simulate quicksort
        }
    }

    public class SortingContext
    {
        private ISortStrategy strategy;

        public SortingContext(ISortStrategy strategy)
        {
            this.strategy = strategy;
        }

        public List<int> ExecuteStrategy(List<int> data)
        {
            return strategy.Sort(data);
        }
    }

    class Program
    {
        static void Main()
        {
            List<int> data = new List<int> { 3, 1, 2, 5, 4 };

            SortingContext bubbleSortContext = new SortingContext(new BubbleSort());
            SortingContext quickSortContext = new SortingContext(new QuickSort());

            List<int> sortedDataBubbleSort = bubbleSortContext.ExecuteStrategy(data);
            List<int> sortedDataQuickSort = quickSortContext.ExecuteStrategy(data);

            Console.WriteLine(string.Join(", ", sortedDataBubbleSort));  // Output: 1, 2, 3, 4, 5
            Console.WriteLine(string.Join(", ", sortedDataQuickSort));   // Output: 3, 1, 2, 5, 4
        }
    }

}
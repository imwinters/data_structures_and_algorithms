using Microsoft.Extensions.Logging;

namespace DSA.Sorting;
public class BruteForceSort : IBruteForceSort
{

    ILogger<BruteForceSort> _logger;

    public BruteForceSort(ILogger<BruteForceSort> logger)
    {
        _logger = logger;
    }

    public List<int> SelectionSort(List<int> targetCollection)
    {
        _logger.LogInformation("Sorting target collecting using Selction sort.");

        for (int i = 0; i < targetCollection.Count; i++)
        {
            // Iterate through every value
            int minimumValue = targetCollection[i];
            int minimumIndex = i;
            // for every value unsorted in the list, find the smallest that remains
            for (int j = i+1; j < targetCollection.Count; j++)
            {
                if (targetCollection[j] < minimumValue)
                {
                    minimumValue = targetCollection[j];
                    minimumIndex = j;
                }
            }

            SwapElementsAtIndecies(targetCollection, i, minimumIndex);

        }

        return targetCollection;

    }

    public List<int> BubbleSort(List<int> targetCollection)
    {
        _logger.LogInformation("Sorting Target Collection using Bubble Sort");

        for (int i = 0; i < targetCollection.Count-1; i++ )
        {
            for (int j = targetCollection.Count-1;j > i; j--)
            {
                if (targetCollection[j-1] > targetCollection[j])
                {
                    SwapElementsAtIndecies(targetCollection, j - 1, j);
                }
            }
        }

        return targetCollection;
    }


    private static void SwapElementsAtIndecies(List<int> targetCollection, int index1, int index2)
    {
        int tempValue = targetCollection[index1];
        // replace the high values
        targetCollection[index1] = targetCollection[index2];
        // replace the low value
        targetCollection[index2] = tempValue;
    }
}
  
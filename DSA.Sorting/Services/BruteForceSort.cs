
using DSA.Helpers;
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

            // Cache the high value
            int tempHighValue = targetCollection[i];
            // replace the high values
            targetCollection[i] = targetCollection[minimumIndex];
            // replace the low value
            targetCollection[minimumIndex] = tempHighValue;

        }

        return targetCollection;

    }



}
  
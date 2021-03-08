using Sorting;
using System.Collections;
public class BubbleSorter : BaseSorter
{
    protected override IEnumerator Sort()
    {
        int nodeCount = nodes.Length;
        Node tempNode;

        // Loop over the array 'length-squared' times.
        for (int i = 0; i <= nodeCount - 2; i++)
        {
            for (int j = 0; j <= nodeCount - 2; j++)
            {
                // Is this number greater than the one after it?
                if (nodes[j].Index > nodes[j + 1].Index)
                {
                    // It is, so swap the elements.
                    // Store the next element in a temp variable.
                    tempNode = nodes[j + 1];
                    // Set the next element to the current one.
                    nodes[j + 1] = nodes[j];
                    // Set this element to the temp one.
                    nodes[j] = tempNode;

                    // THIS SHIT IS JUST AESTHETIC
                    StartFrame(j, j + 1);
                    yield return null;
                    EndFrame(j, j + 1);
                }
            }
        }
    }
}
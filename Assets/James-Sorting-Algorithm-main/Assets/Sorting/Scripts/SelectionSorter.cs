using Sorting;
using System.Collections;
public class SelectionSorter : BaseSorter
{
    protected override IEnumerator Sort()
    {
        int nodeCount = nodes.Length;
        int smallest; // This is actually the item index... NOT THE ACTUAL VALUE.
        int old; // This is not part of the algorithm, just for visualisation.
        Node tempNode;

        // Looping though all elements.
        for (int i = 0; i < nodeCount - 1; i++)
        {
            // Assign the smallest number to this loop's iterator value.
            smallest = i;
            old = i;

            // Loop from this iteration to the end.
            for (int j = i + 1; j < nodeCount; j++)
            {
                //Compare this index to the current smallest index item.
                if (nodes[j].Index < nodes[smallest].Index)
                {
                    smallest = j;
                }
            }

            // Swap the elements.
            tempNode = nodes[smallest];
            nodes[smallest] = nodes[old];
            nodes[old] = tempNode;

            // aethetic shit
            StartFrame(old, smallest);
            yield return null;
            EndFrame(old, smallest);
        }
    }
}
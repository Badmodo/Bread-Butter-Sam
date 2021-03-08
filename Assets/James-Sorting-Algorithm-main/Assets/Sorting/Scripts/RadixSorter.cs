using Sorting;
using System.Collections;
using Array = System.Array;
public class RadixSorter : BaseSorter
{
    protected override IEnumerator Sort()
    {
        int nodeCount = nodes.Length;
        Node[] temp = new Node[nodes.Length];
        int j, i;
        for (int shift = 31; shift > -1; --shift)
        {
            // Set j to 0.
            j = 0;

            // Loop though the whole array.
            for (i = 0; i < nodeCount; ++i)
            {
                // Determine if the bit-shifted variable is above 0.
                bool move = (nodes[i].Index << shift) >= 0;
                if (shift == 0 ? !move : move) nodes[i - j] = nodes[i];
                else temp[j++] = nodes[i];
            }

            // Copy the data to the temp array.
            Array.Copy(temp, 0, nodes, nodes.Length - j, j);

            // James is done for the day...
            StartFrame(0, 1);
            yield return null;
            EndFrame(0, 1);
        }
    }
}
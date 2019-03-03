using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3Av1
{
    class Heap
    {
        private Urun[] heapArray;
        private int currentSize;
        private int maxSize;

        internal Urun[] HeapArray { get => heapArray; set => heapArray = value; }
        public int CurrentSize { get => currentSize; set => currentSize = value; }

        public Heap(int maxByt)
        {
            maxSize = maxByt;
            CurrentSize = 0;
            HeapArray = new Urun[maxByt];
        }

        public void trickleUp(int index)
        {
            int parent = (index - 1) / 2;
            Urun bottom = HeapArray[index];
            while (index > 0 && HeapArray[parent].SatisFiyati > bottom.SatisFiyati)
            {
                HeapArray[index] = HeapArray[parent]; // move it down
                index = parent;
                parent = (parent - 1) / 2;
            } // end while
            HeapArray[index] = bottom;
        }
        public bool insert(Urun urun)
        {
            if (CurrentSize == maxSize)
                return false;


            HeapArray[CurrentSize] = urun;
            trickleUp(CurrentSize++);
            return true;
        }

        public void trickleDown(int index)
        {
            int largerChild;
            Urun top = heapArray[index]; // save root
            while (index < CurrentSize / 2) // while node has at
            { // least one child,
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                // find larger child
                if (rightChild < CurrentSize && // (rightChild exists?)
                heapArray[leftChild].SatisFiyati >
                heapArray[rightChild].SatisFiyati)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                // top >= largerChild?
                if (top.SatisFiyati <= heapArray[largerChild].SatisFiyati)
                    break;
                // shift child up
                heapArray[index] = heapArray[largerChild];
                index = largerChild; // go down
            } // end while
            heapArray[index] = top;
        }

        public Urun remove() // delete item with max key
        { // (assumes non-empty list)
            Urun root = heapArray[0];
            heapArray[0] = heapArray[--CurrentSize];
            trickleDown(0);
            return root;
        } // end remove()
    }
}

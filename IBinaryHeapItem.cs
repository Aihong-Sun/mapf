﻿using System;

namespace CPF_experiment
{
    /// <summary>
    /// represents items that are stored in the binary heap
    /// </summary>
    public interface IBinaryHeapItem : IComparable<IBinaryHeapItem> 
    {
        /// <summary>
        /// the index of the item in the binary heap
        /// </summary>
        int getIndexInHeap();
        void setIndexInHeap(int index);
    }
}

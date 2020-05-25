using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLibrary.Iterator.Iterator
{
    // Iterator
    public interface IIterator
    {
        void First();           //  Sets current element to the first element
        string Next();          //  Advances current to next element
        bool IsDone();          //  Check if end of collection
        string CurrentItem();   //  returns the current element
    }
}

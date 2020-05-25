using DesignPatternsLibrary.Iterator.Iterator;

namespace DesignPatternsLibrary.Iterator.Aggregate
{
    // Aggregate
    public interface INewspaper
    {
        IIterator CreateIterator();
    }
}

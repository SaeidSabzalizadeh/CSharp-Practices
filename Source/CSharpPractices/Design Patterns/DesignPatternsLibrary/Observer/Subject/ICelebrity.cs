using DesignPatternsLibrary.Observer.Observer;

namespace DesignPatternsLibrary.Observer.Subject
{
    // Subject
    public interface ICelebrity
    {
        string FullName { get; }
        string Tweet { get; set; }
        void Notify(string tweet);
        void AddFollower(IFan fan);
        void RemoveFollower(IFan fan);
    }
}

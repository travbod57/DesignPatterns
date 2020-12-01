using Observer.Subjects;

namespace Observer.Observers
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IRadio
    {
        void Output(Broadcaster broadcaster);
    }
}
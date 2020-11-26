using SimpleFactory.Fans;

namespace SimpleFactory
{
    public interface IFanFactory
    {
        IFan CreateFan(FanType type);
    }
}
using VikingLibPlcTagNet.Settings;

namespace VikingLibPlcTagNet.Interfaces
{
    public interface ITag : IDisposable
    {
        TagPath Path { get; }
        string FQN { get; }
        int Id { get; }
        string? Value { get; }
        string? PreviousValue { get; }
        bool Changed { get; }
        void Write(string value, ILoggable? logger = null);
        void Read(ILoggable? logger = null);
        void Toggle(ILoggable? logger = null);
    }
}

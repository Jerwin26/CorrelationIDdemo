namespace CorrelationIDdemo.Configurations.Interface
{
    public interface ICorrelationIdGenerator
    {
        string Get();
        void Set(string correlationId);
        
    }
}

namespace LifecycleExample.Services
{
    public class BaseService
    {
        public BaseService()
        {
            Id = Guid.NewGuid().ToString().Replace("-", string.Empty);
        }

        public string Id { get; set; }

        public string ShowId()
        {
            return $"O Id criado foi: {Id}";
        }
    }
}

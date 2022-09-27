using OneCore.Application.Common.Interfaces.Services;

namespace OneCore.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
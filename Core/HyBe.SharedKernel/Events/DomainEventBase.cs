using MediatR;

namespace HyBe.SharedKernel.Events;
public abstract class DomainEventBase : INotification
{
    public DateTime DateOccured { get; protected set; } = DateTime.UtcNow;
}
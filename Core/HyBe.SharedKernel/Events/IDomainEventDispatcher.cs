using HyBe.SharedKernel.Domain;

namespace HyBe.SharedKernel.Events;
public interface IDomainEventDispatcher
{
    Task DispatchAndClearEvents(IEnumerable<BaseEntity> entitesWithEvents);
}
using HyBe.SharedKernel.Domain;
using MediatR;

namespace HyBe.SharedKernel.Events;
public class DomainEventDispatcher : IDomainEventDispatcher
{
    #region Fields
    private readonly IMediator _mediatr;
    #endregion

    #region Constructor
    public DomainEventDispatcher(IMediator mediatr)
    {
        _mediatr = mediatr;
    }
    #endregion

    #region Methods
    public async Task DispatchAndClearEvents(IEnumerable<BaseEntity> entitiesWithEvents)
    {
        if (entitiesWithEvents is null)
        {
            return;
        }

        foreach (var entity in entitiesWithEvents)
        {
            var events = entity.DomainEvents.ToArray();
            entity.ClearDomainEvents();
            await PublishEventsAsync(events).ConfigureAwait(false);
        }
    }

    private async Task PublishEventsAsync(DomainEventBase[] events)
    {
        foreach (var domainEvent in events)
        {
            await _mediatr.Publish(domainEvent).ConfigureAwait(false);
        }
    }
    #endregion
}
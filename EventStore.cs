using System;
using System.Collections.Generic;

namespace MicroShoppingCart
{
  public class EventStore : IEventStore
  {
    public void Raise(string eventName, object content)
    {
      var seqNumber = database.NextSequenceNumber();
      database.Add(new Event(seqNumber, DateTimeOffset.UtcNow), eventName, content);
    }

    public IEnumerable<Event> GetEvents(long firstEventSequenceNumber, long lastEventSequenceNumber)
    {
      return database
        .Where(e => e.SequenceNumber >= firstEventSequenceNumber
          && e.SequenceNumber <= lastEventSequenceNumber)
        .OrderBy(e => e.SequenceNumber);
    }
  }
}
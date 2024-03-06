using System;
using Volo.Abp.Domain.Entities;

namespace TodoApp
{
    public class TodoApp
    {
        // BasicAggregateRoot --> to represent a cluster of associated objects treated as a single unit.
        // Guid --> each instance of the aggregate root has a unique identity.
        // then BasicAggregateRoot is the simplest base class to create root entities, and Guid is the primary key (Id) of the entity here.
        public class TodoItem : BasicAggregateRoot<Guid>
        {
            public string Text { get; set; }
        }
    }
}

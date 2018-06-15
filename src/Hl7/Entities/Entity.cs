using System;

namespace Hl7
{
    /// <summary>
    /// Base class for all Hl7 entities
    /// </summary>
    /// <typeparam name="TKey">The primary key type.</typeparam>
    public class Entity<TKey>
        where TKey : IEquatable<TKey>
    {
        public TKey Id { get; set; }
    }

    /// <summary>
    /// Shortcut for inheriting from Entity<{int}>.
    /// </summary>
    public class Entity : Entity<int>
    {

    }
}

namespace Gaby.Shared.Interfaces;

public interface IRemovable
{
    /// <summary>
    /// Returns if the entity is active.
    /// </summary>
    bool Active { get; set; }
}
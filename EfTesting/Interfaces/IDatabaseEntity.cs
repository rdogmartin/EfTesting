namespace EfTesting.Interfaces;

/// <summary>
/// Specifies that the object is persisted as a row in a database table.
/// </summary>
public interface IDatabaseEntity
{
    /// <summary>
    /// Gets or sets a value that uniquely identifies the entity in the database.
    /// </summary>
    int UniqueId { get; set; }
}

namespace NP.Lti13Platform.Core.Interfaces;

/// <summary>
/// Represents a partial list of items, typically used for pagination.
/// </summary>
/// <typeparam name="T">The type of items in the list.</typeparam>
public interface IPartialList<T>
{
    /// <summary>
    /// Gets or sets the items in the partial list.
    /// </summary>
    public IEnumerable<T> Items { get; set; }
    /// <summary>
    /// Gets or sets the total number of items available.
    /// </summary>
    public int TotalItems { get; set; }
}

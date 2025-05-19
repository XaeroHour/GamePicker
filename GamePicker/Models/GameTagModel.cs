using System;

namespace GamePicker.Models;

public class GameTagModel : IComparable
{
    public int Id { get; set; } = 0;

    public string Name { get; set; }

    public int CompareTo(object obj)
    {
        GameTagModel gameTag = obj as GameTagModel;
        return this.Name.CompareTo(gameTag?.Name);
    }

    public bool Equals(GameTagModel other)
    {
        if (other == null)
        {
            return false;
        }
        return this.Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase);
    }
}

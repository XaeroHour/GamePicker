using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePicker.Models
{
    public class GameTagModel : IComparable
    {
        public int Id { get; set; } = 0;

        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            GameTagModel gameTag = obj as GameTagModel;
            return this.Name.CompareTo(gameTag?.Name);
        }
    }
}

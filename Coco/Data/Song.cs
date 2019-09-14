using Coco.Common;

namespace Coco.Data
{
    public class Song
    {
        /// <summary>
        /// Parameterless constructor needed for XML serialization. Must be empty.
        /// </summary>
        public Song()
        {
        }

        public Song(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public int Number { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Concat(Number, CocoConstant.SeparatorSong, " ", Name);
        }
    }
}

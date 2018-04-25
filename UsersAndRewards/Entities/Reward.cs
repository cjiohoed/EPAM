using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reward
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Reward()
        {
            Title = String.Empty;
            Description = String.Empty;
        }

        public Reward(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}

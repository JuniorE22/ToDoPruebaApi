using System;

namespace ToDoPruebaApi.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Item()
        {
        
        }
    }
}

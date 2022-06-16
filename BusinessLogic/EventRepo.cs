using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class EventRepo
    {
        IList<Event> Events;

        public EventRepo()
        {
            Events = new List<Event>();
        }

        public int Count { get => Events.Count; }

        public void Add(Event evt)
        {
            if (evt is null)
                throw new ArgumentNullException(nameof(evt));
            if (Exists(evt.Name))
                throw new BusinessLogicException("Event already exsists");

            Events.Add(evt);
        }

        public bool Exists(string name)
        {
            return Events.Any(evt => evt.Name == name);
        }

        public Event Get(string name)
        {
            if (!Exists(name))
                throw new BusinessLogicException("Event does not exsist");
            return Events.First(evt => evt.Name == name);
        }

        public void Update(Event evt)
        {
            Remove(evt.Name);
            Add(evt);
        }

        public void Remove(string name)
        {
            Events = Events.Where(evt => evt.Name != name).ToList();
        }

        public IList<Event> GetAll()
        {
            return new List<Event>(Events); //return a copy, not the actual list!
        }

        public void Clear()
        {
            Events.Clear();
        }
    }
}

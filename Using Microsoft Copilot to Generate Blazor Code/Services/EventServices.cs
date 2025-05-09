namespace EventApp
{
    public class EventServices
    {
        private List<Event> events = new List<Event>();

        public EventServices() 
        {
            events.Add(new Event() {
                Id = 1,
                EventName = "Event 1",
                EventDate = DateTime.Now.AddDays(1),
                Location = "Location 1"
            });

            events.Add(new Event()
            {
                Id = 2,
                EventName = "Event 2",
                EventDate = DateTime.Now.AddDays(2),
                Location = "Location 2"
            });

            events.Add(new Event()
            {
                Id = 3,
                EventName = "Event 3",
                EventDate = DateTime.Now.AddDays(3),
                Location = "Location 3"
            });
        }

        public List<Event> GetEvents()
        {
            return events;
        }

        public Event GetEventById(int id)
        {
            return events.FirstOrDefault(e => e.Id == id);
        }

        public void AddEvent(Event newEvent)
        {
            events.Add(newEvent);
        }

        public void RemoveEvent(Event eventToRemove)
        {
            events.Remove(eventToRemove);
        }

        public void UpdateEvent(Event updatedEvent)
        {
            var existingEvent = events.FirstOrDefault(e => e.Id == updatedEvent.Id);
            if (existingEvent != null)
            {
                existingEvent.EventName = updatedEvent.EventName;
                existingEvent.EventDate = updatedEvent.EventDate;
                existingEvent.Location = updatedEvent.Location;
            }
        }
    }
}

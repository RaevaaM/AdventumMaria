using System.ComponentModel;

namespace Adventum.Data
{
    public class SportActivity
    {
        public int Id { get; set; }
        [DisplayName("Спорт")]

        public string Name { get; set; }

        [DisplayName("Кратко  описание")]
        public string Description { get; set; }

        [DisplayName("Видео URL")]
        public string VideoURL { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}

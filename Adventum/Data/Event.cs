using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adventum.Data
{
    public class Event
    {
        public int Id { get; set; }
        [Display(Name = "Събитие")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Кратко описание")]
        public string ShortDescription { get; set; }
        [Display(Name = "Продължителност")]
        public string Duration { get; set; }
        
        [DataType(DataType.Currency)]
       
        public double Price { get; set; }

        public string ImageUrl { get; set; }

        [ForeignKey(nameof(SportActivity))]
        [Display(Name = "Спорт")]
        public int SportActivityId { get; set; }
        [Display(Name = "Локация")]

        [ForeignKey(nameof(Location))]
        public int LocationId { get; set; }

        public virtual SportActivity SportActivity { get; set; }
        public virtual Location Location { get; set; }

        public ICollection<EventReservation> EventReservations { get; set; }
    }
}

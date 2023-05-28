using System.ComponentModel.DataAnnotations;

namespace Adventum.Data
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Местоположение")]
        public string Name { get; set; }
        [Display(Name = "Ширина")]
        public string Latitude { get; set; }
        [Display(Name = "Дължина")]
        public string Longitude { get; set; }
        [Display(Name = "Събития")]
        public virtual ICollection<Event> Events { get; set; }
    }
}


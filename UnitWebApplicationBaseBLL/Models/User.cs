using System.ComponentModel.DataAnnotations;
using UnitWebApplicationBLL.Intercafes;

namespace UnitWebApplicationBLL.Models
{
    public class User:IUser
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

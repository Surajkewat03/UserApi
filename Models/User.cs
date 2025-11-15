using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UserApi.Models
{
    [Table("Test")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobilNo { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}

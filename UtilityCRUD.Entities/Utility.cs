using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilityCRUD.Entities
{
    public class Utility
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string MSOFFICE { get; set; }
        public string Programing { get; set; }
        public int Languages { get; set; }


    }
}
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBootstrap4Validation.ViewModels
{
    public class StandardValidationModel
    {
        public bool IsCool { get; set; }

        [Range(0, 110, ErrorMessage ="outside my validation range..." )]
        public int Age { get; set; }

        [Required(ErrorMessage = "Required error message defined on the model")]
        public string Name { get; set; }
    }
}

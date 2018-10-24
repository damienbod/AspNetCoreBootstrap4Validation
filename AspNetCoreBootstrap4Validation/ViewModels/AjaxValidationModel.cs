using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBootstrap4Validation.ViewModels
{
    public class AjaxValidationModel
    {
        public bool IsCool { get; set; }

        public int Age { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreBootstrap4Validation.ViewModels
{
    public class RemoteValidationModel
    {
        public bool IsCool { get; set; }

        [Required]
        [Remote(action: "VerifyNameAndAge", controller: "RemoteTest", AdditionalFields = nameof(Name))]
        public int Age { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

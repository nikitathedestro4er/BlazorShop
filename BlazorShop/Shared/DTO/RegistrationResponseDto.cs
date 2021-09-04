using System.Collections;
using System.Collections.Generic;

namespace BlazorShop.Shared.DTO
{
    public class RegistrationResponseDto
    {
        public bool IsSuccessfulRegistration { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
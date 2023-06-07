using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bookish.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
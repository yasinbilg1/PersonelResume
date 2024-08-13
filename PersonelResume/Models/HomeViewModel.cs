
using PersonelResume.Models;

namespace PersonelResume.Models
{
    public class HomeViewModel
    {
        public required Home Home { get; set; }
        public required List<Experience> Experiences { get; set; }
        public required List<References> References { get; set; }
        public required Personelİnfo Personelİnfo { get; set; }
    }
}

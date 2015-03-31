using System.ComponentModel.DataAnnotations;

namespace SampleSortableChildCollectionForm.Models.Editors
{
    public class AddressEditorViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }
    }
}
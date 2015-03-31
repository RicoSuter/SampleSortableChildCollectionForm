using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SampleSortableChildCollectionForm.Models.Editors;

namespace SampleSortableChildCollectionForm.Models
{
    public class PersonEditViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public IEnumerable<AddressEditorViewModel> Addresses { get; set; }
    }
}
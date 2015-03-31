using System.Web.Mvc;
using System.Diagnostics;
using SampleSortableChildCollectionForm.Models;
using SampleSortableChildCollectionForm.Models.Editors;

namespace SampleSortableChildCollectionForm.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View(new PersonEditViewModel());
        }

        [HttpPost]
        public ActionResult Index(PersonEditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // TODO: Save changes of viewModel.Addresses to database
                Debugger.Break();
                
                return RedirectToAction("Index");
            }
            else
                return View(viewModel);
        }

        public ActionResult GetAddressEditor()
        {
            return PartialView("Editors/_AddressEditor", new AddressEditorViewModel());
        }
    }
}
using Owin;
using Microsoft.Owin;

[assembly: OwinStartupAttribute(typeof(SampleSortableChildCollectionForm.Startup))]
namespace SampleSortableChildCollectionForm
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}

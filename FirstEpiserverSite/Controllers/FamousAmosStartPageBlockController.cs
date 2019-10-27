using System.Web.Mvc;
using FirstEpiserverSite.Models.Blocks;
using EPiServer.Web.Mvc;

namespace FirstEpiserverSite.Controllers
{
    public class FamousAmosStartPageBlockController : BlockController<FamousAmosStartPageBlock>
    {
        public override ActionResult Index(FamousAmosStartPageBlock currentblock)
        {
            return PartialView(currentblock);
        }

    }
}

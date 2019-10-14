using System.Web.Mvc;
using FirstEpiserverSite.Models.Blocks;
using EPiServer.Web.Mvc;

namespace FirstEpiserverSite.Controllers
{
    public class JumbotronBlockController : BlockController<JumbotronBlock>
    {
        public override ActionResult Index(JumbotronBlock currentblock)
        {
            return PartialView(currentblock);
        }

    }
}

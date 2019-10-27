using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace FirstEpiserverSite.Models.Pages
{
    [ContentType]
    public class StartPage : PageData
    {
        public virtual ContentArea MainContentArea { get; set; }
    }
}
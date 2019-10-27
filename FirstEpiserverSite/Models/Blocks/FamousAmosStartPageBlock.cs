using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace FirstEpiserverSite.Models.Blocks
{
    [ContentType(
        GUID = "77b6a134-0193-485f-a26c-1cb4c8c26cc9",
        DisplayName = "Jumbotron",
        Description = "Jumbotron blocktype with header, description, image and button")]
    [ImageUrl("~/Source/repo/FirstEpiserverSite/FirstEpiserverSite/Assets/Images")]
    public class FamousAmosStartPageBlock : BlockData
    {
        [Display(
            Name = "Brand logo",
            Description = "Add a brand logo",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [Required]
        public virtual Url brandLogo { get; set; }

        [Display(
            Name = "Brand name",
            Description = "Enter a brand name",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [Required]
        public virtual string brandName { get; set; }

        [Display(
            Name = "Brand description",
            Description = "Enter a brand description",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        [Required]
        public virtual XhtmlString brandDescription { get; set; }

        [Display(
            Name = "Brand image",
            Description = "Add a brand image",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        [Required]
        public virtual Url brandImage { get; set; }
    }
}
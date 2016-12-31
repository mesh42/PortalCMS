﻿using Portal.CMS.Entities.Entities.Authentication;
using Portal.CMS.Entities.Entities.Generic;
using Portal.CMS.Entities.Entities.PageBuilder;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web;

namespace Portal.CMS.Web.Areas.Builder.ViewModels.Section
{
    public class EditViewModel
    {
        public int PageId { get; set; }

        public int SectionId { get; set; }

        public string BackgroundType { get; set; }

        public int BackgroundImageId { get; set; }

        [DisplayName("Background Colour")]
        public string BackgroundColour { get; set; }

        [DisplayName("Height")]
        public PageSectionHeight PageSectionHeight { get; set; }

        [DisplayName("Background Style")]
        public PageSectionBackgroundStyle PageSectionBackgroundStyle { get; set; }

        public IEnumerable<Portal.CMS.Entities.Entities.Generic.Image> ImageList { get; set; }

        [DisplayName("Roles")]
        public List<string> SelectedRoleList { get; set; } = new List<string>();

        [DisplayName("Attach Image")]
        public HttpPostedFileBase AttachedImage { get; set; }

        [DisplayName("Category")]
        public ImageCategory ImageCategory { get; set; }

        public List<Role> RoleList { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class WizardStep
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string StateName { get; set; }
        public bool ShowResetBtn { get; set; }
        public bool ShowSaveForUpdate { get; set; }
        public int StepNumber { get; set; }
        public int TemplateId { get; set; }

        public WizardTemplate Template { get; set; }
    }
}

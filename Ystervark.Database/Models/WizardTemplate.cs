using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class WizardTemplate
    {
        public WizardTemplate()
        {
            WizardStep = new HashSet<WizardStep>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string DisplayName { get; set; }
        public string ActionIdentifier { get; set; }
        public string CancelState { get; set; }

        public ICollection<WizardStep> WizardStep { get; set; }
    }
}

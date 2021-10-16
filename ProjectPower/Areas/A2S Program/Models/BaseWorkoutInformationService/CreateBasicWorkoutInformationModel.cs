using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Models.BaseWorkoutInformationService
{
    public class CreateBasicWorkoutInformationModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
    }
}

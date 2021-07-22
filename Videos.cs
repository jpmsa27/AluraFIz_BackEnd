using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_API_VIDEO
{
    public class Videos
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string titulo { get; set; }
        [Required]
        public string descricao { get; set; }
        [Required]
        public string url { get; set; }

    }
}

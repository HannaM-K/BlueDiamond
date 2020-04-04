using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public class Image
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        /// <summary>
        /// 0 - Vertical, 1 - horizontal
        /// </summary>
        public int Type { get; set; }
        public byte[] Img { get; set; }
    }
}

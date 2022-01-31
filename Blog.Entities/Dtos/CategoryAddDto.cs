using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(70, ErrorMessage ="{0}{1} karakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0}{1} karakterden az olmamalıdır.")]
        public string Name { get; set; }



    }
}

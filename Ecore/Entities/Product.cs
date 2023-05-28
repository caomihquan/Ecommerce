using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecore.Entities
{
    [Table("Products")]
    public class Product:BaseEntity
    {
        public string ProductName { get; set; } = string.Empty;
    }

    
}

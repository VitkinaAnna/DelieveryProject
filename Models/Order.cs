using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DelieveryWebApplication
{
    public partial class Order
    {
        public Order()
        {
            Delieveries = new HashSet<Delievery>();
        }

        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public int CourierId { get; set; }

        [Required(ErrorMessage = "Поле не повинне бути порожнім")]
        [Display(Name = "Час замовлення")]
        public DateTime Time { get; set; }

        [Required(ErrorMessage = "Поле не повинне бути порожнім")]
        [Display(Name = "Час доставки")]
        public DateTime DelieveryTime { get; set; }

        [Display(Name = "Клієнт")]
        public virtual Client Client { get; set; } = null!;
        [Display(Name = "Кур`єр")]
        public virtual Courier Courier { get; set; } = null!;
        public virtual ICollection<Delievery> Delieveries { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gosuslugi1.Models
{
    public class Order
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        /// <summary>
        /// Название услуги
        /// </summary>
        [Required]
        [Display(Name = "Название услуги", Order = 5)]
        public string Title { get; set; }
        /// <summary>
        /// Дата записи
        /// </summary>

        [Display(Name = "Дата посещения", Order = 10)] 
        public DateTime Date { get; set; }
        /// <summary>
        /// Имя клиента
        /// </summary>
        [Required]
        [Display(Name = "Имя клиента", Order = 20)]
        public string Name { get; set; }
        /// <summary>
        /// Фамилия клиента
        /// </summary>
        [Required]
        [Display(Name = "Фамилия клиента", Order = 30)]
        public string Surname { get; set; }
        /// <summary>
        /// Дата рождения клиента
        /// </summary>
        [Display(Name = "Дата рождения", Order = 40)]
        public DateTime Date_of_Birth { get; set; }
    }
}
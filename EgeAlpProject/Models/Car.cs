using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgeAlpProject.Models
{

        public class Car
        {

            public int Id { get; set; }

            public int MemberId { get; set; }

            [Required]
            [StringLength(255)]
            [Display(Name = "Baslik")]
            public string Name { get; set; }

            [Display(Name = "Aracin Markasi")]
            public int CarBrandId { get; set; }
            public CarBrand CarBrand { get; set; }

            [Display(Name = "Model Senesi")]
            [Required]
            public int? year { get; set; }
            [Display(Name = "KMsi")]
            public int VehicleKm { get; set; }
            [Display(Name = "Yakit Tipi")]
            public string FuelType { get; set; }
            [Display(Name = "Ortalama Yakit")]
            public int AvgCons { get; set; }
            [Display(Name = "Gunluk Fiyat")]
            public Decimal Price { get; set; }
            [Display(Name = "Aciklama")]
            public string Description { get; set; }
            [Display(Name = "Konum Bilgisi")]
            public string Location { get; set; }

            public DateTime CreatedDate { get; set; }
            public Car()
            {
                CreatedDate = DateTime.Now;
            }

            public virtual List<CarImage> CarImages { get; set; }

        }
    }




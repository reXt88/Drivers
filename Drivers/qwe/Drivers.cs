namespace Drivers.qwe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drivers
    {
        [Key]
        [Column("Идентификатор (GUID)")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Идентификатор__GUID_ { get; set; }

        [StringLength(50)]
        public string Фамилия { get; set; }

        [StringLength(50)]
        public string Имя { get; set; }

        [StringLength(50)]
        public string Отчество { get; set; }

        [Column("Пасспорт (серия и номер)")]
        [StringLength(50)]
        public string Пасспорт__серия_и_номер_ { get; set; }

        [Column("Адрес регистрации")]
        [StringLength(50)]
        public string Адрес_регистрации { get; set; }

        [Column("Адрес проживания")]
        [StringLength(50)]
        public string Адрес_проживания { get; set; }

        [Column("Место работы")]
        [StringLength(50)]
        public string Место_работы { get; set; }

        [Required]
        [StringLength(50)]
        public string Должность { get; set; }

        [Column("Мобильный телефон")]
        [StringLength(50)]
        public string Мобильный_телефон { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Фотография { get; set; }

        [Required]
        [StringLength(50)]
        public string Замечания { get; set; }
    }
}

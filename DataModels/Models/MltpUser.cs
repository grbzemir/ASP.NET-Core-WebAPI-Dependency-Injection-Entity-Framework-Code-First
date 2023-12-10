using System.ComponentModel.DataAnnotations.Schema;

namespace DataModels.Models
{

    [Table("mltp_user")]
    public class MltpUser
    {
        //Column satırı ile veritabanındaki kolon isimleri ile eşleştiriyoruz.

        [Column("ID")]
        public virtual int Id { get; set; }

        [Column("USERNAME")]
        public virtual string Username { get; set; }

        [Column("NAME")]
        public virtual string Name{ get; set; }

        [Column("SURNAME")]
        public virtual string Surname { get; set; }

        [Column("EMAIL")]
        public virtual string Email { get; set; }

        [Column("PASSWORD")]
        public virtual string Password  { get; set; }

        [Column("GSM")]
        public virtual string Gsm { get; set; }



    }
}
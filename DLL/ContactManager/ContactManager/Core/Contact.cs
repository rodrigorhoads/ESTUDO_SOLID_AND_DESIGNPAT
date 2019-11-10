using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace ContactManager.Core
{
    [Serializable]
    [Table("Contacts")]
    public class Contact : ICloneable
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(40)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        public object Clone()
        {
            return this.Clone();
        }

        public object CopiaProfunda()
        {
            if (!this.GetType().IsSerializable)
                throw new Exception("Objeto deve ser serializavel.");

            Contact deepCopy = null;

            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                deepCopy = (Contact)formatter.Deserialize(stream);                
            }


            return deepCopy;
        }
    }
}


using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class NAMFile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FileName { get; set; }

        [Required]
        public long FileSize { get; set; } // Size in bytes

        [Required]
        public DateTime UploadedAt { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public int UploadedById { get; set; }

        public bool IsPublic { get; set; } = true;

        [Required]
        public byte[] FileContent { get; set; } // Store the file content as a BLOB
    }
}


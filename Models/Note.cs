using System;

namespace NotePad_api.Models
{
    public class Note
    {
        public string Id { get; set; }
        public string title { get; set; }
        public string note { get; set; }
        public DateTime CreateDate { get; set; }
        public bool sync { get; set; }
    }
}
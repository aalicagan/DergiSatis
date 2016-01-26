using System;
using Dergi.Model;

namespace Dergi.Business.ViewModel
{
    public class AboneDergiViewModel
    {
        public int Id { get; set; }
        public int AboneId { get; set; }
        public int DergiId { get; set; }
        public string AboneName { get; set; }
        public string AboneSurname { get; set; }
        public string DergiName { get; set; }
        public bool IsDelivered { get; set; }
        public DateTime IslemDate { get; set; } 
    }
}
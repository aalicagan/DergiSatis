using System;
using System.Collections.Generic;

namespace Dergi.Business.ViewModel
{
    public class AboneHesapViewModel
    {
        public int Id { get; set; }
        public int AboneId { get; set; }
        public string  AboneName { get; set; }
        public string AboneSurname { get; set; }
        public Model.Util.IslemType IslemType { get; set; }
        public DateTime IslemDate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
       
    }

    public class AboneHesapMasterViewModel
    {
        public List<AboneHesapViewModel> AboneHesapViewModels { get; set; }
        public decimal Balance { get; set; } 
    }
}
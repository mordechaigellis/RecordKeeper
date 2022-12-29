using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecordKeeperBizObjects
{
    public class bizParty : bizObject<bizParty>
    {
        string partynameval = "";
        string partycoloval = "";
        int yearstartval = 0;
        int presidentcountval = 0;
        List<bizPresident> lstpresident;
        public bizParty() 
        {

        }


        //p.PartyColor, p.YearStart, PresidentCount 

        public int PartyId {
            get => this.PrimaryKeyValue;
            set => this.PrimaryKeyValue = value;
        }

        [Required]
        [Display(Name = "Party Name")]
        public string PartyName
        {
            get { return partynameval; }
            set { partynameval = value;
                InvokePropertyChanged();
            }
        }

        [Required]
        [Display(Name = "Year Start")]
        public int YearStart {
            get { return yearstartval; }
            set {
                yearstartval = value;
                InvokePropertyChanged();
            }
        }

        public int PresidentCount
        {
            get { return presidentcountval; }
            set
            {
                presidentcountval = value;
                InvokePropertyChanged();
            }
        }

        [Required]
        [Display(Name = "Color")]
        public string PartyColor
        {
            get { return partycoloval; }
            set
            {
                partycoloval = value;
                InvokePropertyChanged();
            }
        }

        public List<bizPresident> PresidentList(bool refresh) {

            if (refresh == true || lstpresident == null) { 
                lstpresident = bizPresident.GetList("PartyName", this.PartyName);
            }

            return lstpresident;
        }
    }
}

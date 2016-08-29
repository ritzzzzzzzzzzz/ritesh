using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empbo
{
    public class applicationform
    {
        int ApplicationNo;
        DateTime MarraigeDate;
        string Created_by, Modified_by;
        string MrgLocation, Address, District, State, Nationality, UserName;
        int Noofcopies, HusbandId, WifeId;
        DateTime Created_Date, Modified_Date;
        public string modifiedby
        {
            get
            {
                return Modified_by;
            }
            set
            {
                Modified_by = value;
            }
        }
        public string createdby
        {
            get
            {
                return Created_by;
            }
            set
            {
                Created_by = value;
            }
        }
        public DateTime modified
        {
            get
            {
                return Modified_Date;
            }
            set
            {
                Modified_Date = value;
            }
        }
        public DateTime created
        {
            get
            {
                return Created_Date;
            }
            set
            {
                Created_Date = value;
            }
        }
        public DateTime marg
        {
            get
            {
                return MarraigeDate;
            }
            set
            {
                MarraigeDate = value;
            }
        }
        public string username
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }
        public string nationality
        {
            get
            {
                return Nationality;
            }
            set
            {
                Nationality = value;
            }
        }
        public string state
        {
            get
            {
                return State;
            }
            set
            {
                State = value;
            }
        }
        public string district
        {
            get
            {
                return District;
            }
            set
            {
                District = value;
            }
        }

        public string address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public string location
        {
            get
            {
                return MrgLocation;
            }
            set
            {
                MrgLocation = value;
            }
        }
        public int wife
        {
            get
            {
                return WifeId;
            }
            set
            {
                WifeId = value;
            }
        }
        public int husband
        {
            get
            {
                return HusbandId;
            }
            set
            {
                HusbandId = value;
            }
        }
        public int idd
        {
            get
            {
                return ApplicationNo;
            }
            set
            {
                ApplicationNo = value;
            }
        }
        public int coopies
        {
            get
            {
                return Noofcopies;
            }
            set
            {
                Noofcopies = value;
            }
        }
        public int id
        {
            get
            {
                return ApplicationNo;
            }
            set
            {
                ApplicationNo = value;
            }
        }
        public applicationform()
        {
            ApplicationNo = idd;
            MarraigeDate = marg;
            MrgLocation = location;
            Address = address;
            District = district;
            State = state;
            Nationality = nationality;
            UserName = username;
            Noofcopies = coopies;
            HusbandId = husband;
            WifeId = wife;
            Created_by = createdby;
            Created_Date = created;
            Modified_by = modifiedby;
            Modified_Date = modified;

        }

    }
}
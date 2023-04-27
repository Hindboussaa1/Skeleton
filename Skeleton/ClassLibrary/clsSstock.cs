using System;

namespace ClassLibrary
{
    public class clsSstock
    {
        private Int32 mCarID;
        private Boolean mActive;
        public bool Active { get {
                return mActive;
            }
            set {
                mActive = value;
            }
        }

        private DateTime mCarYear;
        public DateTime DateAdded { get
            {
                return mCarYear;
            }
            set
            {
                mCarYear = value;
            }
        }
        public Int32 CarId {
            get
            {
                return mCarID;
            
            }
            set
            {
                mCarID = value;
            }
        }

        private string mCarBrand;
        public string CarBrand {
            get
            {
                return mCarBrand;
            }
            set {
                mCarBrand = value;
            } 
        }

        private string mCarModel;
        public string CarModel { get {
                return mCarModel;
            }
            set {
                mCarModel = value;
            } }

        private string mCarColor;
        public string CarColor { get {
                return mCarColor;
            } set {
                mCarColor = value;
            } }

        public bool Find(int carID)
        {
            mCarID = 2;
            mCarColor = "Test Car Color";
            mCarModel = "Test Car Model";
            mCarYear = Convert.ToDateTime("17/08/2022");
            mCarBrand = "Test Car Brand";
            mActive = true;
            mActive = true;
            return true;
        }
    }
}
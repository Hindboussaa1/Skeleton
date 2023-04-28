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

        public void Find(object carID)
        {
            throw new NotImplementedException();
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

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter(carID, carID);

            DB.Execute("sproc_tblStock_FilerByCarID");
            if (DB.Count == 1)
            {
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarId"]);
                mCarBrand = Convert.ToString(DB.DataTable.Rows[0]["CarBrand"]);
                mCarModel = Convert.ToString(DB.DataTable.Rows[0]["CarModel"]);
                mCarColor = Convert.ToString(DB.DataTable.Rows[0]["CarColor"]);
                mCarYear = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                return true;
            }
            else
            {
                return false;
            }


            //mCarID = 2;
            //mCarColor = "Test Car Color";
            //mCarModel = "Test Car Model";
            //mCarYear = Convert.ToDateTime("17/08/2022");
            //mCarBrand = "Test Car Brand"
            //mActive = true;
            //return true;
        }

        public void Find(object carId)
        {
            throw new NotImplementedException();
        }

        public string Valid(string dateAdded, string carModel, string carColor, string carBrand, bool active)
        {
            String Error = "";
            DateTime DateTemp;

            if (carBrand.Length == 0)
            {
                Error = Error + "The car Brand may not be blank : ";

            }
            if (carBrand.Length > 499)
            {
                Error = Error + "The Car Brand no must be less than 6 characters : ";
            }
            if (carColor.Length == 0)
            {
                Error = Error + "The car Brand may not be blank : ";

            }
            if (carColor.Length > 499)
            {
                Error = Error + "The Car Brand no must be less than 6 characters : ";
            }
            if (carModel.Length == 0)
            {
                Error = Error + "The car Brand may not be blank : ";

            }
            if (carModel.Length > 499)
            {
                Error = Error + "The Car Brand no must be less than 6 characters : ";
            }
            try
            {


                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {

                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            
                return Error;
            
        }
    
    }
}
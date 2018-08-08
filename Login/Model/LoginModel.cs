using System;
using System.Linq;

namespace PointOfSalesApp.Model
{
    class LoginModel : IModel
    {

        private int mId;
        private string mName;
        private string mUsername;
        private string mPassword;
        private string mDesignation;
        private string mContact;
        private string mEmail;
        private int? mBirthdate;
        private int? mAge;
        private string mEmergencyContact;
        private string mEmergencyContactNum;
        private string mUserImage;

        public int id
        {
            get
            {
                return mId;
            }

            set
            {
                mId = value;
            }
        }

        public string name
        {
            get
            {
                return mName;
            }

            set
            {
                mName = value;
            }
        }

        public string username
        {
            get
            {
                return mUsername;
            }

            set
            {
                mUsername = value;
            }
        }

        public string userPassword
        {
            get
            {
                return mPassword;
            }

            set
            {
                mPassword = value;
            }
        }

        public string designation
        {
            get
            {
                return mDesignation;
            }

            set
            {
                mDesignation = value;
            }
        }

        public string contact
        {
            get
            {
                return mContact;
            }

            set
            {
                mContact = value;
            }
        }

        public string email
        {
            get
            {
                return mEmail;
            }

            set
            {
                mEmail = value;
            }
        }

        public int? birthdate
        {
            get
            {
                return mBirthdate;
            }

            set
            {
                mBirthdate = value;
            }
        }

        public int? age
        {
            get
            {
                return mAge;
            }

            set
            {
                mAge = value;
            }
        }

        public string emergencyContact
        {
            get
            {
                return mEmergencyContact;
            }

            set
            {
                mEmergencyContact = value;
            }
        }

        public string emergencycontactNum
        {
            get
            {
                return mEmergencyContactNum;
            }

            set
            {
                mEmergencyContactNum = value;
            }
        }

        public string userImage
        {
            get
            {
                return mUserImage;
            }

            set
            {
                mUserImage = value;
            }
        }

        public int validateLogin()
        {
            using (var db = new POS_DEVEntities())
            {
                try
                {
                    var employee = db.users
                        .AsNoTracking()
                        .Where(e => e.username == mUsername && e.userPassword == mPassword)
                        .SingleOrDefault();

                    if (employee == null)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                    return -2;
                }
            }    
        }

        public bool validateInputs()
        {
            return mUsername != "" && mPassword != "";
        }
    }
}

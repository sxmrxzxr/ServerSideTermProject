using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermLibrary
{
    [Serializable]
    public class CloudStorage
    {
        //TermAccount
        int accountID, adminLevel;
        string firstName, lastName, email, password;
        //Term Storage
        int capacity, filled;
        //TermFileData
        int fileDataID, fileID, fileSize;
        DateTime dateUploaded, dateModified;
        string name, fileType;

        public int AccountID
        {
            get
            {
                return accountID;
            }
            set
            {
                accountID = value;
            }
        }

        public int AdminLevel
        {
            get
            {
                return adminLevel;
            }
            set
            {
                adminLevel = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public int Filled
        {
            get
            {
                return filled;
            }
            set
            {
                filled = value;
            }
        }

        public int FileDataID
        {
            get
            {
                return fileDataID;
            }
            set
            {
                fileDataID = value;
            }
        }

        public int FileID
        {
            get
            {
                return fileID;
            }
            set
            {
                fileID= value;
            }
        }

        public int FileSize
        {
            get
            {
                return fileSize;
            }
            set
            {
                fileSize = value;
            }
        }

        public DateTime DateModified
        {
            get
            {
                return dateModified;
            }
            set
            {
                dateModified = value;
            }
        }

        public DateTime DateUploaded
        {
            get
            {
                return dateUploaded;
            }
            set
            {
                dateUploaded = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string FileType
        {
            get
            {
                return fileType;
            }
            set
            {
                fileType = value;
            }
        }
    }
}

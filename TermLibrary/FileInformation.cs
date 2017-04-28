using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermLibrary
{
    public class FileInformation
    {
        int fileDataID, fileID, fileSize;
        DateTime dateUploaded, dateModified;
        string name, fileType;

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
                fileID = value;
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
